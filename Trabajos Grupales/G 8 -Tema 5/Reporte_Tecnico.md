# Reporte Técnico de Cátedra - Fase 1

**Juego Asignado:** Doom
**Número de Grupo:** Grupo 05

---

## 1. Integrantes del Equipo

* Monteros Matias - Legajo 140911 (Rol: Personajes y Juego / Rama: dev-MatiasMonteros-140911)
* Lezcano Luz - Legajo 67119 (Rol: Armas / Rama: dev-LuzLezcano-67119)

---

## 2. Diagnóstico y Arquitectura Inicial

Para el juego Doom decidimos hacer una versión simple por consola, jugada por turnos. El jugador se mueve por un mapa hecho con caracteres, pelea contra monstruos, junta objetos y tiene que matar a todos los enemigos y llegar a la salida para ganar.

Dividimos el programa en tres archivos:

| Archivo | Contenido | Integrante |
|---|---|---|
| `Personajes.cs` | `Personaje`, `Jugador`, `Enemigo`, `Zombie`, `Imp`, `Demonio` | Monteros Matias |
| `Armas.cs` | `Arma`, `Motosierra`, `Pistola`, `Escopeta`, `Objeto`, `Botiquin`, `CajaMunicion`, `ObjetoArmadura` | Lezcano Luz |
| `Juego.cs` | `Juego` (mapa y reglas) y `Program` (`Main`) | Monteros Matias |

Usamos **herencia** para no repetir código: todos los personajes comparten nombre, vida y posición; todas las armas comparten daño y alcance; todos los objetos comparten posición y símbolo. Usamos **polimorfismo** para que cada tipo haga algo distinto con el mismo método (por ejemplo, cada enemigo ataca de forma diferente).

---

## 3. Módulos y Clases Implementadas (Mínimo 4)

Se implementaron 15 clases en total. Las principales son:

* **Clase Base: `Personaje`** (`Personajes.cs`). Tiene los atributos protegidos (`protected`) `nombre`, `vida`, `x` e `y`, un constructor y estos métodos: `RecibirDanio` (declarado como `virtual` para poder sobrescribirlo), `EstaVivo` y `MoverA`.
* **Clase Derivada 1: `Jugador`** (`Personajes.cs`). Hereda de `Personaje` y agrega armadura, munición, puntos y un arreglo de armas, todos privados (`private`). Sobrescribe (`override`) `RecibirDanio` porque la armadura absorbe la mitad del daño. También tiene `Atacar`, `Curar` y `CambiarArma`.
* **Clase Derivada 2: `Enemigo`** (`Personajes.cs`). Hereda de `Personaje` y tiene un método `Atacar` virtual. De ella heredan `Zombie`, `Imp` y `Demonio`, y cada uno sobrescribe (`override`) `Atacar` con un daño y un mensaje distintos (polimorfismo).
* **Clase Gestora: `Juego`** (`Juego.cs`). Administra las colecciones del juego, que son privadas: una `List<Enemigo>` con todos los monstruos y una `List<Objeto>` con los objetos del mapa. Se encarga del turno de los enemigos, del movimiento, de recoger objetos y de las condiciones de victoria o derrota.

Otras clases del programa:

* `Arma` (base, con atributos `protected`) con `Motosierra`, `Pistola` y `Escopeta` como derivadas. `Escopeta` sobrescribe `CalcularDanio` porque dispara varios perdigones.
* `Objeto` (base) con `Botiquin`, `CajaMunicion` y `ObjetoArmadura` como derivadas. Cada una sobrescribe `Usar` con un efecto distinto.

---

## 4. Control de Errores y Validaciones

Usamos encapsulamiento: los datos de las clases son `private` o `protected`, y desde afuera solo se pueden leer con `get`. Para modificarlos hay que usar métodos o propiedades con `set` que validan el valor. Así se previenen estos valores inválidos:

* **Vida negativa:** `vida` es protegida y solo cambia con `RecibirDanio`, que la deja en 0 si el daño es mayor a la vida que quedaba. Un daño negativo se ignora, así que no puede curar por error.
* **Vida mayor a 100:** `Curar` limita la vida a 100 y rechaza cantidades negativas.
* **Armadura inválida:** la propiedad `Armadura` tiene un `set` que no deja que sea menor a 0 ni mayor a 200. Además, la armadura nunca absorbe más daño del que tiene disponible.
* **Munición negativa:** la propiedad `Municion` tiene un `set` que la deja en 0 si se intenta poner un valor negativo. `Atacar` revisa que alcance la munición antes de disparar.
* **Puntos:** son de solo lectura (`get`). Solo se pueden sumar con `SumarPuntos`, que ignora cantidades negativas.
* **Posición:** `X` e `Y` son de solo lectura. Para moverse se usa `MoverA`, y antes `Juego` verifica con `EsCaminable` que no sea una pared, que no esté fuera del mapa y que no haya un enemigo en esa casilla.
* **Cambio de arma:** `CambiarArma` solo acepta posiciones válidas del arreglo (0, 1 o 2).
* **Ataque:** solo se puede atacar a enemigos vivos que estén dentro del alcance del arma equipada.

---

## 5. Guía de Ejecución en Consola

1. Abrir la solución en Visual Studio. Deben estar en el proyecto los tres archivos: `Personajes.cs`, `Armas.cs` y `Juego.cs`.
2. Presionar **F5** (o el botón verde "Iniciar"). El `Main()` está en `Juego.cs`, dentro de la clase `Program`.
3. Controles del juego:

| Tecla | Acción |
|---|---|
| `W` `A` `S` `D` | Moverse |
| `F` | Atacar al enemigo más cercano que esté al alcance |
| `1` `2` `3` | Cambiar de arma (Motosierra, Pistola, Escopeta) |
| `Q` | Salir |

4. Cómo verificar el **polimorfismo**:
   * **Enemigos:** acercarse a un `Zombie` (Z), a un `Imp` (I) y a un `Demonio` (D). Cada uno ataca con un mensaje y un daño diferentes aunque el juego llama siempre al mismo método `Atacar`.
   * **Armas:** probar con las teclas 1, 2 y 3. Cada arma calcula el daño a su manera (la escopeta suma varios perdigones).
   * **Objetos:** pasar por encima de `+` (botiquín), `A` (armadura) y `a` (munición). Cada uno aplica un efecto distinto con el mismo método `Usar`.
5. Para ganar hay que eliminar a todos los enemigos y pararse sobre la salida `E`.

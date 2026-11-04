# REPORTE TÉCNICO — FASE 2

**Proyecto:** DOOM 2D  
**Grupo:** 08  
**Materia:** Programación de Videojuegos I — UTN FRT

## 1. Integrantes y legajos

- **Jacin Farid — Legajo 67042:** Líder del grupo. Responsable de la configuración de Unity, movimiento del jugador, físicas, colisiones, apuntado, integración del modelo C# y coordinación del proyecto.
- **Ferullo Luca — Legajo 67221:** Integrante. Responsable de los scripts iniciales de disparo, proyectiles y objetos recolectables.

## 2. Diagnóstico del proyecto heredado

El proyecto recibido del Grupo 05 contenía una arquitectura C# organizada en tres archivos principales: `Personajes.cs`, `Armas.cs` y `Juego.cs`.

El código incluía clases para el jugador, personajes enemigos, armas y objetos recolectables. También implementaba herencia, encapsulamiento y polimorfismo.

Sin embargo, el juego funcionaba originalmente mediante una consola de texto, con un mapa representado por caracteres y movimiento por turnos utilizando `Console.ReadKey()`.

Por este motivo, fue necesario adaptar la arquitectura existente para integrarla con Unity 2D, conservando las clases de lógica y reemplazando el controlador de consola por componentes visuales y físicos.

## 3. Refactorizaciones y arreglos realizados

Se conservaron las clases principales del proyecto heredado y se incorporaron nuevos componentes para Unity.

**Scripts de control e integración:**

- `PlayerController.cs`: administra el movimiento mediante WASD, el apuntado hacia el cursor y la comunicación con el modelo lógico del jugador.
- `EnemigoController.cs`: conecta el enemigo visual de Unity con la clase lógica `Zombie`, administra el daño y elimina al enemigo cuando su salud llega a cero.
- `Disparar.cs`: detecta el clic izquierdo y genera proyectiles desde el punto de disparo.
- `Bala.cs`: controla la velocidad física, el daño y el tiempo de vida de los proyectiles.
- `RecuperarSalud.cs`: permite recoger botiquines que restauran 25 puntos de salud.
- `RecuperarMunicion.cs`: permite recoger cajas que agregan 20 unidades de munición.

También se realizaron ajustes para que cada disparo consuma una unidad de munición y para que los objetos recolectables actualicen los datos del jugador.

## 4. Integración de C# con Unity

Se mantuvieron las clases de lógica del proyecto heredado dentro del espacio de nombres `DoomSimple`.

La clase `PlayerController` funciona como puente entre Unity y el modelo lógico `Jugador`. El movimiento utiliza `Rigidbody2D`, con gravedad en cero, y aplica la velocidad física en `FixedUpdate()`, mientras que la lectura de las teclas se realiza en `Update()`.

Se configuró el bloqueo de rotación Z del jugador y se incorporaron colisionadores para las paredes del escenario.

El apuntado se calcula mediante la posición del cursor en el mundo, utilizando la cámara principal. El objeto `PuntoDisparo` determina la orientación de los proyectiles.

Las balas utilizan `Rigidbody2D` y colisionadores configurados como sensores. Al impactar contra un enemigo, se invoca el método de recepción de daño de su modelo lógico.

Los botiquines y las cajas de munición utilizan `Collider2D` con `Is Trigger`, permitiendo actualizar la salud y la munición del jugador al recogerlos.

## 5. Guía de prueba de la escena

**Escena:** `DOOM_Grupo08.unity`

1. Abrir el proyecto en Unity y cargar la escena `DOOM_Grupo08`.
2. Presionar el botón Play.
3. Utilizar las teclas W, A, S y D para mover al jugador.
4. Comprobar que el jugador no atraviesa las paredes del escenario.
5. Mover el cursor para comprobar que el punto de disparo cambia de orientación.
6. Presionar el botón izquierdo del ratón para disparar.
7. Verificar que cada disparo consume una unidad de munición.
8. Comprobar que las balas pueden dañar al enemigo y que este desaparece cuando su salud llega a cero.
9. Recoger un botiquín y comprobar que restaura 25 puntos de salud, sin superar el máximo de 100.
10. Recoger una caja de munición y comprobar que agrega 20 unidades.

### Resultado de las pruebas

Se verificó el funcionamiento del movimiento, las colisiones, el apuntado, los disparos, el daño a enemigos y los objetos recolectables.

El prototipo permite demostrar la integración entre la lógica C# heredada y los componentes físicos y visuales de Unity 2D.
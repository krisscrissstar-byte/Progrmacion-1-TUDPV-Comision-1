# Reporte Técnico - Fase 2


Grupo 1
Proyecto heredado: Grupo 07 - Dark Souls

## 1. Integrantes

Joaquin Britos 
Sofia Carrizo
Luciano Rossini

## 2. Diagnóstico del proyecto heredado

El código estaba ordenado y la herencia entre `GuerreroHueco`, `CaballeroNegro` y `AsesinoSombra` estaba bien armada. Compilaba, pero tenía varios problemas para pasarlo a Unity:

* Las propiedades de `Salud` y `Stamina` validaban valores negativos, pero el resto del código usaba los campos directamente, así que la validación casi no se usaba.
* No había ningún método para recibir daño.
* La hoguera recibía la salud y stamina máximas por parámetro en vez de que las tenga cada personaje.
* El modelo imprimía por consola y `Atacar()`/`Esquivar()` no devolvían si la acción funcionó.
* Faltaban `using System;`, el archivo `Hogera.cs` tenía un typo, `AsesinoSombra.cs` tenía mal el encoding y el `Reporte.md` tenía una `g` al principio.

## 3. Refactorizaciones y arreglos

* Salud y stamina ahora solo se modifican por sus propiedades, limitadas entre 0 y el máximo.
* Agregamos `RecibirDanio()`, `EstaVivo` e `Invulnerable` (para el rodaje).
* Agregamos `ConsumirStamina()` para no repetir el chequeo en cada clase. Las subclases solo definen `CostoEsquivar`.
* `Atacar()` y `Esquivar()` devuelven `bool`.
* `Hoguera.Descansar()` usa `Restablecer()` con los máximos del propio personaje.
* Sacamos los `Console.WriteLine` del modelo; ahora solo imprime `Program.cs`.
* Corregimos el nombre de `Hoguera.cs`, el encoding, los `using` y el encabezado de este reporte.

## 4. Integración C# con Unity

Las clases de lógica siguen siendo C# puro, sin `MonoBehaviour`. Los scripts de Unity solo leen el input, mueven el `Rigidbody2D` y le consultan o actualizan los datos al modelo:

* `JugadorStats`: crea el modelo y lo comparte con los demás scripts.
* `JugadorMovimiento`: input en `Update`, movimiento en `FixedUpdate`, y consulta la stamina antes de correr o saltar.
* `DeteccionSuelo`: detecta el suelo para permitir el salto.
* `JugadorRodaje`: impulso horizontal e invulnerabilidad temporal.
* `HogueraTrigger`: al interactuar, restablece salud y stamina.

## 5. Guía de prueba

1. Abrir el proyecto en Unity y cargar la escena `NOMBRE_ESCENA`.
2. Dar Play.
3. Controles: **A/D** moverse, **Espacio** saltar, **Shift** rodar, **E** interactuar con la hoguera.
4. Qué mirar: las acciones gastan stamina y no se hacen si no alcanza, al rodar no se recibe daño, y la hoguera restablece salud y stamina.

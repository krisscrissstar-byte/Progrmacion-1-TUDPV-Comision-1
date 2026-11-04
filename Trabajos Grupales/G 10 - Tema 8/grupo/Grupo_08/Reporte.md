# Reporte Técnico de Cátedra - Fase 1

**Juego asignado:** Resident Evil  
**Número de grupo:** Grupo 08

## 1. Integrantes del Equipo

- **Jacin Farid** — Legajo 67042 — Líder del grupo. Rama: `dev-FaridJacin-67042`.
- **Ferullo Luca** — Legajo 67221 — Integrante. Rama: `dev-LucaFerullo-67221`.

## 2. Diagnóstico y Arquitectura Inicial

Se desarrolló un sistema de inventario de supervivencia inspirado en Resident Evil mediante programación orientada a objetos en C#.

La arquitectura utiliza una clase base, `ConsumibleSurvival`, dos clases derivadas, `HierbaVerde` y `SprayPrimerosAuxilios`, y una clase gestora, `Superviviente`.

El superviviente administra sus puntos de salud, su estado de envenenamiento y un inventario limitado a cuatro espacios. Cada suministro implementa un comportamiento diferente mediante herencia y polimorfismo.

## 3. Módulos y Clases Implementadas

- **`ConsumibleSurvival`:** clase base con atributo protegido, propiedad con validación, constructor parametrizado y método virtual `Consumir()`.
- **`HierbaVerde`:** recupera 40 puntos de salud y cura el envenenamiento.
- **`SprayPrimerosAuxilios`:** restaura la salud al 100 % y controla su uso único.
- **`Superviviente`:** administra el nombre, la salud, el envenenamiento y un arreglo de inventario de cuatro espacios. Permite agregar, utilizar y mostrar suministros.

En `Main()` se crea un superviviente, se almacenan los suministros en un arreglo polimórfico y se recorren para ejecutar sus métodos correspondientes.

## 4. Control de Errores y Validaciones

Se implementaron las siguientes validaciones:

- La salud no puede ser inferior a 0 ni superior a 100.
- El nombre no acepta valores nulos, vacíos o compuestos solamente por espacios.
- No se pueden agregar objetos cuando el inventario está lleno.
- Se valida el número de espacio seleccionado y se comprueba que contenga un suministro antes de utilizarlo.
- El spray controla su uso mediante un atributo booleano.

El uso de atributos privados y protegidos permite controlar el acceso a los datos y prevenir modificaciones no deseadas.

## 5. Guía de Ejecución en Consola

1. Abrir el proyecto en Visual Studio y ejecutar `Main()`.
2. Comprobar que Leon comienza con 35 puntos de salud y está envenenado.
3. Verificar que el inventario contiene una Hierba Verde y un Spray de Primeros Auxilios.
4. Utilizar la hierba y comprobar que la salud aumenta a 75 y desaparece el envenenamiento.
5. Utilizar el spray y verificar que la salud aumenta a 100.
6. Comprobar que los suministros se consumen y que los espacios correspondientes quedan vacíos.

La prueba del programa se realizó correctamente en Visual Studio, con los resultados esperados y sin errores de ejecución.

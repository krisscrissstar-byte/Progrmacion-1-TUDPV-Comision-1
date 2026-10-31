# Reporte Técnico de Cátedra - Fase 1
**Juego Asignado:** [Pac - Man]  
**Número de Grupo:** Grupo 10  

## 1. Integrantes del Equipo
* Bejar Antonio Sebastian - Legajo 67117 (Lider / Rama: dev-SebastianBejar-67117)


## 2. Diagnóstico y Arquitectura Inicial
* Organizamos el proyecto usando el namespace "Pac_Man_Main", para que las clases se reconozcan entre si sin ningun problema. Luego armamos una estructura usando una clase base para los fantasmas y sus clases hijas correspondientes, usamos una clase aparte para lo que seria el personaje principal y luego creamos el programa principal para poder usar todas las clases creadas anteriormente. Usamos listas dentro del main para poder manejar, agregar o quitar en un futuro mas clases. 

## 3. Módulos y Clases Implementadas (Mínimo 4)
* Clase Base: [Fantasma] (Tiene los datos basicos compartidos como nombre, color y si esta vulnerable, ademas los metodos virtuales son Moverse() y SerDevorado()).
* Clase Derivada 1: [Blinky] (Hereda de Fantasma, usando :base para el constructor y hace un override del metodo virtual Moverse() para su logica propia de persecucion).
* Clase Derivada 2: [Inky] (Hereda de Fantasma, tambien usa :base y hace override del metodo virtual Moverse() para adaptar el comportamiento que tendra).
* Clase Gestora / Inventario: [PacMan] (Maneja las vidas, los puntos y el nombre con las propiedades encapsuladas, sumando los metodos para comer puntos, perder vidas y activar la pildora de poder).

## 4. Control de Errores y Validaciones
* Usamos encapsulamiento con private y propiedades get/set para proteger los atributos. Por ejemplo, en la propiedad de las vidas de Pac-Man, pusimos una pequeña validacion para asegurarnos de que el numero de vidas nunca quede en negativo si le siguen restando despues de perderlas todas..

## 5. Guía de Ejecución en Consola
* 1. Abrir el proyecto: Abrimos la solución Pac-Man-Main.sln desde Visual Studio.   
2. Ir al código principal: Abrimos el archivo Program.cs en el explorador de soluciones.
3. Ver el polimorfismo: En el método Main creamos una List<Fantasma> donde metemos a Blinky y a Inky. Al recorrerla con un foreach y llamar a Moverse(), C# ejecuta automáticamente el método que le corresponde a cada clase hija sin que tengamos que preguntar quién es quién.
4. Ejecutar: Hacemos clic en el botón de Play (o apretamos F5) en Visual Studio para compilar y ver la simulación corriendo en la consola.
**Juego Asignado:** [Nombre del Juego]  
**Número de Grupo:** Grupo XX  

## 1. Integrantes del Equipo
* Apellido y Nombre 1 - Legajo XXXXX (Rol / Rama: dev-Nombre1Apellido1-Legajo)
* Apellido y Nombre 2 - Legajo XXXXX (Rol / Rama: dev-Nombre2Apellido2-Legajo)
* Apellido y Nombre 3 - Legajo XXXXX (Rol / Rama: dev-Nombre3Apellido3-Legajo)

## 2. Diagnóstico y Arquitectura Inicial
* Descripción general del modelado de clases diseñado por el equipo.

## 3. Módulos y Clases Implementadas (Mínimo 4)
* Clase Base: [Nombre] (Atributos protegidos, constructor y métodos virtuales).
* Clase Derivada 1: [Nombre] (Herencia y métodos override).
* Clase Derivada 2: [Nombre] (Herencia y métodos override).
* Clase Gestora / Inventario: [Nombre] (Encapsulamiento y colección de objetos).

## 4. Control de Errores y Validaciones
* Explicación de qué valores inválidos fueron prevenidos mediante encapsulamiento (`private`, `get`/`set`).

## 5. Guía de Ejecución en Consola
* Instrucciones para que el docente ejecute el `Main()` y verifique el polimorfismo.

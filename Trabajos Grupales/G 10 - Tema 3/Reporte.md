<<<<<<< HEAD
# Reporte Técnico de Cátedra - Fase 2
**Juego Asignado:** Pokémon  
**Número de Grupo:** Grupo 10  

## 1. Integrantes del Equipo
* Bejar Antonio Sebastian - Legajo 67117 (Programador y Diseñador / Rama: dev-BejarSebastian)

## 2. Diagnóstico y Arquitectura Inicial
* **Diagnóstico de inicio:** Recibimos el repositorio base completamente vacío, por lo que la arquitectura se concibió desde cero estructurando un modelo orientado a objetos desacoplado. Se separó la lógica de negocio pura en C# (modelo de criaturas y gestión de equipos) del motor gráfico y de físicas de Unity (movimiento cenital, *triggers* de pasto alto y cálculo de probabilidades de encuentro).

## 3. Módulos y Clases Implementadas (Mínimo 4)
* **Clase Base:** `Pokemon` (Clase abstracta con atributos protegidos de apodo, salud y nivel, constructor parametrizado con uso de `this`, y método virtual `Atacar()`).
* **Clase Derivada 1:** `PokemonFuego` (Hereda de `Pokemon` y sobrescribe mediante `override` el método `Atacar()` ejecutando un cálculo de daño de tipo fuego).
* **Clase Derivada 2:** `PokemonAgua` (Hereda de `Pokemon` y sobrescribe mediante `override` el método `Atacar()` ejecutando un cálculo de daño de tipo agua).
* **Clase Gestora / Inventario:** `Entrenador` (Administra el nombre del entrenador y un arreglo polimórfico de hasta 3 criaturas con métodos de captura y ataque en conjunto). Adicionalmente se incluye `SistemaCombatePuro` para la lógica matemática de encuentros y `PlayerController` como puente en Unity (`MonoBehaviour`).

## 4. Control de Errores y Validaciones
* **Encapsulamiento y validación estricta:** Se protegió el acceso directo a los campos críticos utilizando modificadores `private` y `protected`. Específicamente, en la clase base `Pokemon`, la propiedad `Salud` implementa bloques `get` y `set` con validación lógica de rangos, asegurando que los valores de vida se mantengan siempre acotados de forma estricta entre 0 y 100, previniendo estados incoherentes en las criaturas.

## 5. Guía de Ejecución en Consola / Motor Gráfico
* **Instrucciones de verificación:** 
  1. Abrir el proyecto en Unity y cargar la escena principal configurada con el entorno 2D cenital.
  2. Presionar el botón de **Play** en el editor de Unity.
  3. Utilizar las teclas **WASD** o las **Flechas de Dirección** para mover al personaje mediante físicas controladas (`Rigidbody2D.velocity` en `FixedUpdate`).
  4. Desplazarse hacia la zona de pasto alto configurada con un `BoxCollider2D` en modo *Trigger*.
  5. Verificar en la **Consola** los mensajes de entrada/salida de la zona y el registro generado por la lógica pura de C# al evaluar la probabilidad matemática de aparición de un Pokémon salvaje.
=======
# Reporte Técnico de Cátedra - Fase 1
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
>>>>>>> b522946e173735387b48d7ff8fe679d3ecd03afb

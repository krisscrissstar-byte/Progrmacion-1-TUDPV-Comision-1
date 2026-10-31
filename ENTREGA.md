# Reporte Técnico - Fase 1: Arquitectura de Software POO I y POO II
**Tema 6: Minecraft (Mojang)**

## a) Lista de Integrantes
* **Nombre y Apellido:** Valdez del Pino Tomas - **Legajo:** 67145
* **Nombre y Apellido:** Nahuel Osores - **Legajo:** 67110
* **Nombre y Apellido:** Facundo Gomez - **Legajo:** 67160

## b) Diagnóstico de Inicio
La arquitectura del software fue diseñada bajo los pilares de la Programación Orientada a Objetos (POO I y POO II). Se estableció una clase base abstracta (`Herramienta`) que centraliza los atributos comunes de durabilidad y material, permitiendo la especialización a través de clases derivadas polimórficas (`PicoHierro` y `PicoDiamante`). Por su parte, la clase `Bloque` modela de forma independiente las propiedades físicas del entorno (tipo y dureza), gestionando de manera encapsulada su estado de desgaste y destrucción.

## c) Registro de Cambios y Módulos Implementados
1. **Clase `Bloque`:** Incorporación de propiedades automáticas y con validación (`Tipo`, `Dureza`), la propiedad computada `EstaRoto` y el método `Romper(int cantidad)` para decrementar la dureza de manera controlada.
2. **Clase Abstracta `Herramienta`:** Definición del atributo protegido `material`, la propiedad encapsulada `Durabilidad` con validación para prevenir valores negativos mediante la palabra clave `value`, y el método abstracto `PicarBloque(Bloque b)`.
3. **Clase `PicoDiamante`:** Sobrescribe el método `PicarBloque()` implementando una tasa de desgaste personalizada (disminuye 1 punto de durabilidad cada 3 golpes) y la capacidad de interactuar con bloques de alta resistencia como la obsidiana.
4. **Clase `PicoHierro`:** Sobrescribe `PicarBloque()` aplicando un desgaste lineal por golpe, simulación de velocidad de extracción y restricciones de negocio (el pico de hierro no puede dañar bloques de obsidiana).
5. **Clase `Program` (Main):** Implementación de un menú interactivo en consola que gestiona colecciones polimórficas de herramientas (`Herramienta[]`) y listas de bloques mediante bucles de control.

## d) Solución de Problemas y Bugs Prevenidos Mediante Encapsulamiento
* **Protección de Datos Críticos:** Uso riguroso de modificadores `private` en los campos internos de durabilidad y dureza, exponiéndolos únicamente a través de propiedades con validaciones lógicas para evitar estados inconsistentes (como durabilidades o durezas negativas).
* **Validación de Reglas de Compatibilidad:** Se previno que herramientas no aptas (como el pico de hierro) alteren o dañen bloques avanzados (obsidiana), delegando la validación en la lógica de sobreescritura de los métodos polimórficos.

## e) Guía de Prueba de la Consola
1. Ejecutar la aplicación en Visual Studio dentro del espacio de nombres correspondiente.
2. Seleccionar la opción `1` del menú principal para interactuar con las herramientas.
3. Elegir el índice de la herramienta deseada (`0` para Pico de Hierro, `1` para Pico de Diamante).
4. Seleccionar el bloque a minar de la lista mostrada en pantalla (Piedra, Diamante u Obsidiana).
5. Observar las respuestas polimórficas en la consola, el control de desgaste de las herramientas y la reducción progresiva de la dureza del bloque hasta su destrucción.
6. Utilizar la opción `2` del menú principal en cualquier momento para auditar el estado actual y la dureza remanente de todos los bloques del entorno.

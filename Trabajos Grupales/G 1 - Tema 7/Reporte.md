g# Reporte Técnico de Cátedra - Fase 1
**Juego Asignado:** DarkSouls  
**Número de Grupo:** Grupo 07  

## 1. Integrantes del Equipo
* Andújar Tomás Mateo - Legajo 67146 Líder / Rama: dev-TomasAndujar-67146
* Martinez Maira - Legajo 67144 Integrante / Rama: DEV-MartinezMaira-67144
* Enrico Duran - Legajo 67120 Integrante / Rama: dev-EnricoDuran-67120
* Silva Teseira Ricardo - Legajo 67067 Integrante / Rama: Dev-SilvaTeseiraRicardo-67067
* Bezdjian Bumbacher Matias - Legajo 67068 Integrante / Rama: dev-MatiasBezdjianBumbacher-67068

## 2. Diagnóstico y Arquitectura Inicial
* Se creó la arquitectura basada en el sistema de combate de Dark Souls. 
* Se definió una clase base abstracta `GuerreroHueco` para abstraer los componentes comunes de las entidades que combaten (salud y consumo de stamina).
* A partir de allí, se derivaron tipos de luchadores especializados en agilidad o defensa mediante herencia y polimorfismo.

## 3. Módulos y Clases Implementadas (Mínimo 4)
1. **`GuerreroHueco.cs`**: Implementa la estructura base con atributos protegidos, encapsulamiento y método abstracto de esquiva.
2. **`CaballeroNegro.cs`**: Subclase orientada a tanques con alto costo de esquiva (40 stamina).
3. **`AsesinoSombra.cs`**: Subclase orientada a agilidad con bajo costo de esquiva (15 stamina).
4. **`Hoguera.cs`**: Modulo gestor que restablece el estado de las entidades.
5. **`Program.cs`**: Punto de entrada con recorrido polimórfico sobre un array de guerreros.

## 4. Control de Errores y Validaciones
**Encapsulamiento de Atributos:** Se utilizaron modificadores `protected` y propiedades C# con validación para evitar que la salud o la stamina adquieran valores negativos en cálculos de daño o desgaste.
**Control de Stamina:** Se validó que ningún personaje ejecute ataques ni esquivas si la stamina es menor al costo de la acción.

## 5. Guía de Ejecución en Consola
1. Abrir la carpeta `G 7 - Tema 7` (o hacer doble clic en el archivo `.csproj`) en **Visual Studio**.
2. Ejecutar el proyecto presionando `F5` o el botón **Iniciar**.
3. Observar la consola: se creará un array polimórfico con un `CaballeroNegro` y un `AsesinoSombra`, ejecutando cada uno sus versiones especializadas de `Esquivar()` y `Atacar()`.
4. Verificar la ejecución del restablecimiento de estado al interactuar con la `Hoguera`.
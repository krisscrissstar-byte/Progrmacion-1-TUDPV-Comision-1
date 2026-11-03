# Reporte Técnico de Cátedra - Fase 1

**Juego Asignado:** Variación Supervivencia - Horda\
**Número de Grupo:** Grupo 11

## 1. Integrantes del Equipo

-   **Marcelo Ezequiel Cerri** - Legajo 67035 (Desarrollo de las clases
    `Superviviente`, `SupervivienteControlador` y `movimientoPlayer`.
    Rama: `dev-MarceloEzequielCerri-67035-grupo11-semana2`).
-   **Brito Barón Jerónimo Ernesto** - Legajo 67121 (Desarrollo de las
    clases `ConsumibleSurvival`, `HierbaVerde` y
    `SprayPrimerosAuxilios`. Participó en el desarrollo del código,
    aunque no cuenta con una rama propia debido a inconvenientes
    técnicos con GitHub).
-   **Ana Sofía González** - Legajo 4948 (Desarrollo de la clase
    `zombi`. Rama informada: `dev-AnaSofíaGonzález-67128`).
-   **José Tomás Carbonel** - Legajo 67086 (Desarrollo de la clase
    `AbrirCofre`. Rama: `dev-JoseTomasCarbonel-67086-grupo11-semana2`).

## 2. Diagnóstico y Arquitectura Inicial

El proyecto consiste en un juego de supervivencia desarrollado en Unity.
El jugador cuenta con un sistema de salud e inventario de objetos
consumibles, puede desplazarse por el escenario, recibir daño y obtener
recompensas mediante la interacción con cofres.

La arquitectura se organiza en clases con responsabilidades
diferenciadas. La clase `Superviviente` administra los datos del
personaje, su salud, el estado de envenenamiento y el inventario.
`SupervivienteControlador` conecta esa lógica con Unity y con los
elementos de la interfaz gráfica.

El movimiento se implementa en `movimientoPlayer`, que utiliza
`Rigidbody2D` y el sistema de entrada de Unity. El sistema de
consumibles parte de la clase base `ConsumibleSurvival`, de la que
heredan `HierbaVerde` y `SprayPrimerosAuxilios`, cada una con un efecto
específico.

La clase `zombi` detecta el contacto con el jugador y le aplica daño.
Por su parte, `AbrirCofre` administra la interacción con los cofres y
solicita la generación de recompensas aleatorias.

## 3. Módulos y Clases Implementadas (Mínimo 4)

-   **Clase Base: `ConsumibleSurvival`** (Desarrollada por Brito Barón
    Jerónimo Ernesto). Contiene el atributo protegido `nombre`, la
    propiedad `Nombre`, un constructor y el método virtual
    `Consumir(Superviviente s)`. Este método define el comportamiento
    general de un objeto consumible y puede ser sobrescrito por las
    clases derivadas.

-   **Clase Derivada 1: `HierbaVerde`** (Desarrollada por Brito Barón
    Jerónimo Ernesto). Hereda de `ConsumibleSurvival` y sobrescribe el
    método `Consumir()` mediante `override`. Al utilizarse, recupera 40
    puntos de salud y elimina el estado de envenenamiento del
    superviviente.

-   **Clase Derivada 2: `SprayPrimerosAuxilios`** (Desarrollada por
    Brito Barón Jerónimo Ernesto). Hereda de `ConsumibleSurvival` y
    sobrescribe el método `Consumir()`. Posee el atributo privado
    `usado`, que registra si el spray fue utilizado. Cuando todavía no
    fue usado, restaura la salud del personaje al 100% y cambia el
    estado de `usado` a `true`.

-   **Clase Gestora / Inventario: `Superviviente`** (Desarrollada por
    Marcelo Ezequiel Cerri). Administra el nombre, la salud, el estado
    de envenenamiento y un arreglo de objetos `ConsumibleSurvival` con
    capacidad para cuatro elementos. Implementa métodos para recuperar
    salud, recibir daño, curar el envenenamiento, agregar, contar,
    mostrar y consumir objetos. También utiliza métodos genéricos para
    operar con distintos tipos de consumibles.

-   **Clase Controladora: `SupervivienteControlador`** (Desarrollada por
    Marcelo Ezequiel Cerri). Conecta la lógica del superviviente con la
    interfaz de Unity. Administra la barra de vida, los contadores del
    inventario y las entradas del teclado para recibir daño y utilizar
    consumibles. También permite generar una recompensa aleatoria entre
    una hierba verde y un spray.

-   **Clase de Movimiento: `movimientoPlayer`** (Desarrollada por
    Marcelo Ezequiel Cerri). Controla el desplazamiento del personaje
    mediante las teclas WASD o las flechas del teclado. Utiliza
    `Rigidbody2D` para aplicar el movimiento y normaliza el vector de
    dirección para evitar una velocidad mayor al desplazarse en
    diagonal.

-   **Clase Enemigo: `zombi`** (Desarrollada por Ana Sofía González).
    Detecta mediante `OnTriggerEnter2D()` cuándo un objeto entra en su
    área de contacto. Comprueba que tenga la etiqueta `Player`, obtiene
    el componente `SupervivienteControlador` y ejecuta `RecibirDano()`
    para aplicar la cantidad de daño configurada, cuyo valor inicial
    es 10. El script implementado aplica daño por contacto; no contiene
    lógica de movimiento o persecución.

-   **Clase de Interacción: `AbrirCofre`** (Desarrollada por José Tomás
    Carbonel). Detecta cuándo el jugador entra y sale del área del
    cofre. Permite intentar abrirlo mediante la tecla `E` y solicita una
    recompensa aleatoria al controlador del superviviente. El cofre
    cambia su estado a abierto solamente cuando la recompensa se agrega
    correctamente al inventario.

## 4. Control de Errores y Validaciones

El proyecto utiliza atributos privados, propiedades y comprobaciones
condicionales para controlar el acceso a los datos y evitar operaciones
inválidas.

En la clase `Superviviente`:

-   La propiedad `Nombre` impide asignar valores nulos, vacíos o
    compuestos únicamente por espacios.
-   La propiedad `Salud` limita los puntos de vida al rango de 0 a 100.
-   `RecuperarSalud()` y `RecibirDano()` solamente procesan cantidades
    positivas.
-   `AgregarItem()` comprueba que el objeto no sea nulo y que exista un
    espacio disponible en el inventario.
-   `UsarItem(int slot)` verifica que la posición esté dentro del rango
    del inventario y que el espacio no esté vacío.

En la clase `ConsumibleSurvival`, la propiedad `Nombre` valida que el
nombre del objeto no sea nulo, vacío ni compuesto únicamente por
espacios.

En `SupervivienteControlador`, se comprueba que la referencia al
personaje exista antes de operar con él. También se verifica que los
componentes de interfaz no sean nulos antes de actualizarlos y que el
teclado esté disponible antes de leer entradas.

En `movimientoPlayer`, se comprueba que `Keyboard.current` no sea nulo
antes de consultar las teclas.

En `zombi`, se verifica que el objeto detectado tenga la etiqueta
`Player` y que se encuentre el componente `SupervivienteControlador`.

En `AbrirCofre`, se comprueba que el cofre no esté abierto, que exista
un superviviente dentro del rango y que el sistema de teclado esté
disponible. Además, el cofre solamente se marca como abierto si se pudo
agregar la recompensa al inventario.

## 5. Guía de Ejecución en Consola

El proyecto está desarrollado en Unity y los scripts compartidos no
implementan un método `Main()` propio. Por lo tanto, la ejecución se
realiza desde el editor de Unity, iniciando la escena correspondiente
con el botón **Play**. La consola de Unity permite observar los mensajes
generados durante las pruebas.

Para verificar el funcionamiento:

1.  Abrir el proyecto en Unity y ejecutar la escena principal mediante
    el botón **Play**.
2.  Utilizar las teclas `W`, `A`, `S`, `D` o las flechas para comprobar
    el movimiento del personaje.
3.  Presionar `H` para probar la recepción de 10 puntos de daño y
    observar la actualización de la barra de vida.
4.  Presionar `F` para utilizar una Hierba Verde y comprobar la
    recuperación de 40 puntos de salud y la eliminación del
    envenenamiento.
5.  Presionar `G` para utilizar un Spray de Primeros Auxilios y
    comprobar la restauración de la salud al 100%.
6.  Acercarse a un cofre y presionar `E` para intentar obtener una
    recompensa aleatoria. El objeto se agrega al inventario si existe
    espacio disponible.
7.  Entrar en contacto con el zombi para comprobar que el personaje
    recibe el daño configurado.

Para comprobar el polimorfismo, se puede observar que `HierbaVerde` y
`SprayPrimerosAuxilios` se almacenan en el inventario mediante
referencias del tipo base `ConsumibleSurvival`. Al invocar `Consumir()`
sobre esos objetos, se ejecuta la implementación sobrescrita
correspondiente a cada clase derivada.

La consola de Unity muestra los mensajes generados durante estas
pruebas, incluyendo el daño recibido, los objetos obtenidos y los
efectos de los consumibles.

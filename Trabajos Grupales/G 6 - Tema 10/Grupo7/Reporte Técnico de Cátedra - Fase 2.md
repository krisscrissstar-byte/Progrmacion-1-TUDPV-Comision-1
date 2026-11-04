# **Reporte Técnico \- Fase 2**

**Juego Asignado:** Pac \- Man

**Número de Grupo:** Grupo \[7\]

## **1\. Integrantes del Equipo**

* **\[Andújar Tomás Mateo\]** \- Legajo \[67146\] (Líder/Rama: \[dev-TomasAndujar-67146\])  
* **\[Bezdjian Bumbacher Matias\]** \- Legajo \[67068 \] (Rama: \[dev-MatiasBezdjianBumbacher-67068 \])  
* **\[Enrico Durán Nadia\]** \- Legajo \[67120\] (Rama: \[dev-EnricoDurán-67120 \])  
* **\[Martinez Maira\]** \- Legajo \[67144\] (Rama: \[DEV-MartinezMaira-67144\])  
* **\[Silva Teseira Ricardo\]** \- Legajo \[67067\] (Rama: \[Dev-SilvaTeseira-67067\])

## **2\. Diagnóstico y Arquitectura del Proyecto**

El desarrollo parte de la base técnica dejada por el programador anterior, quien estableció la estructura lógica del dominio dentro del namespace Pac\_Man\_Main. Dicha arquitectura base comprende la clase Fantasma, sus clases derivadas (Blinky e Inky) y la clase PacMan.

**Aportes e Integración del Grupo Actual:**

A partir del modelo de C\# preexistente, nuestro equipo se encargó de llevar a cabo la integración del sistema con el motor gráfico **Unity**. Para ello, implementamos los scripts controladores PacManController.cs y FantasmaController.cs. Estos módulos actúan como nexo entre el motor físico de Unity (manejo de Rigidbody2D, detección de colisiones mediante *Triggers* y cálculo de trayectorias mediante *Raycast*) y la lógica orientada a objetos entregada en la primera etapa.

## **3\. Módulos y Clases del Sistema**

### **Módulos Lógicos Herdados (Fase Previa)**

* **Clase Base —** Fantasma **(**Fantasma.cs**):**  
  *Implementada por el programador anterior.* Contiene los atributos protegidos del enemigo (nombre, color, estadoVulnerable) y los métodos virtuales Moverse() y SerDevorado().  
* **Clase Derivada 1 —** Blinky **(**Blinky.cs**):**  
  *Implementada por el programador anterior.* Hereda de Fantasma (:base), gestiona la velocidad del fantasma y hace un override del método Moverse() para su persecución.  
* **Clase Derivada 2 —** Inky **(**Inky.cs**):**  
  *Implementada por el programador anterior.* Hereda de Fantasma (:base) y sobrescribe el método Moverse() para su lógica de emboscada.  
* **Clase Jugador —** PacMan **(**PacMan.cs**):**  
  *Implementada por el programador anterior.* Administra el nombre, las vidas y la puntuación con sus propiedades encapsuladas, además de los métodos ComerPunto(), PerderVida() y ComerPildoraPoder().


### **Módulos e Integración de Unity (Implementados por el Grupo)**

* **Controlador del Jugador —** PacManController **(**PacManController.cs**):**  
  *Desarrollado e integrado por nuestro grupo.* Conecta la escena de Unity con la instancia lógica de PacMan. Captura las entradas del usuario (WASD / Flechas), evalúa la presencia de paredes mediante Physics2D.Raycast, ejecuta el desplazamiento físico en FixedUpdate usando Rigidbody2D y gestiona las interacciones con puntos y fantasmas mediante colisionadores (OnTriggerEnter2D).  
* **Controlador de Enemigos —** FantasmaController **(**FantasmaController.cs**):**  
  *Desarrollado e integrado por nuestro grupo.* Vincula la física e IA en Unity con los objetos lógicos Blinky e Inky. Instancia dinámicamente la clase C\# correspondiente al tipo de fantasma, gestiona los giros automáticos ante paredes con Raycast, controla el movimiento mediante Rigidbody2D e invoca la resolución de encuentros mediante SerDevorado() al colisionar con el jugador.


## **4\. Control de Errores y Validaciones**

* **Validaciones Lógicas Preexistentes:**  
  La clase PacMan heredada ya contemplaba encapsulamiento privado/protegido con propiedades get/set y la validación en Vidas para impedir valores negativos.

* **Validaciones Físicas e Integración Agregadas por el Grupo:**  
  * **Prevención de Traspaso de Muros:** En PacManController y FantasmaController se incorporó la detección por rayo (Raycast) proyectada hacia la capa wallLayer antes de realizar giros o movimientos, garantizando que los personajes no atraviesen o queden atrapados en los muros del laberinto.  
  * **Gestión de Estado y Fin de Juego:** En PacManController se implementó la verificación de vidas restantes en el evento de colisión (modeloLogico.Vidas \<= 0). Al perder todas las vidas, se frena el componente físico de Rigidbody2D, se deshabilita el script para evitar respuestas a comandos y se invoca el reinicio de la escena mediante Invoke("ReiniciarEscena", 2f).  
    

## 

## **5\. Guía de Ejecución en Unity**

1. **Apertura de la Escena:**   
   Abrir el proyecto en **Unity** y verificar la presencia de las clases en el namespace Pac\_Man\_Main y los scripts de control.  
     
2. **Configuración del Personaje Principal:**

   * Asignar el script PacManController al GameObject de Pac-Man.  
   * Asegurar que el objeto tenga un Rigidbody2D y un Collider2D marcado como *Is Trigger*.  
   * Asignar en el Inspector la capa correspondiente a las paredes (wallLayer).  
       
3. **Configuración de Enemigos:**  
   * Asignar el script FantasmaController a los GameObjects de los fantasmas.  
   * Seleccionar el tipo de fantasma ("Blinky" o "Inky") en el campo tipoFantasma del Inspector y definir la capa wallLayer.  
       
4. **Etiquetado de Colisionadores (Tags):**  
   * Asignar la etiqueta "Player" a Pac-Man, "Punto" a los coleccionables y "Fantasma" a los enemigos.  
       
5. **Ejecución y Pruebas:**  
   Presionar **Play** (o la combinación correspondiente en el editor) para iniciar la simulación. Verificar el movimiento de Pac-Man mediante teclado, la toma de decisiones automática de los fantasmas al llegar a una pared y el registro de eventos lógicos en la consola al comer puntos o colisionar con enemigos.


METODOLOGÍA ROTATIVA ITERATIVA: DESARROLLO DE VIDEOJUEGOS C# 
Programación de Videojuegos I — UTN FRT | Cátedra: Profesor Matías Chocobar
Fase 1: Arquitectura de software unity(10 Proyectos de Videojuegos Reales)
⚠️ [ENTREGA OBLIGATORIA GITHUB]
FECHA LÍMITE DE ENTREGA: VIERNES 30 DE OCTUBRE DE 2026 HASTA LAS 23:50 HS.
No se recibirán entregas por correo electrónico ni ningún otro medio que no sea Pull Request en GitHub.
Estructura obligatoria de carpetas: Todo el código y reporte debe estar contenido dentro de la carpeta: 'grupo/' (Ejemplo: grupo/Grupo_01/).

1. METODOLOGÍA ROTATIVA Y FLUJO COLABORATIVO GITHUB (LÍDER Y EQUIPO)
La cátedra implementa la metodología de rotación de código profesional (Code Handover & Code Review):
• Cada uno de los 10 grupos recibe asignado un videojuego específico por el docente (los alumnos no eligen tema).
• En la Semana 2 (actual), cada grupo programa la arquitectura unity.
• En las semanas siguientes, el docente ROTARÁ los repositorios entre grupos: cada equipo recibirá el proyecto de otro grupo, deberá auditar el código recibido, solucionar bugs, completar funciones faltantes e integrarle la nueva unidad (físicas 2D en Unity).

FLUJO TÉCNICO DE GITHUB PASO A PASO:
1. Acción del Líder del Grupo:
   - Ingresa al repositorio oficial del Profesor Matías Chocobar: https://github.com/ChocobarMatias/Progrmacion-1-TUDPV-Comision-1
   - Realiza un FORK a su cuenta personal de GitHub (ejemplo: https://github.com/LiderGrupo/Progrmacion-1-TUDPV-Comision-1).
   - En Settings de su Fork, añade a sus compañeros de equipo como Colaboradores (Collaborators).

2. Acción de los Integrantes del Grupo:
   - NO clonan al docente: Clonan el FORK del Líder a sus computadoras locales mediante GitHub Desktop.
   - Cada integrante crea obligatoriamente una rama con su nombre y legajo: branch 'dev-NombreApellido-Legajo'.
   - Desarrolla su aporte en Visual Studio dentro de la carpeta 'grupo/Grupo_XX/'.
   - Realiza Commit y Push de su rama hacia el repositorio del Líder.

3. Integración Final y Pull Request al Docente:
   - El Líder revisa los aportes de sus compañeros y realiza el MERGE de las ramas a la rama 'main' de su Fork.
   - Finalmente, el Líder abre un PULL REQUEST (PR) desde su Fork hacia el repositorio del Profesor Matías Chocobar.
   - Título obligatorio del PR: [ENTREGA FASE 1] Grupo XX - Tema: NombreDelJuego.

Siga detalladamente cada uno de los pasos descritos a continuación para la correcta resolución y entrega del Trabajo Práctico:

### Paso 1: Crear el Fork
1. Ingrese a su cuenta de GitHub y acceda al [repositorio oficial de la cátedra](https://github.com/ChocobarMatias/Progrmacion-1-TUDPV-Comision-1).
2. En el margen superior derecho, haga clic en el botón **Fork** y seleccione **Create a new fork**.
3. Esto generará una copia íntegra del proyecto en su cuenta personal bajo la estructura:  
   `https://github.com/<tu_usuario>/Progrmacion-1-TUDPV-Comision-1`

### Paso 2: Clonar el Fork con GitHub Desktop
1. Abra la aplicación **GitHub Desktop**.
2. Diríjase a **File > Clone Repository...** (o presione `Ctrl + Shift + O`).
3. En la pestaña **GitHub.com**, seleccione **su propio Fork** (verifique que el autor sea su usuario y no el del profesor).
4. Indique la ruta local en su disco donde trabajará y presione **Clone**.

### Paso 3: Crear y publicar la rama de desarrollo
1. En GitHub Desktop, haga clic en el selector superior **Current branch** y luego en **New branch**.
2. **Nomenclatura obligatoria:** `dev-NombreApellido-Legajo`  
   *Ejemplo:* `dev-JuanPerez-54321`
3. Haga clic en **Create branch** y posteriormente en el botón azul **Publish branch** para sincronizar la rama en su repositorio remoto.  
   > *Equivalente en terminal de Git:*  
   > `git checkout -b dev-NombreApellido-Legajo`

### Paso 4: Resolver el Trabajo Práctico y registrar cambios (Commit)
1. Abra la solución del proyecto en **Visual Studio Community**, resuelva las consignas solicitadas y guarde todos los archivos (`Ctrl + S`).
2. Regrese a GitHub Desktop y verifique los cambios detectados en la pestaña lateral **Changes**.
3. En la esquina inferior izquierda, complete el campo **Summary**:  
   `TP Integrador - Resueltos Ejercicios 1 al 10`
4. Presione el botón **Commit to dev-NombreApellido-Legajo**.  
   > *Equivalente en terminal de Git:*  
   > `git add .`  
   > `git commit -m "TP Integrador - Resueltos Ejercicios 1 al 10"`

### Paso 5: Subir los cambios al repositorio remoto (Push)
1. En GitHub Desktop, presione el botón superior derecho **Push origin** para subir los commits confirmados a su cuenta de GitHub.  
   > *Equivalente en terminal de Git:*  
   > `git push origin dev-NombreApellido-Legajo`

### Paso 6: Crear el Pull Request (PR) hacia el repositorio del Profesor
1. Tras realizar el *push*, presione **Create Pull Request** en GitHub Desktop (o acceda a su fork en la plataforma web de GitHub y seleccione **Contribute > Open pull request**).
2. Verifique la configuración del PR:
   * **base repository:** `ChocobarMatias/Progrmacion-1-TUDPV-Comision-1` (rama `main`)
   * **head repository:** `<tu_usuario>/Progrmacion-1-TUDPV-Comision-1` (rama `dev-NombreApellido-Legajo`)
3. **Título del Pull Request:**  
   `[ENTREGA TP] Nombre y Apellido - Legajo`
4. Haga clic en **Create pull request** para formalizar la entrega.

### Paso 7: Actualizar la rama main y sincronizar el Fork localmente
1. En GitHub Desktop, cambie a la rama principal: **Current branch: main**.
2. Diríjase a **Branch > Merge into current branch...**, elija su rama `dev-NombreApellido-Legajo` y confirme la fusión para mantener su rama `main` actualizada.  
   > *Equivalente en terminal de Git:*  
   > `git checkout main`  
   > `git merge dev-NombreApellido-Legajo`
3. En la interfaz web de su fork, cuando la cátedra incorpore nuevo material, utilice la opción **Sync fork > Update branch** para mantenerse alineado con el repositorio principal.

**Fecha Limite de entrega : Viernes 30/10/2026 a las 23:50 hs se cerrara los PR**

Acción de los Integrantes del Grupo:

NO clonan al docente: Clonan el FORK del Líder a sus computadoras locales mediante GitHub Desktop.
Cada integrante crea obligatoriamente una rama con su nombre y legajo: branch 'dev-NombreApellido-Legajo'.
Desarrolla su aporte en Visual Studio dentro de la carpeta 'grupo/Grupo_XX/'.
Realiza Commit y Push de su rama hacia el repositorio del Líder.
Integración Final y Pull Request al Docente:

El Líder revisa los aportes de sus compañeros y realiza el MERGE de las ramas a la rama 'main' de su Fork.
Finalmente, el Líder abre un PULL REQUEST (PR) desde su Fork hacia el repositorio del Profesor Matías Chocobar.
Título obligatorio del PR: [ENTREGA FASE 1] Grupo XX - Tema: NombreDelJuego.
REPORTE TÉCNICO OBLIGATORIO (reporte.md dentro de la carpeta del grupo): Todo grupo debe incluir un archivo 'reporte.md' con las siguientes secciones: a) Lista de integrantes (Nombre, Apellido y Legajo). b) Diagnóstico de inicio (Cómo se concibió la arquitectura inicial). c) Registro de cambios y módulos implementados. d) Solución de problemas y bugs prevenidos mediante encapsulamiento. e) Guía de prueba de la consola (cómo probar los métodos en Main).




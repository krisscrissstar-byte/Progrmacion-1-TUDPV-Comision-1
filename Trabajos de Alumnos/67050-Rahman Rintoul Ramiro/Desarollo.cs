using System;

class Program
{
    static void Main(string[] args)
    {
        int op;
        do{
        Console.WriteLine("Elija una opcion");
        for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}: Ejercicio {i}");
            }
        Console.WriteLine("0: Salir");
        op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                case 1:
                    Program.Ejercicio1();
                    break;
                case 2:
                    Program.Ejercicio2();
                    break;
                case 3:
                    Program.Ejercicio3();
                    break;
                case 4:
                    Program.Ejercicio4();
                    break;
                case 5:
                    Program.Ejercicio5();
                    break;
                case 6:
                    Program.Ejercicio6();
                    break;
                case 7:
                    Program.Ejercicio7();
                    break;
                case 8:
                    Program.Ejercicio8();
                    break;
                case 9:
                    Program.Ejercicio9();
                    break;
                case 10:
                    Program.Ejercicio10();
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }while(op!=0);
    }

    /*Ejercicio 1: Sistema de Inventario y Durabilidad de Armas
    Combina: Array + for + switch + if/else.
    Consigna: Declarar un array con 4 armas ["Espada", "Hacha", "Arco", "Daga"] y un array paralelo
    entero de durabilidad. Con un bucle for, cargar la durabilidad de cada arma por teclado. Luego,
    con un switch ofrecer:
    1: Inspeccionar armas críticas
    o
    2: Ver arsenal completo.
    Si elige 1, recorrer con for y evaluar con if qué armas tienen durabilidad $\le 20$ mostrando un
    mensaje de alerta.*/
    public static void Ejercicio1(){
        string[] inventario= {"Espada", "Hacha", "Arco", "Daga"};
        int[] durabilidad = new int[4];

        for(int i=0;i<4;i++){
            Console.WriteLine($"Por favor ingrese la durabilidad de su {inventario[i]}");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Elija una opcion:");
        Console.WriteLine("1: Inspeccionar armas críticas.");
        Console.WriteLine("2: Ver arsenal completo.");
        int op = int.Parse(Console.ReadLine());
        switch(op){
            case 1:
            for(int i=0;i<4;i++){
                if(durabilidad[i]<20){
                    Console.WriteLine($"Su {inventario[i]} tiene {durabilidad[i]} de durabilidad!");
                }
            }
            break;
            case 2:
            Console.WriteLine("Inventario:");
            for(int i=0;i<4;i++){
                Console.WriteLine($"{inventario[i]}, Durabilidad:{durabilidad[i]}");
            }
            break;
        }
    }
    /*Ejercicio 2: Marcador Top 5 de Speedrun
    Combina: Array + for + while + if/else.
    Consigna: Cargar con un for los tiempos de 5 corredores en un array de float. Con un bucle
    while, permitir al usuario ingresar diferentes tiempos objetivo para clasificar y evaluar con
    if/else cuántos corredores del vector superaron la prueba logrando un tiempo menor o igual a
    la marca exigida.*/
    public static void Ejercicio2(){
        float[] tiemposCorredores = new float[5];
        Console.WriteLine("--- REGISTRO DE TIEMPOS (SPEEDRUN) ---");
        for (int i=0; i<5; i++){
            Console.Write($"Ingrese el tiempo del corredor #{i + 1} (en segundos): ");
            tiemposCorredores[i] = float.Parse(Console.ReadLine());
        }
        bool continuar = true;
        while (continuar){
            Console.WriteLine("\n--------------------------------------------------");
            Console.Write("Ingrese un tiempo objetivo a evaluar (o un número negativo para salir): ");
            float tiempoObjetivo = float.Parse(Console.ReadLine());
            if (tiempoObjetivo < 0){
                continuar = false;
                Console.WriteLine("Saliendo del evaluador de Speedrun...");
            }else{
                int clasificados = 0;
                for (int i=0; i<5; i++){
                    if (tiemposCorredores[i]<=tiempoObjetivo){
                        clasificados++;
                    }
                }
                if (clasificados > 0){
                    Console.WriteLine($"¡Prueba evaluada! {clasificados} corredor(es) lograron superar la marca de {tiempoObjetivo}s.");
                }else{
                    Console.WriteLine($"Ningún corredor logró igualar o bajar la marca exigida de {tiempoObjetivo}s.");
                }
            }
        }
    }
    /*Ejercicio 3: Combate contra Horda de Slimes
    Combina: Array + while + switch + if/else.
    Consigna: Declarar un array con la salud de 4 slimes:
    int[] slimes = { 30, 40, 50, 60 };. Mediante un bucle while que permanezca activo mientras al
    menos un slime tenga vida > 0, el usuario elige con un switch a cuál atacar (0 al 3). Con if/else
    validar si el slime atacado ya fue derrotado o restarle 20 HP.*/
    public static void Ejercicio3(){
        int[] slimes = {30, 40, 50, 60};
        bool hordaViva = true;
        Console.WriteLine("--- ¡COMIENZA EL COMBATE CONTRA LA HORDA DE SLIMES! ---");
        while (hordaViva){
            Console.WriteLine("\nEstado de la Horda:");
            for (int i=0; i<slimes.Length; i++)
            {
                string estado = slimes[i] > 0 ? $"{slimes[i]} HP" : "DEFEATED";
                Console.WriteLine($"Slime [{i}]: {estado}");
            }
            Console.Write("\n¿A qué slime deseas atacar? Elige un índice (0 al 3): ");
            int objetivo = int.Parse(Console.ReadLine());
            switch (objetivo){
                case 0:
                case 1:
                case 2:
                case 3:
                    if (slimes[objetivo]<=0){
                        Console.WriteLine($"¡El Slime [{objetivo}] ya fue derrotado! Elige otro objetivo.");
                    }else{
                        slimes[objetivo] -= 20;
                        Console.WriteLine($"¡Atacaste al Slime [{objetivo}]! Le restaste 20 HP.");
                        if (slimes[objetivo]<=0)
                        {
                            slimes[objetivo] = 0;
                            Console.WriteLine($"¡El Slime [{objetivo}] ha sido eliminado!");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Índice inválido. Debes elegir un número entre 0 y 3.");
                    break;
            }
            hordaViva = false;
            for (int i=0; i<slimes.Length; i++)
            {
                if (slimes[i]>0){
                    hordaViva = true;
                    break; 
                }
            }
        }
        Console.WriteLine("\n--- ¡Felicidades! Has derrotado a toda la horda de slimes ---");
    }
    /*Ejercicio 4: Canje de Recompensas en Tienda de Cartas
    Combina: Array + switch + for + if/else.
    Consigna: Un mazo de 5 cartas tiene sus costos en gemas en un array: { 10, 25, 50, 80, 120 }.
    Pedir las gemas del usuario y ofrecer con un switch:
    1: Mostrar cartas que puede pagar (filtrando con for e if),
    2: Identificar la carta más cara del catálogo.*/
    public static void Ejercicio4(){
        int[] costosCartas = {10, 25, 50, 80, 120};
        Console.Write("Ingrese la cantidad de gemas que posee: ");
        int gemasUsuario = int.Parse(Console.ReadLine());
        Console.WriteLine("\nElija una opcion:");
        Console.WriteLine("1: Mostrar cartas que puede pagar.");
        Console.WriteLine("2: Identificar la carta mas cara del catalogo.");
        int op = int.Parse(Console.ReadLine());
        switch(op){
            case 1:
                Console.WriteLine("\nCartas que puedes pagar:");
                int sePuedePagar = 0;
                for (int i=0; i<costosCartas.Length; i++){
                    if (gemasUsuario>=costosCartas[i]){
                        Console.WriteLine($"Carta #{i + 1} - Costo: {costosCartas[i]} gemas");
                        sePuedePagar++;
                    }
                }
                if (sePuedePagar==0){
                    Console.WriteLine("No tienes suficientes gemas para ninguna carta.");
                }
                break;

            case 2:
                int masCara = costosCartas[0];
                for (int i=1; i<costosCartas.Length; i++)
                {
                    if (costosCartas[i]>masCara)
                    {
                        masCara = costosCartas[i];
                    }
                }
                Console.WriteLine($"\nLa carta mas cara del catalogo cuesta: {masCara} gemas.");
                break;

            default:
                Console.WriteLine("Opcion invalida.");
                break;
        }
    }
    /*Ejercicio 5: Registro y Filtrado de Daño por Ráfaga
    Consigna: Cargar con un bucle for el daño de 6 flechas en un array de enteros. Luego, con un
    bucle while pedir un daño de referencia y filtrar con if/else los impactos que superaron ese
    número, acumulando y mostrando el total de daño filtrado.*/
    public static void Ejercicio5(){
        int[] flechas = new int[6];
        for(int i=0; i<6; i++){
            Console.WriteLine($"Por favor ingrese el daño de la flecha {i + 1}");
            flechas[i] = int.Parse(Console.ReadLine());
        }
        bool continuar = true;
        while(continuar){
            Console.WriteLine("Ingrese un daño de referencia para filtrar (o un numero negativo para salir):");
            int refDano = int.Parse(Console.ReadLine());
            if(refDano<0){
                continuar = false;
            }else{
                int acumulador = 0;
                Console.WriteLine("Impactos que superaron la referencia:");
                for(int i=0; i<6; i++){
                    if(flechas[i] > refDano){
                        Console.WriteLine($"Flecha {i + 1}: {flechas[i]} de daño");
                        acumulador += flechas[i];
                    }
                }
                if(acumulador > 0){
                    Console.WriteLine($"El total de daño filtrado es: {acumulador}");
                }else{
                    Console.WriteLine("Ningun impacto supero el daño de referencia.");
                }
            }
        }
    }
    /*Ejercicio 6: Selector de Elementos y Cargas Mágicas
    onsigna: Declarar un array con 4 tipos de gemas ["Fuego", "Hielo", "Rayo", "Veneno"] y solicitar
    las cargas de cada una en un vector paralelo. Con un switch permitir:
    1: Recargar todas (+5 cargas con bucle for) o
    2: Buscar si hay alguna gema agotada (0 cargas con if).*/
    public static void Ejercicio6(){
        string[] gemas = {"Fuego", "Hielo", "Rayo", "Veneno"};
        int[] cargas = new int[4];

        for(int i=0; i<4; i++){
            Console.WriteLine($"Por favor ingrese las cargas de la gema {gemas[i]}:");
            cargas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nElija una opcion:");
        Console.WriteLine("1: Recargar todas las gemas (+5 cargas).");
        Console.WriteLine("2: Buscar si hay alguna gema agotada.");
        int op = int.Parse(Console.ReadLine());

        switch(op){
            case 1:
                for(int i=0; i<4; i++){
                    cargas[i] += 5;
                    Console.WriteLine($"Gema {gemas[i]} recargada. Total: {cargas[i]} cargas");
                }
                break;
            case 2:
                int agotadas = 0;
                for(int i=0; i<4; i++){
                    if(cargas[i] == 0){
                        Console.WriteLine($"¡Alerta! La gema de {gemas[i]} esta agotada (0 cargas).");
                        agotadas++;
                    }
                }
                if(agotadas==0){
                    Console.WriteLine("Todas tus gemas tienen energia suficiente.");
                }
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                break;
        }
    }
    /*Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra
    Consigna: Un pasillo posee 6 baldosas representadas en un vector booleano bool[] trampas = {
    false, true, false, false, true, false };. El jugador avanza casilleros mediante un bucle while mientras
    no pise trampa y no llegue a la meta (baldosa 5). Con if/else validar si activa la trampa y pierde
    o si completa el recorrido.*/
    public static void Ejercicio7(){
        bool[] trampas = {false, true, false, false, true, false};
        int posicion = 0;
        bool vivo = true;

        Console.WriteLine("--- ¡COMIENZAS A AVANZAR POR EL PASILLO DE LA MAZMORRA! ---");

        while(vivo && posicion<5){
            Console.WriteLine($"\nTe encuentras en la baldosa {posicion}. Presiona Enter para dar el siguiente paso...");
            Console.ReadLine();
            
            posicion++;

            if(trampas[posicion]){
                Console.WriteLine($"¡BOOM! La baldosa {posicion} era una trampa. Has caído en combate.");
                vivo = false;
            }else{
                Console.WriteLine($"Pisaste la baldosa {posicion} de forma segura.");
            }
        }

        if(vivo){
            Console.WriteLine("\n¡Felicidades! Lograste llegar a la baldosa 5 y completaste el recorrido del pasillo.");
        }
    }
    /*Ejercicio 8: Estadísticas de Fases del Boss
    Consigna: Cargar con un for el daño recibido en las 3 fases de un Jefe en un array de enteros.
    Mediante un switch permitir:
    1: Calcular promedio de daño entre las 3 fases,
    2: Identificar la fase más destructiva mediante comparaciones if.*/
    public static void Ejercicio8(){
        int[] fases = new int[3];
        for(int i=0; i<3; i++){
            Console.WriteLine($"Por favor ingrese el daño recibido en la fase {i + 1}:");
            fases[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nElija una opcion:");
        Console.WriteLine("1: Calcular promedio de daño.");
        Console.WriteLine("2: Identificar la fase mas destructiva.");
        int op = int.Parse(Console.ReadLine());
        switch(op){
            case 1:
                int suma = 0;
                for(int i=0; i<3; i++){
                    suma += fases[i];
                }
                float promedio = (float)suma / 3;
                Console.WriteLine($"El promedio de daño recibido entre las 3 fases es: {promedio}");
                break;
            case 2:
                if(fases[0]>=fases[1] && fases[0]>=fases[2]){
                    Console.WriteLine($"La fase 1 fue la mas destructiva con {fases[0]} de daño.");
                }else if(fases[1]>=fases[0] && fases[1]>=fases[2]){
                    Console.WriteLine($"La fase 2 fue la mas destructiva con {fases[1]} de daño.");
                }else{
                    Console.WriteLine($"La fase 3 fue la mas destructiva con {fases[2]} de daño.");
                }
                break;
            default:
                Console.WriteLine("Opcion invalida.");
                break;
        }
    }
    /*Ejercicio 9: Sistema de Munición y Disparo por Cargador
    Consigna: Un soldado dispone de un array de munición { 30, 15, 8 } correspondiente a Rifle,
    Pistola y Escopeta. Con un bucle while permitir realizar disparos sucesivos eligiendo el arma
    mediante un switch hasta que el usuario ingrese 0. Con if/else validar si el arma tiene balas
    suficientes o se encuentra vacía.*/
    public static void Ejercicio9(){ 
        int[] municion = {30, 15, 8};
        bool combatiendo = true;
        while(combatiendo){
            Console.WriteLine("\nMunicion disponible:");
            Console.WriteLine($"1: Rifle ({municion[0]} balas)");
            Console.WriteLine($"2: Pistola ({municion[1]} balas)");
            Console.WriteLine($"3: Escopeta ({municion[2]} balas)");
            Console.WriteLine("0: Salir del sistema de disparo");
            Console.Write("Seleccione el arma para disparar: ");
            int op = int.Parse(Console.ReadLine());
            switch(op){
                case 0:
                    combatiendo = false;
                    Console.WriteLine("Saliendo del sistema de disparo...");
                    break;
                case 1:
                    if(municion[0] > 0){
                        municion[0]--;
                        Console.WriteLine("¡PUM! Disparaste el Rifle.");
                    }else{
                        Console.WriteLine("El Rifle no tiene balas suficentes. ¡Cargador vacio!");
                    }
                    break;
                case 2:
                    if(municion[1]>0){
                        municion[1]--;
                        Console.WriteLine("¡PANG! Disparaste la Pistola.");
                    }else{
                        Console.WriteLine("La Pistola no tiene balas suficentes. ¡Cargador vacio!");
                    }
                    break;
                case 3:
                    if(municion[2]>0){
                        municion[2]--;
                        Console.WriteLine("¡CHAC-PUM! Disparaste la Escopeta.");
                    }else{
                        Console.WriteLine("La Escopeta no tiene balas suficentes. ¡Cargador vacio!");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }
    /*Ejercicio 10: Asignador y Verificador de Bonificación de EXP
    Consigna: Un clan realiza 5 misiones. Con un bucle for, almacenar los puntos de EXP de cada
    misión en un array de enteros. Si alguna misión superó los 100 puntos, aplicar con if/else un
    bono extra del 20% sobre esa posición. Al final, imprimir la tabla del array actualizada y la
    experiencia total acumulada*/
    public static void Ejercicio10(){
         int[] misiones = new int[5];

        for(int i=0; i<5; i++){
            Console.WriteLine($"Por favor ingrese la EXP obtenida en la mision {i + 1}:");
            misiones[i] = int.Parse(Console.ReadLine());
        }

        float totalExp = 0;
        Console.WriteLine("\n--- TABLA DE EXPERIENCIA ACTUALIZADA ---");

        for(int i=0; i<5; i++){
            if(misiones[i] > 100){
                float bono = misiones[i] * 1.20f;
                Console.WriteLine($"Mision {i + 1}: {bono} EXP (¡Incluye bono del 20%!)");
                totalExp += bono;
            }else{
                Console.WriteLine($"Mision {i + 1}: {misiones[i]} EXP (Sin bonificacion)");
                totalExp += misiones[i];
            }
        }

        Console.WriteLine($"\nLa experiencia total acumulada por el clan es: {totalExp} EXP");
    }
}
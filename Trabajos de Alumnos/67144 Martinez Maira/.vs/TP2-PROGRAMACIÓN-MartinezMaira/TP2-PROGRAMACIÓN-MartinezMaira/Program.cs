
/*
=================================================================================================================================
ALUMNA: MARTINEZ MAIRA
LEGAJO 67144
ACLARACIÓN: Cada ejercicio está comentado para poder ejecutarlos de manera individual. 
Descomentar el ejercicio que se desea ejecutar, gracias :-).
=================================================================================================================================
*/



/*
=================================================================================================================================
Ejercicio 1: Sistema de Inventario y Durabilidad de Armas 

Combina: Array + for + switch + if/else. 
Consigna: Declarar un array con 4 armas ["Espada", "Hacha", "Arco", "Daga"] y un array paralelo 
entero de durabilidad. Con un bucle for, cargar la durabilidad de cada arma por teclado. Luego, 
con un switch ofrecer:  
1: Inspeccionar armas críticas 
o  
2: Ver arsenal completo.  
Si elige 1, recorrer con for y evaluar con if qué armas tienen durabilidad $\le 20$ mostrando un 
mensaje de alerta.
=================================================================================================================================
*/

using System;
class program

/*

{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[armas.Length];

        for (int i = 0; i < armas.Length; i++)
        {
            Console.Write($"La durabilidad de {armas[i]} es de: ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();

        Console.WriteLine("===========Seleccione una opción===========");
        Console.WriteLine("1: Inspeccionar armas críticas");
        Console.WriteLine("2: Ver arsenal completo");
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Armas en estado crítico (durabilidad ≤ 20):");
                for (int i = 0; i < armas.Length; i++)
                {
                    if (durabilidad[i] <= 20)
                    {
                        Console.WriteLine($"- {armas[i]}: Durabilidad: {durabilidad[i]} ¡Durabilidad en estado critico!");
                    }
                }
                break;
            case 2:
                Console.WriteLine("Arsenal completo:");
                for (int i = 0; i < armas.Length; i++)
                {
                    Console.WriteLine($"- {armas[i]}: Durabilidad: {durabilidad[i]}");
                }
                break;
            default:
                Console.WriteLine("Error: Opción no válida.");
                break;
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 2: Marcador Top 5 de Speedrun 

Combina: Array + for + while + if/else.
Consigna: Cargar con un for los tiempos de 5 corredores en un array de float. Con un bucle 
while, permitir al usuario ingresar diferentes tiempos objetivo para clasificar y evaluar con 
if/else cuántos corredores del vector superaron la prueba logrando un tiempo menor o igual a 
la marca exigida. 
=================================================================================================================================
*/

/*

{
    static void Main()
    {
        float[] tiempos = new float[5];
        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write($"Tiempo que superó la prueba el corredor {i + 1} (en segundos): ");
            tiempos[i] = Convert.ToSingle(Console.ReadLine());
        }
        Console.Clear();

        while (true)
        {
            Console.Write(" ¿Cual es el tiempo objetivo para clasificar? o ingrese 'x' para salir: ");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "x")
            {
                break; 
            }
            float tiempoObjetivo = float.Parse(input);
            int corredoresSuperados = 0;
            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= tiempoObjetivo)
                {
                    corredoresSuperados++;
                }
            }
            Console.WriteLine($"Cantidad de corredores que superaron la prueba en {tiempoObjetivo}: {corredoresSuperados}");
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 3: Combate contra Horda de Slimes 
Combina: Array + while + switch + if/else.
Consigna: Declarar un array con la salud de 4 slimes: 
int[] slimes = { 30, 40, 50, 60 };. Mediante un bucle while que permanezca activo mientras al 
menos un slime tenga vida > 0, el usuario elige con un switch a cuál atacar (0 al 3). Con if/else 
validar si el slime atacado ya fue derrotado o restarle 20 HP. 
=================================================================================================================================
*/

/*
{
static void Main()
{
    int[] slimes = { 30, 40, 50, 60 };
    while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
    {
        Console.WriteLine("=========== ¡Elige qué slime atacar! (1-4) ===========");
        for (int i = 0; i < slimes.Length; i++)
        {
            Console.WriteLine($"Slime {i + 1} tiene {slimes[i]} de vida restante.");
        }
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (opcion)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                if (slimes[opcion - 1] <= 0)
                {
                    Console.WriteLine("¡Este slime ya fue derrotado!");
                }
                else
                {
                    slimes[opcion - 1] -= 20;
                    if (slimes[opcion - 1] <= 0)
                    {
                        Console.WriteLine($"¡Has derrotado al Slime {opcion}!");
                    }
                    else
                    {
                        Console.WriteLine($"Has atacado al Slime {opcion}. Salud restante: {slimes[opcion - 1]}");
                    }
                    if (slimes[opcion - 1] < 0)
                    {
                        slimes[opcion - 1] = 0; 
                    }
                }
                break;
            default:
                Console.WriteLine("Error: Opción no válida.");
                break;
        }
    }
    Console.Clear();
    Console.WriteLine("========================================================================================");
    Console.WriteLine("¡Felicidades! Todos los slimes han sido derrotados. Fin del juego. ");
    Console.WriteLine("Presione cualquier tecla para salir");
    Console.WriteLine("========================================================================================");

}
}

*/

/*
=================================================================================================================================
Ejercicio 4: Canje de Recompensas en Tienda de Cartas 
Combina: Array + switch + for + if/else. 
Consigna: Un mazo de 5 cartas tiene sus costos en gemas en un array: { 10, 25, 50, 80, 120 }. 
Pedir las gemas del usuario y ofrecer con un switch:  
1: Mostrar cartas que puede pagar (filtrando con for e if),  
2: Identificar la carta más cara del catálogo. 
=================================================================================================================================
*/

/*
{
    static void Main()
    {
        int[] costosCartas = { 10, 25, 50, 80, 120 };
        Console.Write("Ingrese la cantidad de gemas que posee: ");
        int gemasUsuario = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("=========== Seleccione una opción ===========");
        Console.WriteLine("1: Mostrar las cartas que puedo pagar");
        Console.WriteLine("2: Identificar la carta más cara del catálogo");
        int opcion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (opcion)
        {
            case 1:
                Console.WriteLine("=========== Cartas que puedo comprar ===========");
                for (int i = 0; i < costosCartas.Length; i++)
                {
                    if (costosCartas[i] <= gemasUsuario)
                    {
                        Console.WriteLine($"La carta {i + 1} tiene un costo de {costosCartas[i]} gemas");
                    }
                }
                break;
            case 2:
                int cartaMasCara = costosCartas[0];
                for (int i = 1; i < costosCartas.Length; i++)
                {
                    if (costosCartas[i] > cartaMasCara)
                    {
                        cartaMasCara = costosCartas[i];
                    }
                }
                Console.WriteLine($"La carta más cara del catálogo tiene un costo de {cartaMasCara} gemas");
                break;
            default:
                Console.WriteLine("Error: Opción no válida.");
                break;
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 5: Registro y Filtrado de Daño por Ráfaga 
Consigna: Cargar con un bucle for el daño de 6 flechas en un array de enteros. Luego, con un 
bucle while pedir un daño de referencia y filtrar con if/else los impactos que superaron ese 
número, acumulando y mostrando el total de daño filtrado.
=================================================================================================================================
*/
/*
{
    static void Main()
    {
        int[] damage = new int[6];
        int referencia;
        int totalDamage = 0;

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Ingrese el daño de la flecha " + (i + 1) + ": ");
            damage[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese el daño de referencia: ");
        referencia = int.Parse(Console.ReadLine());
        Console.Clear();

        int contador = 0;
        while (contador < 6)
        {
            if (damage[contador] > referencia)
            {
                totalDamage += damage[contador];
            }
            else
            {
                Console.WriteLine("La flecha " + (contador + 1) + " no superó la referencia.");
            }

            contador++;
        }

        Console.WriteLine("El total de daño filtrado es: " + totalDamage);
    }
}

 */

/*
=================================================================================================================================
Ejercicio 6: Selector de Elementos y Cargas Mágicas 
Declarar un array con 4 tipos de gemas ["Fuego", "Hielo", "Rayo", "Veneno"] y solicitar 
las cargas de cada una en un vector paralelo. Con un switch permitir:
1: Recargar todas (+5 cargas con bucle for) o
2: Buscar si hay alguna gema agotada (0 cargas con if). 
=================================================================================================================================
*/
/*
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];
        Console.WriteLine("--- INGRESO DE CARGAS INICIALES ---");
        for (int i = 0; i < gemas.Length; i++)
        {
            Console.Write($"Ingresá las cargas para la gema de {gemas[i]}: ");
            cargas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
        Console.WriteLine("1. Recargar todas (+5 cargas)");
        Console.WriteLine("2. Buscar gemas agotadas (0 cargas)");
        Console.Write("Elegí una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                for (int i = 0; i < cargas.Length; i++)
                {
                    cargas[i] += 5;
                    Console.WriteLine($"Gema {gemas[i]}: ahora tiene {cargas[i]} cargas.");
                }
                break;

            case 2:
                bool hayAgotadas = false;
                for (int i = 0; i < cargas.Length; i++)
                {
                    if (cargas[i] == 0)
                    {
                        Console.WriteLine($"¡La gema de {gemas[i]} está AGOTADA!");
                        hayAgotadas = true;
                    }
                }

                if (!hayAgotadas)
                {
                    Console.WriteLine("Ninguna gema se encuentra agotada.");
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra 
Un pasillo posee 6 baldosas representadas en un vector booleano
bool[] trampas = { false, true, false, false, true, false }
El jugador avanza casilleros mediante un bucle while mientras no pise trampa y no llegue a la meta(baldosa 5)
Con if/else validar si activa la trampa y pierde o si completa el recorrido
 =================================================================================================================================
*/

/*
{
    static void Main()
    {

        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        //bool perdio = false;
        bool sigueVivo = true;

        Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta : Baldosa 5)");

        while (posicion < 5 && sigueVivo)
        {

            Console.WriteLine("Estas en la baldosa: " + posicion);
            Console.Write("Elige el paso a dar (1 para avanzar, 2 avanzar...): ");
            int eleccion = int.Parse(Console.ReadLine());

            posicion += eleccion;

            if (posicion >= 5)
            {
                Console.WriteLine("¡Llegaste a la meta! ¡Felicidades!");
                break;
            }

            if (trampas[posicion])
            {
                Console.WriteLine("Perdiste " + posicion + " Fin de la partida");
                sigueVivo = false;
            }
            else
            {

                Console.WriteLine("seguis vivo pisaste balsoda segura " + posicion);
            }

        }

        if (sigueVivo)
        {
            Console.WriteLine("¡Felicidades! Has completado el recorrido.");
            Console.ReadKey();
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 8: Estadísticas de Fases del Boss 
Cargar con un for el daño recibido en las 3 fases de un Jefe en un array de enteros. 
Mediante un switch permitir: 
1: Calcular promedio de daño entre las 3 fases, 
2: Identificar la fase más destructiva mediante comparaciones if
=================================================================================================================================
*/

/*
{
    static void Main()
    {
        int[] dañoRecibido = new int[3];
        int promedio;
        int opcion;
        int auxiliar;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Ingresa el daño que te hicieron en la fase {i + 1}:");
            dañoRecibido[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("¿Qué quieres hacer?");
        Console.WriteLine("1. Calcular el promedio de daño");
        Console.WriteLine("2. Fase más destructiva");
        Console.WriteLine("Cualquier otro num para salir");

        opcion = int.Parse(Console.ReadLine());
        auxiliar = dañoRecibido[0];

        switch (opcion)
        {
            case 1:
                promedio = (dañoRecibido[0] + dañoRecibido[1] + dañoRecibido[2]) / 3;
                Console.WriteLine("El promedio de daño entre las 3 fases es: " + promedio);
                break;
            case 2:
                for (int i = 0; i < dañoRecibido.Length; i++)
                {
                    if (auxiliar < dañoRecibido[i])
                    {
                        auxiliar = dañoRecibido[i];
                    }
                }
                Console.WriteLine("La fase más destructiva fue: " + auxiliar);
                break;
            default:
                break;
        }
    }
}
*/

/*
=================================================================================================================================
Ejercicio 9: Sistema de Munición y Disparo por Cargador 
Un soldado dispone de un array de munición {30, 15, 8} correspondiente a Rifle, 
Pistola y Escopeta. Con un bucle while permitir realizar disparos sucesivos 
eligiendo el arma mediante un switch hasta que el usuario ingrese 0. Con 
if/else validar si el arma tiene balas suficientes o se encuentra vacía 
=================================================================================================================================
*/

/*

{
    static void Main()
    {
        int[] municion = { 30, 15, 8 };
        bool dispara = true;
        int opcion;

        while (dispara)
        {
            Console.WriteLine("Vamos a disparar, elegí tu arma:");
            Console.WriteLine($"1. Rifle ({municion[0]} balas)");
            Console.WriteLine($"2. Pistola ({municion[1]} balas)");
            Console.WriteLine($"3. Escopeta ({municion[2]} balas)");
            Console.WriteLine($"0. Dejar de disparar");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (municion[0] > 0)
                    {
                        municion[0]--;
                        Console.WriteLine("\n¡PUM! Has disparado el Rifle. Balas restantes: " + municion[0]);
                    }
                    else
                    {
                        Console.WriteLine("\n¡El Rifle no tiene balas suficientes! Se encuentra vacío.");
                    }
                    Console.WriteLine("Toca cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    if (municion[1] > 0)
                    {
                        municion[1]--;
                        Console.WriteLine("\n¡PUM! Has disparado la Pistola. Balas restantes: " + municion[1]);
                    }
                    else
                    {
                        Console.WriteLine("\n¡La Pistola no tiene balas suficientes! Se encuentra vacía.");
                    }
                    Console.WriteLine("Toca cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    if (municion[2] > 0)
                    {
                        municion[2]--;
                        Console.WriteLine("\n¡BOOM! Has disparado la Escopeta. Balas restantes: " + municion[2]);
                    }
                    else
                    {
                        Console.WriteLine("\n¡La Escopeta no tiene balas suficientes! Se encuentra vacía.");
                    }
                    Console.WriteLine("Toca cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 0:
                    dispara = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione de nuevo para volver a ver las opciones.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
*/


/*
=================================================================================================================================
Ejercicio 10: Asignador y Verificador de Bonificación de EXP 
Un clan realiza 5 misiones. Con un bucle for, almacenar
los puntos de EXP de cada misión en un array de enteros.
Si alguna misión superó los 100 puntos, aplicar
con  if/else un bono extra del 20% sobre esa posición.
Al final, imprimir la tabla del array actualizada y la experiencia total acumulada.
=================================================================================================================================
*/

{
    static void Main()
    {
        double[] expMisiones = new double[5];
        double acumulador = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingrese la EXP obtenida en la misión {i + 1}");
            expMisiones[i] = int.Parse(Console.ReadLine());
            if (expMisiones[i] > 100)
            {
                expMisiones[i] = expMisiones[i] * 1.20;
            }
        }
        Console.WriteLine("Las misiones con más de 100 de EXP han ganado un bono de un 20%");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Misión {i + 1}, EXP: " + expMisiones[i]);
            acumulador = acumulador + expMisiones[i];
        }

        Console.WriteLine("Experiencia acumulada de sus misiones: " + acumulador);
    }
}

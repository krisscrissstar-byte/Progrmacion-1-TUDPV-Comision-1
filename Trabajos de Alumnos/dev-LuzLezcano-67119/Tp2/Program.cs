using System;

class Ejercicio1
{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[4];

        // Carga de durabilidad con for
        for (int i = 0; i < armas.Length; i++)
        {
            Console.Write($"Ingrese la durabilidad para {armas[i]}: ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("--- MENÚ DE ARSENAL ---");
        Console.WriteLine("1: Inspeccionar armas críticas");
        Console.WriteLine("2: Ver arsenal completo");
        Console.WriteLine("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("--- ARMAS CRÍTICAS (Durabilidad <= 20) ---");
                for (int i = 0; i < armas.Length; i++)
                {
                    if (durabilidad[i] <= 20)
                    {
                        Console.WriteLine($"[ALERTA] {armas[i]} requiere reparación. Durabilidad: {durabilidad[i]}");
                    }
                }
                break;

            case 2:
                Console.WriteLine("--- ARSENAL COMPLETO ---");
                for (int i = 0; i < armas.Length; i++)
                {
                    Console.WriteLine($"{armas[i]} - Durabilidad: {durabilidad[i]}");
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

using System;

class Ejercicio2
{
    static void Main()
    {
        float[] tiempos = new float[5];

        // Carga de tiempos
        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.WriteLine($"Ingrese el tiempo del corredor {i + 1} (en segundos): ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        string continuar = "s";
        while (continuar.ToLower() == "s")
        {
            Console.WriteLine("Ingrese el tiempo objetivo a superar: ");
            float tiempoObjetivo = float.Parse(Console.ReadLine());

            int clasificados = 0;
            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= tiempoObjetivo)
                {
                    clasificados++;
                }
            }

            Console.WriteLine($"Un total de {clasificados} corredor(es) superaron la prueba logrando un tiempo <= {tiempoObjetivo}s.");

            Console.WriteLine("¿Desea probar con otro tiempo objetivo? (s/n): ");
            continuar = Console.ReadLine();
        }
    }
}

using System;

class Ejercicio3
{
    static void Main()
    {
        int[] slimes = { 30, 40, 50, 60 };

        while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
        {
            Console.WriteLine("--- ESTADO DE LA HORDA ---");
            for (int i = 0; i < slimes.Length; i++)
            {
                Console.WriteLine($"Slime [{i}]: {(slimes[i] > 0 ? slimes[i] + " HP" : "DERROTADO")}");
            }

            Console.WriteLine("Elija a cuál slime atacar (0 al 3): ");
            int objetivo = int.Parse(Console.ReadLine());

            switch (objetivo)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    if (slimes[objetivo] <= 0)
                    {
                        Console.WriteLine($"¡El Slime {objetivo} ya fue derrotado! Elige otro objetivo.");
                    }
                    else
                    {
                        slimes[objetivo] -= 20;
                        if (slimes[objetivo] < 0) slimes[objetivo] = 0;
                        Console.WriteLine($"¡Atacaste al Slime {objetivo}! Le restaste 20 HP.");
                    }
                    break;

                default:
                    Console.WriteLine("Índice de slime no válido. Elija entre 0 y 3.");
                    break;
            }
        }

        Console.WriteLine("¡Felicidades! Todos los slimes han sido derrotados.");
    }
}

using System;

class Ejercicio4
{
    static void Main()
    {
        int[] costos = { 10, 25, 50, 80, 120 };

        Console.WriteLine("Ingrese la cantidad de gemas del usuario: ");
        int gemas = int.Parse(Console.ReadLine());

        Console.WriteLine("--- TIENDA DE CARTAS ---");
        Console.WriteLine("1: Mostrar cartas que puede pagar");
        Console.WriteLine("2: Identificar la carta más cara del catálogo");
        Console.WriteLine("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"Cartas disponibles para pagarse con {gemas} gemas:");
                bool alguna = false;
                for (int i = 0; i < costos.Length; i++)
                {
                    if (gemas >= costos[i])
                    {
                        Console.WriteLine($"- Carta {i + 1}: Costo {costos[i]} gemas");
                        alguna = true;
                    }
                }
                if (!alguna)
                {
                    Console.WriteLine("No tienes gemas suficientes para ninguna carta.");
                }
                break;

            case 2:
                int masCara = costos[0];
                for (int i = 1; i < costos.Length; i++)
                {
                    if (costos[i] > masCara)
                    {
                        masCara = costos[i];
                    }
                }
                Console.WriteLine($"La carta más cara del catálogo cuesta: {masCara} gemas.");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}

using System;

class Ejercicio5
{
    static void Main()
    {
        int[] flechas = new int[6];

        // Carga del daño de 6 flechas
        for (int i = 0; i < flechas.Length; i++)
        {
            Console.WriteLine($"Ingrese el daño de la flecha {i + 1}: ");
            flechas[i] = int.Parse(Console.ReadLine());
        }

        string continuar = "s";
        while (continuar.ToLower() == "s")
        {
            Console.WriteLine("Ingrese un daño de referencia para filtrar: ");
            int danoReferencia = int.Parse(Console.ReadLine());

            int acumulado = 0;
            Console.WriteLine($"Impactos que superaron {danoReferencia} de daño:");
            for (int i = 0; i < flechas.Length; i++)
            {
                if (flechas[i] > danoReferencia)
                {
                    Console.WriteLine($"- Flecha {i + 1}: {flechas[i]} de daño");
                    acumulado += flechas[i];
                }
            }

            Console.WriteLine($"Daño total acumulado de impactos filtrados: {acumulado}");

            Console.WriteLine("¿Desea ingresar otro daño de referencia? (s/n): ");
            continuar = Console.ReadLine();
        }
    }
}

using System;

class Ejercicio6
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];

        // Carga del vector paralelo
        for (int i = 0; i < gemas.Length; i++)
        {
            Console.WriteLine($"Ingrese las cargas para la gema de {gemas[i]}: ");
            cargas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("--- MENÚ MÁGICO ---");
        Console.WriteLine("1: Recargar todas (+5 cargas)");
        Console.WriteLine("2: Buscar si hay alguna gema agotada");
        Console.WriteLine("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("--- RECARGANDO GEMAS ---");
                for (int i = 0; i < gemas.Length; i++)
                {
                    cargas[i] += 5;
                    Console.WriteLine($"Gema {gemas[i]}: {cargas[i]} cargas actualizadas.");
                }
                break;

            case 2:
                Console.WriteLine("--- BÚSQUEDA DE GEMAS AGOTADAS ---");
                bool hayAgotadas = false;
                for (int i = 0; i < gemas.Length; i++)
                {
                    if (cargas[i] == 0)
                    {
                        Console.WriteLine($"[ALERTA] La gema de {gemas[i]} está totalmente agotada.");
                        hayAgotadas = true;
                    }
                }
                if (!hayAgotadas)
                {
                    Console.WriteLine("Todas las gemas conservan al menos una carga.");
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}

using System;

class Ejercicio7
{
    static void Main()
    {
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        bool pisotrampa = false;

        Console.WriteLine("--- EXPLORACIÓN DE LA MAZMORRA ---");

        while (!pisotrampa && posicion < 5)
        {
            Console.WriteLine($"Estás seguro en la baldosa {posicion}. Avanzas a la siguiente...");
            posicion++;

            if (trampas[posicion])
            {
                pisotrampa = true;
                Console.WriteLine($"¡PUM! Pisaste una trampa en la baldosa {posicion}. Has perdido.");
            }
            else if (posicion == 5)
            {
                Console.WriteLine($"¡Felicidades! Llegaste a la meta en la baldosa {posicion} sano y salvo.");
            }
        }
    }
}

using System;

class Ejercicio8
{
    static void Main()
    {
        int[] danoFases = new int[3];

        for (int i = 0; i < danoFases.Length; i++)
        {
            Console.WriteLine($"Ingrese el daño recibido en la Fase {i + 1}: ");
            danoFases[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("--- MENÚ DE ESTADÍSTICAS DEL BOSS ---");
        Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
        Console.WriteLine("2: Identificar la fase más destructiva");
        Console.WriteLine("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                double promedio = (danoFases[0] + danoFases[1] + danoFases[2]) / 3.0;
                Console.WriteLine($"El promedio de daño recibido es: {promedio:F2}");
                break;

            case 2:
                int mayorDano = danoFases[0];
                int faseMasDestructiva = 1;

                if (danoFases[1] > mayorDano)
                {
                    mayorDano = danoFases[1];
                    faseMasDestructiva = 2;
                }
                if (danoFases[2] > mayorDano)
                {
                    mayorDano = danoFases[2];
                    faseMasDestructiva = 3;
                }

                Console.WriteLine($"La fase más destructiva fue la Fase {faseMasDestructiva} con {mayorDano} de daño.");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}

using System;

class Ejercicio9
{
    static void Main()
    {
        int[] municion = { 30, 15, 8 }; // [0]: Rifle, [1]: Pistola, [2]: Escopeta
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("--- SELECCIÓN DE ARMA ---");
            Console.WriteLine($"1: Rifle (Balas: {municion[0]})");
            Console.WriteLine($"2: Pistola (Balas: {municion[1]})");
            Console.WriteLine($"3: Escopeta (Balas: {municion[2]})");
            Console.WriteLine("0: Salir / Detener disparos");
            Console.WriteLine("Elija un opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                case 2:
                case 3:
                    int idx = opcion - 1;
                    if (municion[idx] > 0)
                    {
                        municion[idx]--;
                        Console.WriteLine("¡PUM! Disparo realizado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("¡CLIC! El arma está vacía.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema de armas.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}

using System;

class Ejercicio10
{
    static void Main()
    {
        double[] expMisiones = new double[5];

        // Carga de EXP por Misión
        for (int i = 0; i < expMisiones.Length; i++)
        {
            Console.WriteLine($"Ingrese los puntos de EXP obtenidos en la Misión {i + 1}: ");
            expMisiones[i] = double.Parse(Console.ReadLine());
        }

        // Aplicación del bono
        double expTotal = 0;
        for (int i = 0; i < expMisiones.Length; i++)
        {
            if (expMisiones[i] > 100)
            {
                expMisiones[i] *= 1.20; // Aplica bono del 20%
            }
            expTotal += expMisiones[i];
        }

        // Impresión de la tabla actualizada y total
        Console.WriteLine("--- TABLA ACTUALIZADA DE EXPERIENCIA ---");
        for (int i = 0; i < expMisiones.Length; i++)
        {
            Console.WriteLine($"Misión {i + 1}: {expMisiones[i]} EXP");
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine($"Experiencia Total Acumulada: {expTotal} EXP");
    }
}
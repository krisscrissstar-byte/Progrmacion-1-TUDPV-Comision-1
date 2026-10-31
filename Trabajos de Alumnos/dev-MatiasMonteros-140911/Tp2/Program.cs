using System;

namespace TrabajoPractico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
        }

        // ============================================================
        // EJERCICIO 1: Sistema de Inventario y Durabilidad de Armas
        // Combina: Array + for + switch + if/else
        // ============================================================
        static void Ejercicio1()
        {
            Console.WriteLine("--- Ejercicio 1: Inventario y Durabilidad de Armas ---");

            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            // Cargar durabilidad de cada arma por teclado con un for
            for (int i = 0; i < armas.Length; i++)
            {
                Console.Write($"Ingrese durabilidad de {armas[i]}: ");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1: Inspeccionar armas críticas");
            Console.WriteLine("2: Ver arsenal completo");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Recorrer con for y evaluar con if durabilidad <= 20
                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine($"¡ALERTA! {armas[i]} está crítica (durabilidad: {durabilidad[i]})");
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"{armas[i]}: {durabilidad[i]}");
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        // ============================================================
        // EJERCICIO 2: Marcador Top 5 de Speedrun
        // Combina: Array + for + while + if/else
        // ============================================================
        static void Ejercicio2()
        {
            Console.WriteLine("--- Ejercicio 2: Marcador Top 5 de Speedrun ---");

            float[] tiempos = new float[5];

            // Cargar tiempos de 5 corredores con for
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write($"Ingrese tiempo del corredor {i + 1}: ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            // Con while permitir ingresar distintas marcas objetivo
            bool seguir = true;
            while (seguir)
            {
                Console.Write("Ingrese tiempo objetivo a superar (o -1 para salir): ");
                float objetivo = float.Parse(Console.ReadLine());

                if (objetivo == -1)
                {
                    seguir = false;
                }
                else
                {
                    int clasificados = 0;

                    for (int i = 0; i < tiempos.Length; i++)
                    {
                        if (tiempos[i] <= objetivo)
                        {
                            clasificados++;
                        }
                    }

                    if (clasificados > 0)
                    {
                        Console.WriteLine($"{clasificados} corredor(es) superaron la prueba.");
                    }
                    else
                    {
                        Console.WriteLine("Ningún corredor logró un tiempo válido.");
                    }
                }
            }
        }

        // ============================================================
        // EJERCICIO 3: Combate contra Horda de Slimes
        // Combina: Array + while + switch + if/else
        // ============================================================
        static void Ejercicio3()
        {
            Console.WriteLine("--- Ejercicio 3: Combate contra Horda de Slimes ---");

            int[] slimes = { 30, 40, 50, 60 };

            // Mientras al menos un slime tenga vida > 0
            bool hayVivos = true;

            while (hayVivos)
            {
                Console.WriteLine("\nEstado actual de los slimes:");
                for (int i = 0; i < slimes.Length; i++)
                {
                    Console.WriteLine($"Slime {i}: {slimes[i]} HP");
                }

                Console.Write("Elija a cuál atacar (0 al 3): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (slimes[opcion] <= 0)
                        {
                            Console.WriteLine("Ese slime ya fue derrotado.");
                        }
                        else
                        {
                            slimes[opcion] -= 20;
                            if (slimes[opcion] < 0) slimes[opcion] = 0;
                            Console.WriteLine($"Atacaste al slime {opcion}. Vida restante: {slimes[opcion]}");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                // Verificar si queda algún slime vivo
                hayVivos = false;
                for (int i = 0; i < slimes.Length; i++)
                {
                    if (slimes[i] > 0)
                    {
                        hayVivos = true;
                    }
                }
            }

            Console.WriteLine("¡Todos los slimes fueron derrotados!");
        }

        // ============================================================
        // EJERCICIO 4: Canje de Recompensas en Tienda de Cartas
        // Combina: Array + switch + for + if/else
        // ============================================================
        static void Ejercicio4()
        {
            Console.WriteLine("--- Ejercicio 4: Canje de Recompensas en Tienda de Cartas ---");

            int[] costos = { 10, 25, 50, 80, 120 };

            Console.Write("Ingrese la cantidad de gemas que posee: ");
            int gemas = int.Parse(Console.ReadLine());

            Console.WriteLine("1: Mostrar cartas que puede pagar");
            Console.WriteLine("2: Identificar la carta más cara del catálogo");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < costos.Length; i++)
                    {
                        if (costos[i] <= gemas)
                        {
                            Console.WriteLine($"Puede pagar la carta {i} (costo: {costos[i]})");
                        }
                    }
                    break;

                case 2:
                    int indiceMasCara = 0;
                    for (int i = 1; i < costos.Length; i++)
                    {
                        if (costos[i] > costos[indiceMasCara])
                        {
                            indiceMasCara = i;
                        }
                    }
                    Console.WriteLine($"La carta más cara es la {indiceMasCara} con un costo de {costos[indiceMasCara]} gemas.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        // ============================================================
        // EJERCICIO 5: Registro y Filtrado de Daño por Ráfaga
        // Combina: Array + for + while + if/else
        // ============================================================
        static void Ejercicio5()
        {
            Console.WriteLine("--- Ejercicio 5: Registro y Filtrado de Daño por Ráfaga ---");

            int[] danios = new int[6];

            // Cargar daño de 6 flechas con for
            for (int i = 0; i < danios.Length; i++)
            {
                Console.Write($"Ingrese daño de la flecha {i + 1}: ");
                danios[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese el daño de referencia: ");
            int referencia = int.Parse(Console.ReadLine());

            int totalFiltrado = 0;
            int i2 = 0;

            // Filtrar con while los impactos que superaron la referencia
            while (i2 < danios.Length)
            {
                if (danios[i2] > referencia)
                {
                    totalFiltrado += danios[i2];
                }
                else
                {
                    // no supera la referencia, se descarta
                }
                i2++;
            }

            Console.WriteLine($"Daño total filtrado (impactos > {referencia}): {totalFiltrado}");
        }

        // ============================================================
        // EJERCICIO 6: Selector de Elementos y Cargas Mágicas
        // Combina: Array + switch + for + if
        // ============================================================
        static void Ejercicio6()
        {
            Console.WriteLine("--- Ejercicio 6: Selector de Elementos y Cargas Mágicas ---");

            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargas = new int[4];

            for (int i = 0; i < gemas.Length; i++)
            {
                Console.Write($"Ingrese cargas de {gemas[i]}: ");
                cargas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1: Recargar todas (+5 cargas)");
            Console.WriteLine("2: Buscar si hay alguna gema agotada");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < cargas.Length; i++)
                    {
                        cargas[i] += 5;
                    }
                    Console.WriteLine("Todas las gemas fueron recargadas (+5).");
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        Console.WriteLine($"{gemas[i]}: {cargas[i]} cargas");
                    }
                    break;

                case 2:
                    bool hayAgotada = false;
                    for (int i = 0; i < cargas.Length; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine($"La gema de {gemas[i]} está agotada.");
                            hayAgotada = true;
                        }
                    }
                    if (!hayAgotada)
                    {
                        Console.WriteLine("No hay gemas agotadas.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        // ============================================================
        // EJERCICIO 7: Detección de Trampas en Pasillo de Mazmorra
        // Combina: Array + while + if/else
        // ============================================================
        static void Ejercicio7()
        {
            Console.WriteLine("--- Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra ---");

            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool perdio = false;

            // Avanza mientras no pise trampa y no llegue a la meta (baldosa 5)
            while (posicion < trampas.Length && !trampas[posicion] && posicion < 5)
            {
                Console.WriteLine($"Avanza a la baldosa {posicion}... segura.");
                posicion++;
            }

            if (posicion < trampas.Length && trampas[posicion])
            {
                perdio = true;
            }

            if (perdio)
            {
                Console.WriteLine($"¡Pisó una trampa en la baldosa {posicion}! El jugador pierde.");
            }
            else
            {
                Console.WriteLine("¡El jugador completó el recorrido sin pisar ninguna trampa!");
            }
        }

        // ============================================================
        // EJERCICIO 8: Estadísticas de Fases del Boss
        // Combina: Array + for + switch + if
        // ============================================================
        static void Ejercicio8()
        {
            Console.WriteLine("--- Ejercicio 8: Estadísticas de Fases del Boss ---");

            int[] danioFases = new int[3];

            for (int i = 0; i < danioFases.Length; i++)
            {
                Console.Write($"Ingrese daño recibido en la fase {i + 1}: ");
                danioFases[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
            Console.WriteLine("2: Identificar la fase más destructiva");
            Console.Write("Elija una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    for (int i = 0; i < danioFases.Length; i++)
                    {
                        suma += danioFases[i];
                    }
                    float promedio = (float)suma / danioFases.Length;
                    Console.WriteLine($"Promedio de daño entre las 3 fases: {promedio}");
                    break;

                case 2:
                    int faseMasDestructiva = 0;
                    for (int i = 1; i < danioFases.Length; i++)
                    {
                        if (danioFases[i] > danioFases[faseMasDestructiva])
                        {
                            faseMasDestructiva = i;
                        }
                    }
                    Console.WriteLine($"La fase más destructiva fue la fase {faseMasDestructiva + 1} con {danioFases[faseMasDestructiva]} de daño.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        // ============================================================
        // EJERCICIO 9: Sistema de Munición y Disparo por Cargador
        // Combina: Array + while + switch + if/else
        // ============================================================
        static void Ejercicio9()
        {
            Console.WriteLine("--- Ejercicio 9: Sistema de Munición y Disparo por Cargador ---");

            string[] nombresArmas = { "Rifle", "Pistola", "Escopeta" };
            int[] municion = { 30, 15, 8 };

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("Elija arma para disparar (1: Rifle, 2: Pistola, 3: Escopeta, 0: Salir):");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    case 2:
                    case 3:
                        int indice = opcion - 1;

                        if (municion[indice] > 0)
                        {
                            municion[indice]--;
                            Console.WriteLine($"Disparo con {nombresArmas[indice]}. Munición restante: {municion[indice]}");
                        }
                        else
                        {
                            Console.WriteLine($"{nombresArmas[indice]} está vacía. No hay balas suficientes.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Fin de la sesión de disparo.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        // ============================================================
        // EJERCICIO 10: Asignador y Verificador de Bonificación de EXP
        // Combina: Array + for + if/else
        // ============================================================
        static void Ejercicio10()
        {
            Console.WriteLine("--- Ejercicio 10: Asignador y Verificador de Bonificación de EXP ---");

            int[] misiones = new int[5];

            // Cargar puntos de EXP de cada misión con for
            for (int i = 0; i < misiones.Length; i++)
            {
                Console.Write($"Ingrese puntos de EXP de la misión {i + 1}: ");
                misiones[i] = int.Parse(Console.ReadLine());
            }

            int expTotal = 0;

            // Si supera 100 puntos, aplicar bono del 20% sobre esa posición
            for (int i = 0; i < misiones.Length; i++)
            {
                if (misiones[i] > 100)
                {
                    misiones[i] = misiones[i] + (int)(misiones[i] * 0.20);
                }
                else
                {
                    // sin bono, se mantiene igual
                }

                expTotal += misiones[i];
            }

            Console.WriteLine("Tabla actualizada de misiones:");
            for (int i = 0; i < misiones.Length; i++)
            {
                Console.WriteLine($"Misión {i + 1}: {misiones[i]} EXP");
            }

            Console.WriteLine($"Experiencia total acumulada: {expTotal}");
        }
    }
}
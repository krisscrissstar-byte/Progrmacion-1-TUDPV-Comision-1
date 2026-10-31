using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Alumno: Genaro Varela - Legajo: 67036");
                Console.WriteLine("\n==========================================");
                Console.WriteLine("   Trabajo Practico 2 - UTN FRT");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Sistema de Inventario y Durabilidad de Armas");
                Console.WriteLine("2. Marcador Top 5 de Speedrun");
                Console.WriteLine("3. Combate contra Horda de Slimes");
                Console.WriteLine("4. Canje de Recompensas en Tienda de Cartas");
                Console.WriteLine("5. Registro y Filtrado de Daño por Ráfaga");
                Console.WriteLine("6. Selector de Elementos y Cargas Mágicas");
                Console.WriteLine("7. Detección de Trampas en Pasillo de Mazmorra");
                Console.WriteLine("8. Estadísticas de Fases del Boss");
                Console.WriteLine("9. Sistema de Munición y Disparo por Cargador");
                Console.WriteLine("10. Asignador y Verificador de Bonificación de EXP");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione el ejercicio a ejecutar: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                    case 5:
                        Ejercicio5();
                        break;
                    case 6:
                        Ejercicio6();
                        break;
                    case 7:
                        Ejercicio7();
                        break;
                    case 8:
                        Ejercicio8();
                        break;
                    case 9:
                        Ejercicio9();
                        break;
                    case 10:
                        Ejercicio10();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }

        // Ejercicio 1: Sistema de Inventario y Durabilidad de Armas
        static void Ejercicio1()
        {
            Console.WriteLine("\n--- Ejercicio 1: Sistema de Inventario y Durabilidad de Armas ---");
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[armas.Length];
            
            Console.WriteLine("Ingrese la durabilidad de cada arma (0-100):");
            for (int i = 0; i < armas.Length; i++)
            {
                Console.Write($"Durabilidad de {armas[i]}: ");
                durabilidad[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1 - Inspeccionar armas críticas (<20 durabilidad)");
            Console.WriteLine("2 - Ver arsenal completo");
            Console.Write("Opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine($"[ALERTA] El arma {armas[i]} tiene durabilidad crítica: {durabilidad[i]}");
                        }
                        else
                        {
                            Console.WriteLine($"El arma {armas[i]} tiene durabilidad: {durabilidad[i]}");
                        }
                    }
                    break;
                case "2":
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"Arma disponible: {armas[i]} - Durabilidad: {durabilidad[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Ejercicio 2: Marcador Top 5 de Speedrun
        static void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2: Marcador Top 5 de Speedrun ---");
            float[] tiempos = new float[5];

            Console.WriteLine("Ingrese los tiempos de los 5 corredores:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Tiempo del corredor {i + 1}: ");
                tiempos[i] = float.Parse(Console.ReadLine() ?? "0");
            }

            string continuar = "si";
            while (continuar.ToLower() == "si" || continuar.ToLower() == "s")
            {
                Console.Write("\nIngrese un tiempo objetivo para clasificar: ");
                float objetivo = float.Parse(Console.ReadLine() ?? "0");
                int clasificados = 0;

                for (int i = 0; i < tiempos.Length; i++)
                {
                    if (tiempos[i] <= objetivo)
                    {
                        clasificados++;
                    }
                }

                Console.WriteLine($"Cantidad de corredores que superaron la prueba (<= {objetivo}): {clasificados}");
                Console.Write("¿Desea probar otro tiempo objetivo? (si/no): ");
                continuar = Console.ReadLine() ?? "no";
            }
        }

        // Ejercicio 3: Combate contra Horda de Slimes
        static void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3: Combate contra Horda de Slimes ---");
            int[] slimes = { 30, 40, 50, 60 };

            bool hordaViva = true;
            while (hordaViva)
            {
                Console.WriteLine("\nEstado de los Slimes:");
                for (int i = 0; i < slimes.Length; i++)
                {
                    Console.WriteLine($"Slime {i}: HP = {slimes[i]}");
                }

                // Verificar si al menos un slime tiene vida > 0
                int vivos = 0;
                foreach (int hp in slimes)
                {
                    if (hp > 0) vivos++;
                }

                if (vivos == 0)
                {
                    Console.WriteLine("\n¡Todos los slimes han sido derrotados! Victoria.");
                    break;
                }

                Console.Write("Elija a cuál slime atacar (0 al 3):");
                if (int.TryParse(Console.ReadLine(), out int objetivo) && objetivo >= 0 && objetivo < slimes.Length)
                {
                    if (slimes[objetivo] <= 0)
                    {
                        Console.WriteLine("¡El slime seleccionado ya fue derrotado! Elija otro.");
                    }
                    else
                    {
                        slimes[objetivo] -= 20;
                        if (slimes[objetivo] < 0) slimes[objetivo] = 0;
                        Console.WriteLine($"¡Ataque exitoso! Al Slime {objetivo} le quedan {slimes[objetivo]} HP.");
                    }
                }
                else
                {
                    Console.WriteLine("Opción de ataque inválida.");
                }
            }
        }

        // Ejercicio 4: Canje de Recompensas en Tienda de Cartas
        static void Ejercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4: Canje de Recompensas en Tienda de Cartas ---");
            int[] costos = { 10, 25, 50, 80, 120 };

            Console.Write("Ingrese la cantidad de gemas que posee el usuario: ");
            int gemas = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1: Mostrar cartas que puede pagar");
            Console.WriteLine("2: Identificar la carta más cara del catálogo");
            Console.Write("Opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Cartas que puede pagar:");
                    for (int i = 0; i < costos.Length; i++)
                    {
                        if (gemas >= costos[i])
                        {
                            Console.WriteLine($"- Carta {i + 1} con costo de {costos[i]} gemas.");
                        }
                    }
                    break;
                case "2":
                    int masCara = costos[0];
                    int indexCara = 0;
                    for (int i = 1; i < costos.Length; i++)
                    {
                        if (costos[i] > masCara)
                        {
                            masCara = costos[i];
                            indexCara = i;
                        }
                    }
                    Console.WriteLine($"La carta más cara cuesta {masCara} gemas (Posición {indexCara + 1}).");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Ejercicio 5: Registro y Filtrado de Daño por Ráfaga
        static void Ejercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5: Registro y Filtrado de Daño por Ráfaga ---");
            int[] danoFlechas = new int[6];

            Console.WriteLine("Cargue el daño de las 6 flechas:");
            for (int i = 0; i < danoFlechas.Length; i++)
            {
                Console.Write($"Daño flecha {i + 1}: ");
                danoFlechas[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            string continuar = "si";
            while (continuar.ToLower() == "si" || continuar.ToLower() == "s")
            {
                Console.Write("\nIngrese un daño de referencia: ");
                int referencia = int.Parse(Console.ReadLine() ?? "0");
                int acumuladorDano = 0;

                Console.WriteLine($"Impactos que superaron el daño {referencia}:");
                for (int i = 0; i < danoFlechas.Length; i++)
                {
                    if (danoFlechas[i] > referencia)
                    {
                        Console.WriteLine($"- Flecha {i + 1} con {danoFlechas[i]} de daño.");
                        acumuladorDano += danoFlechas[i];
                    }
                }

                Console.WriteLine($"Total de daño filtrado acumulado: {acumuladorDano}");
                Console.Write("¿Desea ingresar otro valor de referencia? (si/no): ");
                continuar = Console.ReadLine() ?? "no";
            }
        }

        // Ejercicio 6: Selector de Elementos y Cargas Mágicas
        static void Ejercicio6()
        {
            Console.WriteLine("\n--- Ejercicio 6: Selector de Elementos y Cargas Mágicas ---");
            string[] gemasMagicas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargas = new int[gemasMagicas.Length];

            Console.WriteLine("Solicitar cargas de cada gema:");
            for (int i = 0; i < gemasMagicas.Length; i++)
            {
                Console.Write($"Cargas para {gemasMagicas[i]}: ");
                cargas[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1: Recargar todas (+5 cargas)");
            Console.WriteLine("2: Buscar si hay alguna gema agotada (0 cargas)");
            Console.Write("Opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i < cargas.Length; i++)
                    {
                        cargas[i] += 5;
                    }
                    Console.WriteLine("\n¡Cargas actualizadas (+5 a todas)!");
                    for (int i = 0; i < gemasMagicas.Length; i++)
                    {
                        Console.WriteLine($"{gemasMagicas[i]}: {cargas[i]} cargas.");
                    }
                    break;
                case "2":
                    bool agotadaEncontrada = false;
                    for (int i = 0; i < cargas.Length; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine($"[ALERTA] La gema de {gemasMagicas[i]} está totalmente AGOTADA.");
                            agotadaEncontrada = true;
                        }
                    }
                    if (!agotadaEncontrada)
                    {
                        Console.WriteLine("No hay gemas agotadas; todas tienen cargas.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra
        static void Ejercicio7()
        {
            Console.WriteLine("\n--- Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra ---");
            bool[] trampas = { false, true, false, false, true, false };
            int posicionActual = 0;
            int meta = 5;

            Console.WriteLine("Comienza el recorrido en el pasillo (Baldosas 0 a 5)...");

            while (posicionActual < meta)
            {
                Console.WriteLine($"Te encuentras en la baldosa {posicionActual}.");

                if (trampas[posicionActual])
                {
                    Console.WriteLine($"¡Puch! Pisaste una trampa en la baldosa {posicionActual}. ¡Has perdido!");
                    return;
                }

                posicionActual++;
                
                if (posicionActual == meta && !trampas[meta])
                {
                    Console.WriteLine($"¡Llegaste a la meta (baldosa {meta}) sano y salvo! ¡Completaste el recorrido!");
                    break;
                }
            }
        }

        // Ejercicio 8: Estadísticas de Fases del Boss
        static void Ejercicio8()
        {
            Console.WriteLine("\n--- Ejercicio 8: Estadísticas de Fases del Boss ---");
            int[] danoFases = new int[3];

            Console.WriteLine("Cargue el daño recibido en las 3 fases del Jefe:");
            for (int i = 0; i < danoFases.Length; i++)
            {
                Console.Write($"Daño en la fase {i + 1}: ");
                danoFases[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
            Console.WriteLine("2: Identificar la fase más destructiva");
            Console.Write("Opción: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    double suma = 0;
                    for (int i = 0; i < danoFases.Length; i++)
                    {
                        suma += danoFases[i];
                    }
                    double promedio = suma / danoFases.Length;
                    Console.WriteLine($"El promedio de daño entre las 3 fases es: {promedio:F2}");
                    break;
                case "2":
                    int faseMasDestructiva = 0;
                    int maxDano = danoFases[0];

                    for (int i = 1; i < danoFases.Length; i++)
                    {
                        if (danoFases[i] > maxDano)
                        {
                            maxDano = danoFases[i];
                            faseMasDestructiva = i;
                        }
                    }
                    Console.WriteLine($"La fase más destructiva fue la Fase {faseMasDestructiva + 1} con {maxDano} de daño.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Ejercicio 9: Sistema de Munición y Disparo por Cargador
        static void Ejercicio9()
        {
            Console.WriteLine("\n--- Ejercicio 9: Sistema de Munición y Disparo por Cargador ---");
            int[] municion = { 30, 15, 8 }; // 0: Rifle, 1: Pistola, 2: Escopeta
            string[] nombresArmas = { "Rifle", "Pistola", "Escopeta" };

            int opcionArma = -1;
            while (opcionArma != 0)
            {
                Console.WriteLine("\nMunición actual:");
                for (int i = 0; i < municion.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombresArmas[i]}: {municion[i]} balas");
                }
                Console.WriteLine("0. Salir al menú principal");

                Console.Write("Elija el arma para disparar (1-3) o 0 para salir: ");
                if (int.TryParse(Console.ReadLine(), out opcionArma))
                {
                    if (opcionArma == 0) break;

                    int indice = opcionArma - 1;
                    switch (indice)
                    {
                        case 0:
                        case 1:
                        case 2:
                            if (municion[indice] > 0)
                            {
                                municion[indice]--;
                                Console.WriteLine($"¡Disparo exitoso con {nombresArmas[indice]}! Balas restantes: {municion[indice]}");
                            }
                            else
                            {
                                Console.WriteLine($"¡El arma {nombresArmas[indice]} se encuentra vacía! No hay balas suficientes.");
                            }
                            break;
                        default:
                            Console.WriteLine("Arma no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }
        }

        // Ejercicio 10: Asignador y Verificador de Bonificación de EXP
        static void Ejercicio10()
        {
            Console.WriteLine("\n--- Ejercicio 10: Asignador y Verificador de Bonificación de EXP ---");
            int[] expMisiones = new int[5];
            int expTotal = 0;

            Console.WriteLine("Ingrese los puntos de EXP de cada una de las 5 misiones:");
            for (int i = 0; i < expMisiones.Length; i++)
            {
                Console.Write($"EXP Misión {i + 1}: ");
                expMisiones[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            // Aplicar bonificación si supera los 100 puntos
            for (int i = 0; i < expMisiones.Length; i++)
            {
                if (expMisiones[i] > 100)
                {
                    int bono = (int)(expMisiones[i] * 0.20);
                    expMisiones[i] += bono;
                    Console.WriteLine($"[Bono aplicado] La misión {i + 1} superó los 100 pts. Se aplicó un 20% extra (+{bono}). Nuevo valor: {expMisiones[i]}");
                }
                expTotal += expMisiones[i];
            }

            Console.WriteLine("\n--- Tabla de Misiones Actualizada ---");
            for (int i = 0; i < expMisiones.Length; i++)
            {
                Console.WriteLine($"Misión {i + 1}: {expMisiones[i]} EXP");
            }
            Console.WriteLine($"\nExperiencia total acumulada: {expTotal} puntos.");
        }
    }
}
<<<<<<< HEAD
﻿using System;
// Trabajo Práctico 2 - TUDPV
// Alumno: Rahman Rintoul Ramiro
// Legajo: 67050
namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string? opcion = "";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("====== Elegir un Ejercicio a continuación ======");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 1 Durabilidad de armas");
                Console.WriteLine("2. Ejercicio 2 Top 5 Speedrun");
                Console.WriteLine("3. Ejercicio 3 Combate de Slimes");
                Console.WriteLine("4. Ejercicio 4 Canje de Recompensas");
                Console.WriteLine("5. Ejercicio 5 Daño por rafaga");
                Console.WriteLine("6. Ejercicio 6 Cargas mágicas");
                Console.WriteLine("7. Ejercicio 7 Baldosas trampas en mazmorra");
                Console.WriteLine("8. Ejercicio 8 Fases de boss");
                Console.WriteLine("9. Ejercicio 9 Sistema de municion y disparo");
                Console.WriteLine("10. Ejercicio 10 Asignador de experiencia");
                Console.WriteLine("===============================================");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Ejercicio1();
                        break;

                    case "2":
                        Ejercicio2();
                        break;

                    case "3":
                        Ejercicio3();
                        break;

                    case "4":
                        Ejercicio4();
                        break;

                    case "5":
                        Ejercicio5();
                        break;

                    case "6":
                        Ejercicio6();
                        break;

                    case "7":
                        Ejercicio7();
                        break;

                    case "8":
                        Ejercicio8();
                        break;

                    case "9":
                        Ejercicio9();
                        break;

                    case "10":
                        Ejercicio10();
                        break;

                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 1 - Durabilidad de armas");
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            for (int i = 0; i < durabilidad.Length; i++)
            {
                Console.Write($"Ingrese la durabilidad del arma {armas[i]}: ");
                int.TryParse(Console.ReadLine(), out durabilidad[i]);
            }
            Console.WriteLine("\nIngrese la opción que desea realizar:");
            Console.WriteLine("1. Inspecionar armas críticas");
            Console.WriteLine("2. Ver arsenal completo");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nArmas críticas:");
                    for (int i = 0; i < durabilidad.Length; i++)
                    {
                        if (durabilidad[i] < 20)
                        {
                            Console.WriteLine($"{armas[i]} - Durabilidad: {durabilidad[i]}");
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("\nArsenal completo:");
                    for (int i = 0; i < durabilidad.Length; i++)
                    {
                        Console.WriteLine($"{armas[i]} - Durabilidad: {durabilidad[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }

        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2 - Speedrun");

            float[] tiempos = new float[5];

            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write($"Ingrese el tiempo del corredor {i + 1} (en segundos): ");
                float.TryParse(Console.ReadLine(), out tiempos[i]);
            }

            float tiempoObjetivo = -1;

            while (tiempoObjetivo != 0)
            {
                Console.WriteLine("\nIngrese 0 para volver al menú.");
                Console.Write("Ingrese un tiempo objetivo para clasificar: ");


                float.TryParse(Console.ReadLine(), out tiempoObjetivo);

                if (tiempoObjetivo != 0)
                {
                    int clasificados = 0;

                    for (int i = 0; i < tiempos.Length; i++)
                    {
                        if (tiempos[i] <= tiempoObjetivo)
                        {
                            Console.WriteLine(
                                $"Corredor {i + 1}: {tiempos[i]} segundos - Clasificado"
                            );

                            clasificados++;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Corredor {i + 1}: {tiempos[i]} segundos - No clasificado"
                            );
                        }
                    }

                    Console.WriteLine(
                        $"\nCantidad de corredores que superaron la prueba: {clasificados}"
                    );
                }
            }
        }

        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3 - Combate de Slimes");
            int[] slimes = { 30, 40, 50, 60 };

            while (slimes.Any(vida => vida > 0))
            {
                string? opcion;
                Console.WriteLine("\nIngrese el número del slime al que desea atacar (1-4):");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        if (slimes[0] > 0)
                        {
                            slimes[0] -= 20;
                            Console.WriteLine($"Slime 1 ha sido atacado. Vida restante: {slimes[0]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 1 ya está derrotado.");
                        }
                        break;
                    case "2":
                        if (slimes[1] > 0)
                        {
                            slimes[1] -= 20;
                            Console.WriteLine($"Slime 2 ha sido atacado. Vida restante: {slimes[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 2 ya está derrotado.");
                        }
                        break;
                    case "3":
                        if (slimes[2] > 0)
                        {
                            slimes[2] -= 20;
                            Console.WriteLine($"Slime 3 ha sido atacado. Vida restante: {slimes[2]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 3 ya está derrotado.");
                        }
                        break;
                    case "4":
                        if (slimes[3] > 0)
                        {
                            slimes[3] -= 20;
                            Console.WriteLine($"Slime 4 ha sido atacado. Vida restante: {slimes[3]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 4 ya está derrotado.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4 - Canje de Recompensas");

            int[] precio = { 10, 25, 50, 80, 120 };

            int gemas;
            Console.Write("Ingrese la cantidad de gemas disponibles: ");
            gemas = int.TryParse(Console.ReadLine(), out int parsedGemas) ? parsedGemas : 0;

            int opcion;
            Console.WriteLine("1 - Mostrar cartas que puede pagar");
            Console.WriteLine("2 - Identificar la carta más cara del catálogo");
            opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nCartas que puede pagar:");

                    for (int i = 0; i < precio.Length; i++)
                    {
                        if (gemas >= precio[i])
                        {
                            Console.WriteLine($"Carta {i + 1}: {precio[i]} gemas");
                        }
                    }
                    break;

                case 2:
                    int mayor = precio[0];

                    for (int i = 1; i < precio.Length; i++)
                    {
                        if (precio[i] > mayor)
                        {
                            mayor = precio[i];
                        }
                    }

                    Console.WriteLine($"La carta más cara cuesta {mayor} gemas.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 5 - Registro y daño por rafaga");
            int[] danio = new int[6];
            for (int i = 0; i < danio.Length; i++)
            {
                Console.Write($"Ingrese el daño de la rafaga de flechas {i + 1}: ");
                danio[i] = int.TryParse(Console.ReadLine(), out int parsedDanio) ? parsedDanio : 0;
            }

            Console.WriteLine("\nIngrese el daño de referencia");
            int referenciaDanio = int.TryParse(Console.ReadLine(), out int parsedReferencia) ? parsedReferencia : 0;

            int posicion = 0;
            int danioTotal = 0;
            while (posicion < danio.Length)
            {
                if (danio[posicion] > referenciaDanio)
                {
                    Console.WriteLine($"Flecha {posicion + 1} supera el daño de referencia con un daño de {danio[posicion]}");
                    danioTotal += danio[posicion];
                }
                else
                {
                    Console.WriteLine($"Flecha {posicion + 1} no supera el daño de referencia con un daño de {danio[posicion]}");
                }
                posicion++;
            }

            Console.WriteLine($"El daño total es de {danioTotal}");
        }

        static void Ejercicio6()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 6 - Selector de elementos y cargas mágicas");

            string[] gemasTipo = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] gemas = new int[4];

            Console.WriteLine("Ingrese las cargas disponibles de cada gema:");
            for (int i = 0; i < gemas.Length; i++)
            {
                Console.Write($"Ingrese la cantidad de gemas de tipo {gemasTipo[i]}: ");
                gemas[i] = int.TryParse(Console.ReadLine(), out int parsedGemas) ? parsedGemas : 0;
            }
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1 - Recargar todas las gemas (+5)");
            Console.WriteLine("2 - Buscar gemas agotadas");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Recargando todas las gemas +5:");

                    for (int i = 0; i < gemas.Length; i++)
                    {
                        gemas[i] += 5;
                        Console.WriteLine($"{gemasTipo[i]}: {gemas[i]} cargas");
                    }
                    break;
                case "2":
                    Console.WriteLine("Buscar si hay gemas agotadas");
                    bool hayGemasAgotadas = false;
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (gemas[i] == 0)
                        {
                            Console.WriteLine($"No hay gemas de tipo {gemasTipo[i]} disponibles.");
                            hayGemasAgotadas = true;
                        }
                    }
                    if (!hayGemasAgotadas)
                    {
                        Console.WriteLine("Hay gemas disponibles de todos los tipos.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        static void Ejercicio7()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 7 - Detección de trampas en mazmorras");

            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool perdio = false;

            while (!perdio && posicion < 5)
            {
                posicion++;
                Console.WriteLine($"Avanzando a la baldosa {posicion}");
                if (trampas[posicion])
                {
                    Console.WriteLine("Trampa activada!");
                    perdio = true;
                }
                else
                {
                    Console.WriteLine("Baldosa segura");
                }
            }
            if (perdio)
            {
                Console.WriteLine("Has perdido el juego");
            }
            else
            {
                Console.WriteLine("Ganaste el juego");
            }
        }

        static void Ejercicio8()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 8 - Estadística de fases de boss");

            int[] danioRecibido = new int[3];
            for (int i = 0; i < danioRecibido.Length; i++)
            {
                Console.Write($"Ingrese el daño recibido en la fase {i + 1}: ");
                danioRecibido[i] = int.TryParse(Console.ReadLine(), out int parsedDanio) ? parsedDanio : 0;
            }

            Console.WriteLine("Ingrese la opcion que desea realizar:");
            Console.WriteLine("1. Ver promedio de daño recibido");
            Console.WriteLine("2. Identificar la fase más destructiva");
            int opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : 0;
            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    for (int i = 0; i < danioRecibido.Length; i++)
                    {
                        suma += danioRecibido[i];
                    }
                    double promedio = (double)suma / danioRecibido.Length;
                    Console.WriteLine($"El promedio de daño recibido es: {promedio}");
                    break;
                case 2:
                    int faseMasDestructiva = 0;
                    for (int i = 0; i < danioRecibido.Length; i++)
                    {
                        if (danioRecibido[i] > danioRecibido[faseMasDestructiva])
                        {
                            faseMasDestructiva = i;
                        }
                    }
                    Console.WriteLine($"La fase mas destructiva fue la {faseMasDestructiva + 1}");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;

            }
        }

        static void Ejercicio9()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 9 - Sistema de municion y disparo");
            int[] municion = { 30, 15, 8 };

            int opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("\nSeleccione un arma:");
                Console.WriteLine($"1. Rifle - {municion[0]} balas");
                Console.WriteLine($"2. Pistola - {municion[1]} balas");
                Console.WriteLine($"3. Escopeta - {municion[2]} balas");
                Console.WriteLine("0. Salir");

                opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : -1;

                switch (opcion)
                {
                    case 1:
                        if (municion[0] > 0)
                        {
                            municion[0]--;
                            Console.WriteLine($"Disparo con Rifle. Balas restantes: {municion[0]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en el Rifle.");
                        }
                        break;
                    case 2:
                        if (municion[1] > 0)
                        {
                            municion[1]--;
                            Console.WriteLine($"Disparo con Pistola. Balas restantes: {municion[1]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en la Pistola.");
                        }
                        break;
                    case 3:
                        if (municion[2] > 0)
                        {
                            municion[2]--;
                            Console.WriteLine($"Disparo con Escopeta. Balas restantes: {municion[2]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en la Escopeta.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }


        }

        static void Ejercicio10()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 10 - Bonificacion de XP");

            int[] experiencia = new int[5];
            int experienciaTotal = 0;
            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.Write($"Ingrese la experiencia obtenida en la misión {i + 1}: ");
                experiencia[i] = int.TryParse(Console.ReadLine(), out int parsedExperiencia) ? parsedExperiencia : 0;

                if (experiencia[i] > 100)
                {
                    experiencia[i] += (int)(experiencia[i] * 0.20);
                }
                else
                {
                    Console.WriteLine("No se aplica bonificación de XP para esta misión.");
                }
            }
            Console.WriteLine("\nExperiencia obtenida en cada misión:");
            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.WriteLine($"Misión {i + 1}: {experiencia[i]} XP");
                experienciaTotal += experiencia[i];
            }
            Console.WriteLine($"\nExperiencia total acumulada: {experienciaTotal} EXP");
        }

    }
}
=======
﻿using System;
// Trabajo Práctico 2 - TUDPV
// Alumno: Rahman Rintoul Ramiro
// Legajo: 67050
namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string? opcion = "";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("====== Elegir un Ejercicio a continuación ======");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 1 Durabilidad de armas");
                Console.WriteLine("2. Ejercicio 2 Top 5 Speedrun");
                Console.WriteLine("3. Ejercicio 3 Combate de Slimes");
                Console.WriteLine("4. Ejercicio 4 Canje de Recompensas");
                Console.WriteLine("5. Ejercicio 5 Daño por rafaga");
                Console.WriteLine("6. Ejercicio 6 Cargas mágicas");
                Console.WriteLine("7. Ejercicio 7 Baldosas trampas en mazmorra");
                Console.WriteLine("8. Ejercicio 8 Fases de boss");
                Console.WriteLine("9. Ejercicio 9 Sistema de municion y disparo");
                Console.WriteLine("10. Ejercicio 10 Asignador de experiencia");
                Console.WriteLine("===============================================");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Ejercicio1();
                        break;

                    case "2":
                        Ejercicio2();
                        break;

                    case "3":
                        Ejercicio3();
                        break;

                    case "4":
                        Ejercicio4();
                        break;

                    case "5":
                        Ejercicio5();
                        break;

                    case "6":
                        Ejercicio6();
                        break;

                    case "7":
                        Ejercicio7();
                        break;

                    case "8":
                        Ejercicio8();
                        break;

                    case "9":
                        Ejercicio9();
                        break;

                    case "10":
                        Ejercicio10();
                        break;

                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 1 - Durabilidad de armas");
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            for (int i = 0; i < durabilidad.Length; i++)
            {
                Console.Write($"Ingrese la durabilidad del arma {armas[i]}: ");
                int.TryParse(Console.ReadLine(), out durabilidad[i]);
            }
            Console.WriteLine("\nIngrese la opción que desea realizar:");
            Console.WriteLine("1. Inspecionar armas críticas");
            Console.WriteLine("2. Ver arsenal completo");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nArmas críticas:");
                    for (int i = 0; i < durabilidad.Length; i++)
                    {
                        if (durabilidad[i] < 20)
                        {
                            Console.WriteLine($"{armas[i]} - Durabilidad: {durabilidad[i]}");
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("\nArsenal completo:");
                    for (int i = 0; i < durabilidad.Length; i++)
                    {
                        Console.WriteLine($"{armas[i]} - Durabilidad: {durabilidad[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }

        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2 - Speedrun");

            float[] tiempos = new float[5];

            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write($"Ingrese el tiempo del corredor {i + 1} (en segundos): ");
                float.TryParse(Console.ReadLine(), out tiempos[i]);
            }

            float tiempoObjetivo = -1;

            while (tiempoObjetivo != 0)
            {
                Console.WriteLine("\nIngrese 0 para volver al menú.");
                Console.Write("Ingrese un tiempo objetivo para clasificar: ");


                float.TryParse(Console.ReadLine(), out tiempoObjetivo);

                if (tiempoObjetivo != 0)
                {
                    int clasificados = 0;

                    for (int i = 0; i < tiempos.Length; i++)
                    {
                        if (tiempos[i] <= tiempoObjetivo)
                        {
                            Console.WriteLine(
                                $"Corredor {i + 1}: {tiempos[i]} segundos - Clasificado"
                            );

                            clasificados++;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Corredor {i + 1}: {tiempos[i]} segundos - No clasificado"
                            );
                        }
                    }

                    Console.WriteLine(
                        $"\nCantidad de corredores que superaron la prueba: {clasificados}"
                    );
                }
            }
        }

        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3 - Combate de Slimes");
            int[] slimes = { 30, 40, 50, 60 };

            while (slimes.Any(vida => vida > 0))
            {
                string? opcion;
                Console.WriteLine("\nIngrese el número del slime al que desea atacar (1-4):");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        if (slimes[0] > 0)
                        {
                            slimes[0] -= 20;
                            Console.WriteLine($"Slime 1 ha sido atacado. Vida restante: {slimes[0]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 1 ya está derrotado.");
                        }
                        break;
                    case "2":
                        if (slimes[1] > 0)
                        {
                            slimes[1] -= 20;
                            Console.WriteLine($"Slime 2 ha sido atacado. Vida restante: {slimes[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 2 ya está derrotado.");
                        }
                        break;
                    case "3":
                        if (slimes[2] > 0)
                        {
                            slimes[2] -= 20;
                            Console.WriteLine($"Slime 3 ha sido atacado. Vida restante: {slimes[2]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 3 ya está derrotado.");
                        }
                        break;
                    case "4":
                        if (slimes[3] > 0)
                        {
                            slimes[3] -= 20;
                            Console.WriteLine($"Slime 4 ha sido atacado. Vida restante: {slimes[3]}");
                        }
                        else
                        {
                            Console.WriteLine("Slime 4 ya está derrotado.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 4 - Canje de Recompensas");

            int[] precio = { 10, 25, 50, 80, 120 };

            int gemas;
            Console.Write("Ingrese la cantidad de gemas disponibles: ");
            gemas = int.TryParse(Console.ReadLine(), out int parsedGemas) ? parsedGemas : 0;

            int opcion;
            Console.WriteLine("1 - Mostrar cartas que puede pagar");
            Console.WriteLine("2 - Identificar la carta más cara del catálogo");
            opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : 0;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nCartas que puede pagar:");

                    for (int i = 0; i < precio.Length; i++)
                    {
                        if (gemas >= precio[i])
                        {
                            Console.WriteLine($"Carta {i + 1}: {precio[i]} gemas");
                        }
                    }
                    break;

                case 2:
                    int mayor = precio[0];

                    for (int i = 1; i < precio.Length; i++)
                    {
                        if (precio[i] > mayor)
                        {
                            mayor = precio[i];
                        }
                    }

                    Console.WriteLine($"La carta más cara cuesta {mayor} gemas.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 5 - Registro y daño por rafaga");
            int[] danio = new int[6];
            for (int i = 0; i < danio.Length; i++)
            {
                Console.Write($"Ingrese el daño de la rafaga de flechas {i + 1}: ");
                danio[i] = int.TryParse(Console.ReadLine(), out int parsedDanio) ? parsedDanio : 0;
            }

            Console.WriteLine("\nIngrese el daño de referencia");
            int referenciaDanio = int.TryParse(Console.ReadLine(), out int parsedReferencia) ? parsedReferencia : 0;

            int posicion = 0;
            int danioTotal = 0;
            while (posicion < danio.Length)
            {
                if (danio[posicion] > referenciaDanio)
                {
                    Console.WriteLine($"Flecha {posicion + 1} supera el daño de referencia con un daño de {danio[posicion]}");
                    danioTotal += danio[posicion];
                }
                else
                {
                    Console.WriteLine($"Flecha {posicion + 1} no supera el daño de referencia con un daño de {danio[posicion]}");
                }
                posicion++;
            }

            Console.WriteLine($"El daño total es de {danioTotal}");
        }

        static void Ejercicio6()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 6 - Selector de elementos y cargas mágicas");

            string[] gemasTipo = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] gemas = new int[4];

            Console.WriteLine("Ingrese las cargas disponibles de cada gema:");
            for (int i = 0; i < gemas.Length; i++)
            {
                Console.Write($"Ingrese la cantidad de gemas de tipo {gemasTipo[i]}: ");
                gemas[i] = int.TryParse(Console.ReadLine(), out int parsedGemas) ? parsedGemas : 0;
            }
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1 - Recargar todas las gemas (+5)");
            Console.WriteLine("2 - Buscar gemas agotadas");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Recargando todas las gemas +5:");

                    for (int i = 0; i < gemas.Length; i++)
                    {
                        gemas[i] += 5;
                        Console.WriteLine($"{gemasTipo[i]}: {gemas[i]} cargas");
                    }
                    break;
                case "2":
                    Console.WriteLine("Buscar si hay gemas agotadas");
                    bool hayGemasAgotadas = false;
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (gemas[i] == 0)
                        {
                            Console.WriteLine($"No hay gemas de tipo {gemasTipo[i]} disponibles.");
                            hayGemasAgotadas = true;
                        }
                    }
                    if (!hayGemasAgotadas)
                    {
                        Console.WriteLine("Hay gemas disponibles de todos los tipos.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        static void Ejercicio7()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 7 - Detección de trampas en mazmorras");

            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool perdio = false;

            while (!perdio && posicion < 5)
            {
                posicion++;
                Console.WriteLine($"Avanzando a la baldosa {posicion}");
                if (trampas[posicion])
                {
                    Console.WriteLine("Trampa activada!");
                    perdio = true;
                }
                else
                {
                    Console.WriteLine("Baldosa segura");
                }
            }
            if (perdio)
            {
                Console.WriteLine("Has perdido el juego");
            }
            else
            {
                Console.WriteLine("Ganaste el juego");
            }
        }

        static void Ejercicio8()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 8 - Estadística de fases de boss");

            int[] danioRecibido = new int[3];
            for (int i = 0; i < danioRecibido.Length; i++)
            {
                Console.Write($"Ingrese el daño recibido en la fase {i + 1}: ");
                danioRecibido[i] = int.TryParse(Console.ReadLine(), out int parsedDanio) ? parsedDanio : 0;
            }

            Console.WriteLine("Ingrese la opcion que desea realizar:");
            Console.WriteLine("1. Ver promedio de daño recibido");
            Console.WriteLine("2. Identificar la fase más destructiva");
            int opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : 0;
            switch (opcion)
            {
                case 1:
                    int suma = 0;
                    for (int i = 0; i < danioRecibido.Length; i++)
                    {
                        suma += danioRecibido[i];
                    }
                    double promedio = (double)suma / danioRecibido.Length;
                    Console.WriteLine($"El promedio de daño recibido es: {promedio}");
                    break;
                case 2:
                    int faseMasDestructiva = 0;
                    for (int i = 0; i < danioRecibido.Length; i++)
                    {
                        if (danioRecibido[i] > danioRecibido[faseMasDestructiva])
                        {
                            faseMasDestructiva = i;
                        }
                    }
                    Console.WriteLine($"La fase mas destructiva fue la {faseMasDestructiva + 1}");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;

            }
        }

        static void Ejercicio9()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 9 - Sistema de municion y disparo");
            int[] municion = { 30, 15, 8 };

            int opcion = -1;
            while (opcion != 0)
            {
                Console.WriteLine("\nSeleccione un arma:");
                Console.WriteLine($"1. Rifle - {municion[0]} balas");
                Console.WriteLine($"2. Pistola - {municion[1]} balas");
                Console.WriteLine($"3. Escopeta - {municion[2]} balas");
                Console.WriteLine("0. Salir");

                opcion = int.TryParse(Console.ReadLine(), out int parsedOpcion) ? parsedOpcion : -1;

                switch (opcion)
                {
                    case 1:
                        if (municion[0] > 0)
                        {
                            municion[0]--;
                            Console.WriteLine($"Disparo con Rifle. Balas restantes: {municion[0]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en el Rifle.");
                        }
                        break;
                    case 2:
                        if (municion[1] > 0)
                        {
                            municion[1]--;
                            Console.WriteLine($"Disparo con Pistola. Balas restantes: {municion[1]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en la Pistola.");
                        }
                        break;
                    case 3:
                        if (municion[2] > 0)
                        {
                            municion[2]--;
                            Console.WriteLine($"Disparo con Escopeta. Balas restantes: {municion[2]}");
                        }
                        else
                        {
                            Console.WriteLine("No hay balas en la Escopeta.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }


        }

        static void Ejercicio10()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 10 - Bonificacion de XP");

            int[] experiencia = new int[5];
            int experienciaTotal = 0;
            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.Write($"Ingrese la experiencia obtenida en la misión {i + 1}: ");
                experiencia[i] = int.TryParse(Console.ReadLine(), out int parsedExperiencia) ? parsedExperiencia : 0;

                if (experiencia[i] > 100)
                {
                    experiencia[i] += (int)(experiencia[i] * 0.20);
                }
                else
                {
                    Console.WriteLine("No se aplica bonificación de XP para esta misión.");
                }
            }
            Console.WriteLine("\nExperiencia obtenida en cada misión:");
            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.WriteLine($"Misión {i + 1}: {experiencia[i]} XP");
                experienciaTotal += experiencia[i];
            }
            Console.WriteLine($"\nExperiencia total acumulada: {experienciaTotal} EXP");
        }

    }
}
>>>>>>> b522946e173735387b48d7ff8fe679d3ecd03afb

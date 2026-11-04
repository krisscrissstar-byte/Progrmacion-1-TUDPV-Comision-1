using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];

        Console.WriteLine("=== REGISTRO DE CARGAS MÁGICAS ===");

        for (int i = 0; i < gemas.Length; i++)
        {
            Console.Write($"Ingrese las cargas para la gema de {gemas[i]}: ");
            int.TryParse(Console.ReadLine(), out cargas[i]);
        }

        Console.WriteLine("\n=== MENÚ DE OPCIONES ===");
        Console.WriteLine("1: Recargar todas (+5 cargas)");
        Console.WriteLine("2: Buscar si hay alguna gema agotada (0 cargas)");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n--- Recargando gemas (+5 cargas) ---");
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        cargas[i] += 5;
                        Console.WriteLine($"Gema de {gemas[i]}: {cargas[i]} cargas actuales.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Búsqueda de gemas agotadas ---");
                    bool hayAgotadas = false;

                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine($"¡La gema de {gemas[i]} está agotada!");
                            hayAgotadas = true;
                        }
                    }

                    if (!hayAgotadas)
                    {
                        Console.WriteLine("Ninguna gema está agotada.");
                    }
                    break;

                default:
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }
        }

        Console.ReadKey();
    }
}
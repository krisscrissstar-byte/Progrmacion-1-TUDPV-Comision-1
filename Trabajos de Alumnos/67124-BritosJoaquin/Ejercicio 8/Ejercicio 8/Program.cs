using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] danioFases = new int[3];

        Console.WriteLine("=== REGISTRO DE DAÑO DEL BOSS ===");

        for (int i = 0; i < danioFases.Length; i++)
        {
            Console.Write($"Ingrese el daño recibido en la Fase {i + 1}: ");
            int.TryParse(Console.ReadLine(), out danioFases[i]);
        }

        Console.WriteLine("\n=== MENÚ DE OPCIONES ===");
        Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
        Console.WriteLine("2: Identificar la fase más destructiva");
        Console.Write("Seleccione una opción: ");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            switch (opcion)
            {
                case 1:
                    float promedio = (danioFases[0] + danioFases[1] + danioFases[2]) / 3f;
                    Console.WriteLine($"\nEl promedio de daño fue: {promedio}");
                    break;

                case 2:
                    int mayorDanio = danioFases[0];
                    int faseMasDestructiva = 1;

                    if (danioFases[1] > mayorDanio)
                    {
                        mayorDanio = danioFases[1];
                        faseMasDestructiva = 2;
                    }

                    if (danioFases[2] > mayorDanio)
                    {
                        mayorDanio = danioFases[2];
                        faseMasDestructiva = 3;
                    }

                    Console.WriteLine($"\nLa fase más destructiva fue la Fase {faseMasDestructiva} con {mayorDanio} de daño.");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }
        }

        Console.ReadKey();
    }
}
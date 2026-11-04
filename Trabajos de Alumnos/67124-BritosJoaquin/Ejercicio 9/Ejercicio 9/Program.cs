using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] municion = { 30, 15, 8 };
        int opcion = -1;

        Console.WriteLine("=== SISTEMA DE MUNICIÓN Y DISPARO ===");

        while (opcion != 0)
        {
            Console.WriteLine($"\nBALAS: Rifle [1]: {municion[0]} | Pistola [2]: {municion[1]} | Escopeta [3]: {municion[2]}");
            Console.Write("Seleccione arma a disparar (1: Rifle, 2: Pistola, 3: Escopeta, 0: Salir): ");
            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    if (municion[0] > 0)
                    {
                        municion[0]--;
                        Console.WriteLine("¡PUM! Has disparado el Rifle.");
                    }
                    else
                    {
                        Console.WriteLine("¡Sin balas en el Rifle!");
                    }
                    break;

                case 2:
                    if (municion[1] > 0)
                    {
                        municion[1]--;
                        Console.WriteLine("¡PUM! Has disparado la Pistola.");
                    }
                    else
                    {
                        Console.WriteLine("¡Sin balas en la Pistola!");
                    }
                    break;

                case 3:
                    if (municion[2] > 0)
                    {
                        municion[2]--;
                        Console.WriteLine("¡PUM! Has disparado la Escopeta.");
                    }
                    else
                    {
                        Console.WriteLine("¡Sin balas en la Escopeta!");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del sistema de disparo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        Console.ReadKey();
    }
}
using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };

            int[] cargas = new int[4];

            // Cargar las cargas de cada gema
            for (int i = 0; i < gemas.Length; i++)
            {
                Console.Write("Ingrese las cargas de " + gemas[i] + ": ");
                cargas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n1 - Recargar todas las gemas");
            Console.WriteLine("2 - Buscar gemas agotadas");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    for (int i = 0; i < cargas.Length; i++)
                    {
                        cargas[i] += 5;
                    }

                    Console.WriteLine("\nGemas recargadas:");

                    for (int i = 0; i < gemas.Length; i++)
                    {
                        Console.WriteLine(gemas[i] + " - Cargas: " + cargas[i]);
                    }

                    break;

                case 2:

                    bool hayAgotadas = false;

                    for (int i = 0; i < cargas.Length; i++)
                    {
                        if (cargas[i] == 0)
                        {
                            Console.WriteLine(
                                gemas[i] + " está agotada.");

                            hayAgotadas = true;
                        }
                    }

                    if (hayAgotadas == false)
                    {
                        Console.WriteLine("No hay gemas agotadas.");
                    }

                    break;

                default:

                    Console.WriteLine("Opción inválida.");

                    break;
            }
        }
    }
}
using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] slimes = { 30, 40, 50, 60 };

            while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
            {
                Console.WriteLine("\nVida de los Slimes:");
                Console.WriteLine("Slime 0: " + slimes[0] + " HP");
                Console.WriteLine("Slime 1: " + slimes[1] + " HP");
                Console.WriteLine("Slime 2: " + slimes[2] + " HP");
                Console.WriteLine("Slime 3: " + slimes[3] + " HP");

                Console.Write("\nElige un slime para atacar (0-3): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        if (slimes[0] <= 0)
                        {
                            Console.WriteLine("El Slime 0 ya fue derrotado.");
                        }
                        else
                        {
                            slimes[0] -= 20;
                            Console.WriteLine("Atacaste al Slime 0.");
                        }
                        break;

                    case 1:
                        if (slimes[1] <= 0)
                        {
                            Console.WriteLine("El Slime 1 ya fue derrotado.");
                        }
                        else
                        {
                            slimes[1] -= 20;
                            Console.WriteLine("Atacaste al Slime 1.");
                        }
                        break;

                    case 2:
                        if (slimes[2] <= 0)
                        {
                            Console.WriteLine("El Slime 2 ya fue derrotado.");
                        }
                        else
                        {
                            slimes[2] -= 20;
                            Console.WriteLine("Atacaste al Slime 2.");
                        }
                        break;

                    case 3:
                        if (slimes[3] <= 0)
                        {
                            Console.WriteLine("El Slime 3 ya fue derrotado.");
                        }
                        else
                        {
                            slimes[3] -= 20;
                            Console.WriteLine("Atacaste al Slime 3.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Elige un número entre 0 y 3.");
                        break;
                }
            }

            Console.WriteLine("\n¡Todos los Slimes fueron derrotados!");
        }
    }
}
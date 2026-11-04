using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] municion = { 30, 15, 8 };

            while (true)
            {
                Console.WriteLine("\nMunición disponible:");
                Console.WriteLine("Rifle: " + municion[0]);
                Console.WriteLine("Pistola: " + municion[1]);
                Console.WriteLine("Escopeta: " + municion[2]);

                Console.WriteLine("\n1 - Rifle");
                Console.WriteLine("2 - Pistola");
                Console.WriteLine("3 - Escopeta");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione un arma: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:

                        if (municion[0] > 0)
                        {
                            municion[0]--;
                            Console.WriteLine("Disparo realizado con el Rifle.");
                        }
                        else
                        {
                            Console.WriteLine("El Rifle está vacío.");
                        }

                        break;

                    case 2:

                        if (municion[1] > 0)
                        {
                            municion[1]--;
                            Console.WriteLine("Disparo realizado con la Pistola.");
                        }
                        else
                        {
                            Console.WriteLine("La Pistola está vacía.");
                        }

                        break;

                    case 3:

                        if (municion[2] > 0)
                        {
                            municion[2]--;
                            Console.WriteLine("Disparo realizado con la Escopeta.");
                        }
                        else
                        {
                            Console.WriteLine("La Escopeta está vacía.");
                        }

                        break;

                    default:

                        Console.WriteLine("Opción inválida.");

                        break;
                }
            }

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
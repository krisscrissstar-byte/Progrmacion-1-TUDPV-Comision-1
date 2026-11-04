using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] daños = new int[3];

            // Cargar el daño de las 3 fases
            for (int i = 0; i < daños.Length; i++)
            {
                Console.Write("Ingrese el daño recibido en la fase " + (i + 1) + ": ");
                daños[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n1 - Calcular promedio de daño");
            Console.WriteLine("2 - Identificar la fase más destructiva");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    int total = 0;

                    for (int i = 0; i < daños.Length; i++)
                    {
                        total += daños[i];
                    }

                    double promedio = (double)total / daños.Length;

                    Console.WriteLine("\nPromedio de daño: " + promedio);

                    break;

                case 2:

                    int mayor = daños[0];
                    int faseMayor = 1;

                    if (daños[1] > mayor)
                    {
                        mayor = daños[1];
                        faseMayor = 2;
                    }

                    if (daños[2] > mayor)
                    {
                        mayor = daños[2];
                        faseMayor = 3;
                    }

                    Console.WriteLine("\nLa fase más destructiva fue la fase "
                        + faseMayor + " con " + mayor + " de daño.");

                    break;

                default:

                    Console.WriteLine("Opción inválida.");

                    break;
            }
        }
    }
}
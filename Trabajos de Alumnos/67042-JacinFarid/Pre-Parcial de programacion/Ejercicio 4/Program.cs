using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] costos = { 10, 25, 50, 80, 120 };

            Console.Write("Ingrese la cantidad de gemas que tiene: ");
            int gemas = int.Parse(Console.ReadLine());

            Console.WriteLine("\n1 - Mostrar cartas que puede pagar");
            Console.WriteLine("2 - Identificar la carta más cara");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("\nCartas que puede pagar:");

                    for (int i = 0; i < costos.Length; i++)
                    {
                        if (gemas >= costos[i])
                        {
                            Console.WriteLine("Carta " + (i + 1) +
                                " - Costo: " + costos[i] + " gemas");
                        }
                        else
                        {
                            Console.WriteLine("Carta " + (i + 1) +
                                " - No puede pagarla.");
                        }
                    }

                    break;

                case 2:

                    int cartaMasCara = costos[0];

                    for (int i = 1; i < costos.Length; i++)
                    {
                        if (costos[i] > cartaMasCara)
                        {
                            cartaMasCara = costos[i];
                        }
                    }

                    Console.WriteLine("\nLa carta más cara cuesta: "
                        + cartaMasCara + " gemas.");

                    break;

                default:

                    Console.WriteLine("Opción inválida.");

                    break;
            }
        }
    }
}

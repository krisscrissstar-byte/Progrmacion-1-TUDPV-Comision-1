using System;

namespace Ejercicio04;

class Ejercicio04
{
    static void Main()
    {
        int[] costos = { 10, 25, 50, 80, 120 };

        Console.Write("Ingrese la cantidad de gemas que tiene: ");
        int gemas = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("1 - Mostrar cartas que puede pagar");
        Console.WriteLine("2 - Mostrar la carta más cara");
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Cartas que puede pagar: ");
                Console.WriteLine();

                for (int i = 0; i < costos.Length; i++)
                {
                    if (gemas >= costos[i])
                    {
                        Console.WriteLine("Carta " + i + " - Costo: " + costos[i] + " gemas");
                    }
                }
                break;

            case 2:
                int mayor = costos[0];
                for (int i = 1; i < costos.Length; i++)
                {
                    if (costos[i] > mayor)
                    {
                        mayor = costos[i];
                    }
                }
                Console.WriteLine("La carta más cara cuesta " + mayor + " gemas.");

                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}
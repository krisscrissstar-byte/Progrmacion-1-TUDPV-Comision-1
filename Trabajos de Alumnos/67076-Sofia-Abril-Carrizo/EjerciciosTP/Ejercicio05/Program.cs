using System;

namespace Ejercicio05;

class Ejercicio05
{
    static void Main()
    {
        int[] dañoflecha = new int[6];

        for (int i = 0; i < dañoflecha.Length; i++)
        {
            Console.WriteLine("Ingrese el daño de la flecha " + (i + 1) + ": ");
            dañoflecha[i] = int.Parse(Console.ReadLine());
        }

        bool continuar = true;

        while (continuar)
        {
            Console.Write("Ingrese un daño de referencia (0 para salir): ");
            Console.WriteLine();
            int referencia = int.Parse(Console.ReadLine());

            if (referencia == 0)
            {
                continuar = false;
            }
            else
            {
                int total = 0;

                for (int i = 0; i < dañoflecha.Length; i++)
                {
                    if (dañoflecha[i] > referencia)
                    {
                        total += dañoflecha[i];
                    }
                }
                Console.WriteLine("Daño total filtrado: " + total);
            }
        }
        Console.WriteLine("Programa finalizado.");
    }
}

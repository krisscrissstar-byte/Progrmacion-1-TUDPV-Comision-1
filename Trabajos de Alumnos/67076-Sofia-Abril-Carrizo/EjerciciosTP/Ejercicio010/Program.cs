using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio010;

class Ejercicio010
{
    static void Main()
    {
        int[] exp = new int[5];

        for (int i = 0; i < exp.Length; i++)
        {
            Console.Write("Ingrese la EXP de la misión " + (i + 1) + ": ");
            exp[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] > 100)
            {
                exp[i] = exp[i] + (exp[i] * 20 / 100);
            }
        }

        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine(">>>>> EXP de las misiones <<<<<");
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

        int total = 0;

        for (int i = 0; i < exp.Length; i++)
        {
            Console.WriteLine("Misión " + (i + 1) + ": " + exp[i] + " EXP");

            total += exp[i];
        }

        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Experiencia total acumulada: " + total);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

    }
}

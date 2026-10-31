using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] experiencia = new int[5];

            // Cargar la experiencia de las 5 misiones
            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.Write("Ingrese la EXP de la misión " + (i + 1) + ": ");
                experiencia[i] = int.Parse(Console.ReadLine());
            }

            // Aplicar bono del 20% a las misiones que superen 100 EXP
            for (int i = 0; i < experiencia.Length; i++)
            {
                if (experiencia[i] > 100)
                {
                    experiencia[i] = (int)(experiencia[i] * 1.20);
                }
            }

            // Mostrar la tabla actualizada
            Console.WriteLine("\nExperiencia actualizada:");

            for (int i = 0; i < experiencia.Length; i++)
            {
                Console.WriteLine("Misión " + (i + 1) + ": " + experiencia[i] + " EXP");
            }

            // Calcular la experiencia total
            int total = 0;

            for (int i = 0; i < experiencia.Length; i++)
            {
                total += experiencia[i];
            }

            Console.WriteLine("\nExperiencia total acumulada: " + total + " EXP");
        }
    }
}
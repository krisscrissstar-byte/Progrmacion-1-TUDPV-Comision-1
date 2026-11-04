using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] tiempos = new float[5];

            // Cargar los tiempos de los 5 corredores
            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write("Ingrese el tiempo del corredor " + (i + 1) + ": ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            int continuar = 1;

            // Permitir ingresar diferentes tiempos objetivo
            while (continuar == 1)
            {
                Console.Write("\nIngrese el tiempo objetivo: ");
                float objetivo = float.Parse(Console.ReadLine());

                int cantidad = 0;

                for (int i = 0; i < tiempos.Length; i++)
                {
                    if (tiempos[i] <= objetivo)
                    {
                        cantidad++;
                    }
                    else
                    {
                        // No logró la marca.
                    }
                }

                Console.WriteLine("Corredores que lograron la marca: " + cantidad);

                Console.Write("¿Desea ingresar otro tiempo objetivo? (1 = Si / 0 = No): ");
                continuar = int.Parse(Console.ReadLine());
            }
        }
    }
}
using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] daños = new int[6];

            // Cargar el daño de las 6 flechas
            for (int i = 0; i < daños.Length; i++)
            {
                Console.Write("Ingrese el daño de la flecha " + (i + 1) + ": ");
                daños[i] = int.Parse(Console.ReadLine());
            }

            int continuar = 1;

            while (continuar == 1)
            {
                Console.Write("\nIngrese un daño de referencia (0 para salir): ");
                int referencia = int.Parse(Console.ReadLine());

                if (referencia == 0)
                {
                    continuar = 0;
                }
                else
                {
                    int totalFiltrado = 0;

                    for (int i = 0; i < daños.Length; i++)
                    {
                        if (daños[i] > referencia)
                        {
                            totalFiltrado += daños[i];

                            Console.WriteLine(
                                "Impacto filtrado: " + daños[i]);
                        }
                        else
                        {
                            Console.WriteLine(
                                "Impacto no filtrado: " + daños[i]);
                        }
                    }

                    Console.WriteLine(
                        "Total de daño filtrado: " + totalFiltrado);
                }
            }

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
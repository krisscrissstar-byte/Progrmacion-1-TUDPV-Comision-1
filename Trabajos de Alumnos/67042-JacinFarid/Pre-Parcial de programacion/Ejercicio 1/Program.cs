using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };

            int[] durabilidad = new int[4];

            for (int i = 0; i < armas.Length; i++)
            {
                Console.Write("Ingrese la durabilidad de " + armas[i] + ": ");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n1 - Inspeccionar armas críticas");
            Console.WriteLine("2 - Ver arsenal completo");
            Console.Write("Seleccione una opción: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine("ALERTA: " + armas[i] +
                                " tiene durabilidad crítica: " + durabilidad[i]);
                        }
                        else
                        {
                            Console.WriteLine(armas[i] +
                                " está en condiciones normales.");
                        }
                    }

                    break;

                case 2:

                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine(armas[i] +
                            " - Durabilidad: " + durabilidad[i]);
                    }

                    break;

                default:

                    Console.WriteLine("Opción inválida.");

                    break;
            }
        }
    }
}
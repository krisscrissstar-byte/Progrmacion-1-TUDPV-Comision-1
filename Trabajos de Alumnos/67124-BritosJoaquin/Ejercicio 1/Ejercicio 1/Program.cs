using System;

namespace Programacion1_TUDPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
            int[] durabilidad = new int[4];

            for (int i = 0; i < armas.Length; i++)
            {
                Console.Write($"Ingrese la durabilidad para {armas[i]}: ");
                durabilidad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMenú:");
            Console.WriteLine("1: Inspeccionar armas críticas");
            Console.WriteLine("2: Ver arsenal completo");
            Console.Write("Seleccione opción: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("\n--- ALERTA: Armas Críticas (Durabilidad <= 20) ---");
                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 20)
                        {
                            Console.WriteLine($"⚠️ {armas[i]} en estado crítico con {durabilidad[i]} HP.");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("\n--- ARSENAL COMPLETO ---");
                    for (int i = 0; i < armas.Length; i++)
                    {
                        Console.WriteLine($"{armas[i]}: {durabilidad[i]} HP");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
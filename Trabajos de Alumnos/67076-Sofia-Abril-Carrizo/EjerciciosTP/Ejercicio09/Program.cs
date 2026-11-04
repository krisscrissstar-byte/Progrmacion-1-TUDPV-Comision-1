using System;

namespace Ejercicio09;

class Ejercicio09
{
    static void Main()
    {
        String[] armas = { "Rifle", "Pistola", "Escopeta" };
        int[] municion = { 30, 15, 8 };

        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("------- Munición ------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Rifle: " + municion[0]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Pistola: " + municion[1]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Escopeta: " + municion[2]);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("1 - Rifle");
            Console.WriteLine("2 - Pistolas");
            Console.WriteLine("3 - Escopeta");
            Console.WriteLine("0 - Salir");
            Console.WriteLine();
            
            Console.WriteLine("----------------------------");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                case 2:
                case 3:
                    int indice = opcion - 1;

                    if (municion[indice] > 0)
                    {
                        municion[indice]--;
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("¡Disparon realizado con " + armas[indice] + "!");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("La munición de " + armas[indice] + " está vacía.");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                        break;
                case 0:
                    Console.WriteLine("Fin del programa.");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("xxx--------------------------xxx");
                    Console.WriteLine("        Opción incorrecta.");
                    Console.WriteLine("xxx--------------------------xxx");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
            }
        }
    }
}

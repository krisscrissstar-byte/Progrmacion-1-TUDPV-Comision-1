using System;

namespace Ejercicios01;

class Ejercicio01
{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[4];

        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine("Ingrese el valor de " + armas[i] + ": ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("《《《 O p c i o n e s 》》》");
        Console.WriteLine("1: Inspeccionar armas criticas.");
        Console.WriteLine();
        Console.WriteLine("2. Ver arsenal completo.");
        Console.WriteLine();
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine(" 《Armas criticas》");
                for (int i = 0; i < armas.Length; i++)
                {
                    if (durabilidad[i] < 20)
                    {
                        Console.WriteLine(">>>" + armas[i] + " - " + durabilidad[i] + " ARMA CRITICA");
                    }
                }
                break;
            case 2:
                Console.WriteLine("ARSENA");
                Console.WriteLine("ARMAS      |  DURABILIDAD");
                for (int i = 0; i < armas.Length; i++)
                {
                    Console.WriteLine(armas[i] + "...." + durabilidad[i]);
                }
                break;
            default:
                Console.WriteLine("ERROR: Opcion no validad");
                break;
        }
    }
}
using System;

namespace Ejercicio06;

class Ejercicio06
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargar = new int[4];

        for (int i = 0; i < gemas.Length; i++)
        {
            Console.Write("Ingrese las cargas de " + gemas[i] + ": ");
            cargar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("1 - Recargar todas las gemas");
        Console.WriteLine();
        Console.WriteLine("2 - Buscar gemas agotadas");
        Console.WriteLine();
        Console.Write("Opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                for (int i = 0; i < cargar.Length; i++ )
                {
                    cargar[i] += 5;
                }

                Console.WriteLine("> Todas las gemas fueron recargadas. ");
                Console.WriteLine();

                for (int i = 0; i < gemas.Length; i++)
                {
                    Console.WriteLine(">>>> " + gemas[i] + ": " + cargar[i] + " cargas");
                }
                break;
            case 2:
                Console.WriteLine("> Gemas agotadas: ");

                for (int i= 0; i < cargar.Length; i++)
                {
                    if (cargar[i] == 0)
                    {
                        Console.WriteLine(">>>> " + gemas[i]);
                    }
                }
                break;
            default:
                Console.WriteLine("Opcion incorrecta.");
                break;
        }    
    }
}

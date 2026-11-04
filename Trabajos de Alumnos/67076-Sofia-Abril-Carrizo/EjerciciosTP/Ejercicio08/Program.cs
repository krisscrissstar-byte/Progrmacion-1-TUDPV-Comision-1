using System;

namespace Ejercicio08;

class Ejercicio08
{
    static void Main()
    {
        int[] dañofase = new int[3];

        for (int i = 0; i < dañofase.Length; i++)
        {
            Console.Write("Ingrese el daño recibido en la fase " + (i + 1) + ": ");
            dañofase[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("1 - Calcular promedio.");
        Console.WriteLine();
        Console.WriteLine("2 - Identificar fase más destructiva.");
        Console.WriteLine();
        Console.Write("Opción: ");
        Console.WriteLine();

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int suma = 0;

                for (int i = 0; i < dañofase.Length; i++)
                {
                    suma += dañofase[i];
                }

                int promedio = suma / dañofase.Length;

                Console.WriteLine("Promedio de daño: " + promedio);

                break;
            case 2:
                int mayor = dañofase[0];
                int fase = 0;

                for (int i = 0; i < dañofase.Length; i++)
                {
                    if (dañofase[i] > mayor)
                    {
                        mayor = dañofase[i];
                        fase = 1;
                    }
                }

                Console.WriteLine("La fase con mayor daño fue la fase " + (fase + 1));
                Console.WriteLine("Daño recibido: " + mayor);
                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}
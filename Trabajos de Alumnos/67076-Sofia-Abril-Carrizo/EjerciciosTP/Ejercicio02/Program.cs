using System;

namespace Ejercicio02;

class Ejercicio02
{
    static void Main()
    {
        float[] tiempos = new float[5];

        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write("Ingrese el tiempo del corredor " + (i + 1) + ": ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese un tiempo objetivo (0 para salir): ");
            float objetivo = float.Parse(Console.ReadLine());

            if (objetivo == 0)
            {
                continuar = false;
            }
            else
            {
                int cantidad = 0;

                for (int i = 0; i < tiempos.Length; i++)
                {
                    if (tiempos[i] >= objetivo)
                    {
                        cantidad++;
                    }
                }

                Console.WriteLine("Cantidad de corredores que superaron la prueba: " + cantidad);
            }
        }
    }
}
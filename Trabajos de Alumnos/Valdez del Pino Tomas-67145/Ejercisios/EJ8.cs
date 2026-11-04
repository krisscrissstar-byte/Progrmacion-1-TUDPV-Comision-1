using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJ8
    {
        static void Main(string[] args)
        {
            int[] Daño = new int[3];

            // Cargar el daño de las 3 fases
            for (int i = 0; i < Daño.Length; i++)
            {
                Console.WriteLine("Ingrese el daño recibido en la fase " + (i + 1) + ":");
                Daño[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n¿Qué desea hacer?");
            Console.WriteLine("1 - Calcular el promedio de daño");
            Console.WriteLine("2 - Identificar la fase más destructiva");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    int suma = 0;

                    for (int i = 0; i < Daño.Length; i++)
                    {
                        suma = suma + Daño[i];
                    }

                    float promedio = (float)suma / Daño.Length;

                    Console.WriteLine("El promedio de daño recibido es: " + promedio);

                    break;

                case 2:

                    int mayor = Daño[0];
                    int faseMayor = 1;

                    for (int i = 1; i < Daño.Length; i++)
                    {
                        if (Daño[i] > mayor)
                        {
                            mayor = Daño[i];
                            faseMayor = i + 1;
                        }
                    }

                    Console.WriteLine(
                        "La fase más destructiva fue la fase " +
                        faseMayor + " con " + mayor + " de daño."
                    );

                    break;

               
            }

        }

    }
}
    
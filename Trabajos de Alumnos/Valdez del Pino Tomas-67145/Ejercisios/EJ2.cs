using System;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class Ej2
    {
        static void Main(string[] args)
        {
            float[] Tiempos = new float[5];
            float TiempoExigido;

            Console.WriteLine("Ingrese el tiempo exigido");
            TiempoExigido = float.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el tiempo del SpeedRunner");
                Tiempos[i] = float.Parse(Console.ReadLine());
            }

            for (int n = 0; n < Tiempos.Length; n++)
            {
                if (Tiempos[n] <= TiempoExigido)
                {
                    Console.WriteLine(
                        "El SpeedRunner tiene un tiempo de: " + Tiempos[n] +
                        " y el tiempo exigido era de: " + TiempoExigido
                    );

                    Console.WriteLine("Logró el objetivo");
                }
                else
                {
                    Console.WriteLine("El participante no logró el tiempo requerido");
                }
            }
        }
    }
}
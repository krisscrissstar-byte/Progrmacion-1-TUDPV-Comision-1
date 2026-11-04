using System;

class speedrun
{
    static void Main()
    {

        float[] tiempos = new float[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el tiempo del corredor " + (i + 1) + ": ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        float tiempoObjetivo = 0;

        while (tiempoObjetivo != -1)
        {

            Console.Write("Ingrese un tiempo objetivo para clasificar o ingre -1 para salir:");
            tiempoObjetivo = float.Parse(Console.ReadLine());


            if (tiempoObjetivo != -1)
            {

                int clasificados = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (tiempos[i] <= tiempoObjetivo)
                    {
                        clasificados++;
                    }
                }

                Console.WriteLine("Cantidad de corredores que superaron la prueba: " + clasificados);
                Console.WriteLine();
            }
        }
    }
}

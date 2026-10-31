using System;

class Ejercicio2
{
    static void Main()
    {
        string[] Corredores = new string [5];
        float[] Tiempo = new float[5];
        int contador = 1;
        float objetivo;
        float ObjetivoAnterior =-1;
        int Eleccion = 0;

        for (int i = 0; i < Corredores.Length; i++)
        {
            Console.WriteLine("Ingrese el nombre del corredor numero "+ contador + ":");
            Corredores[i] = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempo del corredor " + Corredores[i] + ":");
            Tiempo[i] = float.Parse(Console.ReadLine());
            contador++;
        }

        Console.Clear();

        do
        {
            contador = 0;
            Console.WriteLine("Ingrese el tiempo objetivo");
            objetivo = float.Parse(Console.ReadLine());

            if(objetivo == ObjetivoAnterior)
            {
                Console.WriteLine("Ya ingreso este tiempo objetivo, ingrese un tiempo distinto");
            }
            else if(objetivo > 0)
            {
                
                for (int i = 0; i < Corredores.Length; i++)
                {
                    if (Tiempo[i] <= objetivo)
                    {
                        contador++;
                    }
                }
                Console.WriteLine("La cantidad de corredores que lograron cumplir con el objetivo es: " + contador);
            }

            Console.WriteLine("Desea Volver a analizar otro tiempo objetivo?");
            Console.WriteLine("1 = Si / 2 = NO");
            Eleccion = int.Parse(Console.ReadLine());
            ObjetivoAnterior = objetivo;

        } while (Eleccion == 1);

    }
}

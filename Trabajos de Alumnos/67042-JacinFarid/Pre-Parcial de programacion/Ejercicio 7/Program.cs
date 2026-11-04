using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] trampas = { false, true, false, false, true, false };

            int posicion = 0;

            while (posicion < 5 && trampas[posicion] == false)
            {
                Console.WriteLine("Estás en la baldosa " + posicion);

                posicion++;

                if (posicion < 5)
                {
                    if (trampas[posicion] == true)
                    {
                        Console.WriteLine("¡Pisaste una trampa!");
                    }
                }
            }

            if (trampas[posicion] == true)
            {
                Console.WriteLine("Has perdido.");
            }
            else
            {
                Console.WriteLine("¡Llegaste a la meta!");
            }
        }
    }
}
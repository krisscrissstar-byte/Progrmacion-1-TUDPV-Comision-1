using System;

internal class Program
{
    static void Main(string[] args)
    {
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        bool activoTrampa = false;

        Console.WriteLine("=== PASILLO DE LA MAZMORRA ===");

        while (posicion < trampas.Length && !activoTrampa)
        {
            Console.WriteLine($"\nAvanzando a la baldosa {posicion}...");

            if (trampas[posicion])
            {
                activoTrampa = true;
                Console.WriteLine($"¡ACTIVASTE UNA TRAMPA EN LA BALDOSA {posicion}! Has perdido.");
            }
            else
            {
                Console.WriteLine($"Baldosa {posicion} segura.");
                if (posicion == trampas.Length - 1)
                {
                    Console.WriteLine("\nHas llegado a la meta a salvo.");
                }
                posicion++;
            }
        }

        Console.ReadKey();
    }
}
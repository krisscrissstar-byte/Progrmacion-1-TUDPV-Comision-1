using System;

class Mazmorra
{
    static void Main()
    {
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        bool pisoTrampa = false;

        Console.WriteLine("=== Avanzando por un pasillo en las Mazmorras ===");

        while (posicion <= 5 && pisoTrampa == false)
        {
            Console.WriteLine("Avanzaste a la baldosa " + posicion);

            if (trampas[posicion] == true)
            {
                pisoTrampa = true;
                Console.WriteLine("¡UPS! Activaste una trampa en la baldosa " + posicion + ". ¡Has perdido!");
            }
            else
            {
                if (posicion == 5)
                {
                    Console.WriteLine("¡Felicidades! Llegaste a la meta sin pisar ni una trampas.");
                }
            }

            posicion++;
        }

        Console.ReadKey();
    }
}
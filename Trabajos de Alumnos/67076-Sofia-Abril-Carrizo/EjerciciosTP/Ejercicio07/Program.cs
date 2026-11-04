using System;

namespace Ejercicio07;

class  Ejercicio07
{
    static void Main()
    {
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        bool Vivo = true;

        Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta: Baldosa 5)");

        while (posicion < 5 && Vivo)
        {
            Console.WriteLine("Estas en la baldosa: " + posicion);
            Console.Write("Elige que paso a dar (1 para avanzar 1, 2 para avanzar 2): ");
            int eleccion = int.Parse(Console.ReadLine());

            posicion += eleccion;

            if (posicion >= 5)
            {
                Console.WriteLine("¡Llegaste a la meta!");
                break;
            }

            if (trampas[posicion])
            {
                Console.WriteLine("Perdiste. " + posicion + " FIN DE LA PARTIDA");
                Vivo = false;
            }
            else
            {
                Console.WriteLine("Seguis vivo. Estas en una baldosa segura. " + posicion);
            }
 
        }
    }
}
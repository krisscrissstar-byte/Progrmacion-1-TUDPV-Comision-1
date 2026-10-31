/*Consigna: Un pasillo posee 6 baldosas representadas en un vector booleano bool[] trampas = {
false, true, false, false, true, false };. El jugador avanza casilleros mediante un bucle while mientras
no pise trampa y no llegue a la meta (baldosa 5). Con if/else validar si activa la trampa y pierde
o si completa el recorrido.*/
using System;

public class Ejercicio7
{
    static void Main()
    {
        bool[] trampas = { false, true, false, false, true, false };
        int posicion = 0;
        int meta = trampas.Length - 1; 
        bool juegoTerminado = false;

        Console.WriteLine("Inicias en la baldosa " + posicion);

        while (!juegoTerminado)
        {
            int disponibles = meta - posicion;
            Console.Write($"Estas en la baldosa " + posicion +". Te quedan " +disponibles +" ¿Cuantos pasos querés dar?: ");
            int pasos = int.Parse(Console.ReadLine());

            
            if (pasos > disponibles || pasos <= 0)
            {
                Console.WriteLine("¡Movimiento invalido! Tenés que elegir una cantidad entre 1 y " + disponibles + " pasos");
            }
            else
            {
                
                posicion += pasos;

                
                if (trampas[posicion])
                {
                    Console.WriteLine("¡Activaste la trampa en la baldosa " +posicion+"! Perdiste el juego.");
                    juegoTerminado = true; 
                }
                else if (posicion == meta)
                {
                    Console.WriteLine("¡Llegaste a la baldosa "+posicion+" de la meta sin pisar trampas! ¡Completaste el recorrido!");
                    juegoTerminado = true; 
                }
                else
                {
                    Console.WriteLine("Llegaste a la baldosa " +posicion+ " de forma segura. ¡Avanzas!");
                }
            }
        }
    }
}
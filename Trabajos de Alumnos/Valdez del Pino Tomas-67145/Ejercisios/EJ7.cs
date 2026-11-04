using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJ7
    {
        static void Main(string[] args)
        {
            
            {
                //Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra
                //Combina: Array + while + if/else.

                //Consigna: Un pasillo posee 6 baldosas representadas en un vector booleano
                //bool[] trampas = { false, true, false, false, true, false };. 
                //El jugador avanza casilleros mediante un bucle while mientras no pise trampa y no llegue a la meta(baldosa 5).
                // Con if/else validar si activa la trampa y pierde o si completa el recorrido.


                bool[] trampas = { false, true, false, false, true, false };
                int posicion = 0;
                //bool perdio = false;
                bool sigueVivo = true;

                Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta : Baldosa 5)");

                //while (!perdio && posicion < 5) {
                //    posicion++;//contador de baldosas avanzadas posicion = posicion + 1;
                //    if (trampas[posicion]) //trampas[0]
                //    {

                //        Console.WriteLine($"Avanzando a baldosa: {posicion}");
                //        perdio = true;
                //    }
                //    else
                //    {
                //        Console.WriteLine("Baldosa segura");
                //    }
                //}

                while (posicion < 5 && sigueVivo)
                {

                    Console.WriteLine("Estas en la baldosa:" + posicion);
                    Console.Write("Elige paso a dar (1 para avanzar, 2 avanzar 2): ");
                    int eleccion = int.Parse(Console.ReadLine());

                    posicion += eleccion; //posicion = posicion + eleccion;

                    if (posicion >= 5)
                    {
                        Console.WriteLine("¡Llegaste a la meta! ¡Felicidades!");
                        break;
                    }

                    if (trampas[posicion])
                    {
                        Console.WriteLine("PerdisteFin de la partida");
                        sigueVivo = false;
                    }
                    else
                    {

                        Console.WriteLine("seguis vivo pisaste balsoda segura");
                    }

                }

                if (sigueVivo)
                {
                    Console.WriteLine("¡Felicidades! Has completado el recorrido.");
                    
                }

            }

    }
}
    }


/*

Un pasillo posee 6 baldosas representadas en un vector booleano
bool[] trampas = { false, true, false, false, true, false }
El jugador avanza casilleros mediante un bucle while mientras no pise trampa y no llegue a la meta(baldosa 5)
Con if/else validar si activa la trampa y pierde o si completa el recorrido
 
*/

bool[] trampas = { false, true, false, false, true, false };
int posicion = 0;
//bool perdio = false;
bool sigueVivo = true;

Console.WriteLine("Comienza el recorrido en la baldosa 0 (Meta : Baldosa 5)");

while (posicion < 5 && sigueVivo)
{

    Console.WriteLine("Estas en la baldosa: " + posicion);
    Console.Write("Elige el paso a dar (1 para avanzar, 2 avanzar...): ");
    int eleccion = int.Parse(Console.ReadLine());

    posicion += eleccion;

    if (posicion >= 5)
    {
        Console.WriteLine("¡Llegaste a la meta! ¡Felicidades!");
        break;
    }

    if (trampas[posicion])
    {
        Console.WriteLine("Perdiste " + posicion + " Fin de la partida");
        sigueVivo = false;
    }
    else
    {

        Console.WriteLine("seguis vivo pisaste balsoda segura " + posicion);
    }

}

if (sigueVivo)
{
    Console.WriteLine("¡Felicidades! Has completado el recorrido.");
    Console.ReadKey();
}
           
bool[] trampas = {false, true, false, false, true, false};
int jugador = 0;
bool perdio = false;

while (jugador < 5 && !trampas[jugador])
{
    if (trampas[jugador])
    {
        Console.WriteLine("Sos tan wachin que perdiste xd");
        perdio = true;
        break;
    }
    else
    {
        Console.WriteLine("Pisaste la baldosa " + jugador + ",de pedo seguis vivo, wachin");
        jugador++;
    }
}
if (!perdio)
{
    Console.WriteLine("GENIOOOOOO DE RE MIERDAAAAAA");
}
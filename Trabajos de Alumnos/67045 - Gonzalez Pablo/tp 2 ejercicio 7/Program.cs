//Ejercicio 7

bool[] trampas = { true, false, true, false, true, false };
int posicion = 0;
bool perdio = false;

while (!perdio && posicion < 5)
{
    posicion++;
    if (trampas[posicion])
    {
        Console.WriteLine("Pisaste una trampa en la baldosa " + posicion + ". Perdiste!");
        perdio = true;
    }
    else
    {
        Console.WriteLine("Avanzaste a la baldosa " + posicion + ", todo en orden");
    }
}

if (!perdio)
{
    Console.WriteLine("Llegaste a la meta! Recorrido completado.");
}
    }
}

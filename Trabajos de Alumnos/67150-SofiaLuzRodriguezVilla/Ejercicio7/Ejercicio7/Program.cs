/*Ejercicio 7: Detección de Trampas en Pasillo de Mazmorra*/

bool[] trampas = {false, true, false, false, true, false};
bool meta = false;
bool caida = false;


while (!meta && !caida)
{
    for (int i = 0; i < trampas.Length; i++)
    {
        if (trampas[i] == true)
        {
            caida = true;
            Console.WriteLine("¡Caíste en la trampa!");
            break;
        }

        else
        {
            if (trampas[i] == false)
            {
                Console.WriteLine("¡Baldosa segura!");
            }
            
        }
    }

    if (!caida)
    {
        Console.WriteLine("¡Llegaste a la meta!");
        meta = true;
    }
}
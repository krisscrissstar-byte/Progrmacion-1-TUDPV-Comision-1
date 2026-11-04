//Ejercicio 3
int[] slimes = { 30, 40, 50, 60 };
bool hayVivos = true;

while (hayVivos)
{
    Console.WriteLine("Elija un slime para atacar (0 al 3):");
    for (int i = 0; i < slimes.Length; i++)
    {
        Console.WriteLine(i + ": HP = " + slimes[i]);
    }


    int indice = int.Parse(Console.ReadLine());

    switch (indice)
    {
        case 0:
        case 1:
        case 2:
        case 3:
            if (slimes[indice] <= 0)
            {
                Console.WriteLine("Ese slime ya esta derrotado");
            }
            else
            {
                slimes[indice] -= 20;
                if (slimes[indice] < 0) slimes[indice] = 0;
                Console.WriteLine("Slime " + indice + " ahora tiene " + slimes[indice] + " HP");
            }

            break;
        default:
            Console.WriteLine("Indice invalido");
            break;
    }


    hayVivos = false;
    for (int i = 0; i < slimes.Length; i++)
    {
        if (slimes[i] > 0) hayVivos = true;
    }
}

Console.WriteLine("Todos los slimes fueron derrotados. Ganaste!");
    }
}

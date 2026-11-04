//Ejercicio 2
float[] tiempos = new float[5];

for (int i = 0; i < tiempos.Length; i++)
{
    Console.Write("Tiempo del corredor " + (i + 1) + ": ");
    tiempos[i] = float.Parse(Console.ReadLine());
}

int seguir = 1;
while (seguir == 1)
{
    Console.Write("Ingrese el tiempo objetivo: ");
    float marca = float.Parse(Console.ReadLine());
    int cantidadSuperaron = 0;

    for (int i = 0; i < tiempos.Length; i++)
    {
        if (tiempos[i] <= marca)
        {
            cantidadSuperaron++;
        }
    }

    if (cantidadSuperaron > 0)
        Console.WriteLine(cantidadSuperaron + " corredores superaron la marca");
    else
        Console.WriteLine("Nadie logro esa marca");
    Console.Write("Desea probar otra marca? (1 = Si / 2 = No): ");
    seguir = int.Parse(Console.ReadLine());
}
    }
}

float[] tiempo = new float[5];
int seguir = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingrese el tiempo (segundos) del corredor " + (i + 1) + ":");
    tiempo[i] = float.Parse(Console.ReadLine());
}

while (seguir == 0)
{
    Console.WriteLine("Ingrese 1 para salir y 0 para continuar:");
    seguir = int.Parse(Console.ReadLine());

    int aprobados = 0;
    Console.WriteLine ("Ingresar la marca a evaluar:");
    float marca = float.Parse(Console.ReadLine());

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("El tiempo del corredor " + (i + 1) + " es: " + tiempo[i]);
        if (tiempo[i] <= marca)
        {
            Console.WriteLine("El corredor " + (i + 1) + "supera el tiempo marcado");
        }
        else
        {
            Console.WriteLine("El corredor " + (i + 1) + " no supera el tiempo marcado");
        }

    }
}

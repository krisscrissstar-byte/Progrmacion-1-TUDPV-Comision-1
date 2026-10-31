int[] slimes = {30, 40, 50, 60 };
bool vivos = true;

while (vivos)
{
    Console.WriteLine("Llegaron slimes enemigos!!!");
    for (int i = 0; i < slimes.Length; i++)
    {
        Console.WriteLine("Slime" + (i + 1) + ": " + slimes[i] + " HP");
    }
   Console.WriteLine("Selecciona un slime para atacar: (1 a 4)");
   int eleccion = int.Parse(Console.ReadLine());

    switch (eleccion)
    {
        case 1:
            slimes[0] -= 20;
            break;
        case 2:
            slimes[1] -= 20;
            break;
        case 3:
            slimes[2] -= 20;
            break;
        case 4:
            slimes[3] -= 20;
            break;
    }
    if (!slimes.Any(x => x > 0))
    {
        vivos = false;
    }
}

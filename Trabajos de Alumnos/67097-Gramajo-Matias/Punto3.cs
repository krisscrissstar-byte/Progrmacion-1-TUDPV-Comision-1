    int[] slimes = { 30, 40, 50, 60 };
    bool vivos = true;
   
    while (vivos)
    {
        Console.WriteLine("!!!BATALLA!!!");
        for (int i = 0; i < slimes.Length; i++)
        {
            Console.WriteLine("Slime " + (i + 1) + ": " + slimes[i] + " de vida restante");
        }

        Console.WriteLine("Elija cual atacar");
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

    Console.WriteLine("Enemigos derrotados!!!");
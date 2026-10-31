{
    string[] armas = ("Rifle,Pistola, Escopeta");
    int[] municion = (30, 15, 8);

    int opcion = -1;
    while (opcion != 0)
    {
        Console.WriteLine("1:Rifle | 2:Pistola | 3:Escopeta | 0:Salir");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
            case1: 
            case 2:
        case 3:
            int indice = opcion = -1;
            if (municion[indice] > 0)

            {
                municion[indice]--;
                Console.WriteLine("PUM!" + armas[indice] + " - Balas restantes:" + municion[indice]);

            }

            else
            {
                Console.WriteLine(armas[indice] + "esta vacia, recarga!");
            }
            break;
        case 0:
            Console.WriteLine("Guardando el arma...");
            break;
        }
    }
}
}


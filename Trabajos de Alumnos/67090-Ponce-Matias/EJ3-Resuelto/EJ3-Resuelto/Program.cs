string[] SlimeNombre = {"slime verde", "slime azul", "slime rojo", "slime amarillo"};
int[] SlimeVida = { 21, 75, 57, 35 };

while (SlimeVida.Any(v => v > 0)) // mientras haya slimes con vida sobre cero el codigo se ejecuta //
{
    for (int i = 0; i < SlimeNombre.Length; i++)
    {
        Console.WriteLine($"    la vida de {SlimeNombre[i]} es {SlimeVida[i]}");
        Console.WriteLine("|-----------------------------------|");
    }

    Console.WriteLine("");

    Console.WriteLine("Escriba 1 - 2 - 3 - 4 para atacar a un slime");


    int jugadorInput;

    if (int.TryParse(Console.ReadLine(), out jugadorInput))
    {
        switch (jugadorInput)
        {
            case 1:
                if (SlimeVida[0] > 0)
                {
                    SlimeVida[0] = SlimeVida[0] - 20;
                }

                else if (SlimeVida[0] <= 0)
                {
                    Console.WriteLine($"{SlimeNombre[0]} esta muerto, elija otro");
                    Thread.Sleep(1000);
                }

                if (SlimeVida[0] < 0)
                {
                    SlimeVida[0] = 0;
                }
                Console.Clear();
                break;
            case 2:
                if (SlimeVida[1] > 0)
                {
                    SlimeVida[1] = SlimeVida[1] - 20;
                }

                else if (SlimeVida[1] <= 0)
                {
                    Console.WriteLine($"{SlimeNombre[1]} esta muerto, elija otro");
                    Thread.Sleep(1000);
                }

                if (SlimeVida[1] < 0)
                {
                    SlimeVida[1] = 0;
                }
                Console.Clear();
                break;
            case 3:
                if (SlimeVida[2] > 0)
                {
                    SlimeVida[2] = SlimeVida[2] - 20;
                }

                else if (SlimeVida[2] <= 0)
                {
                    Console.WriteLine($"{SlimeNombre[2]} esta muerto, elija otro");
                    Thread.Sleep(1000);
                }

                if (SlimeVida[2] < 0)
                {
                    SlimeVida[2] = 0;
                }
                Console.Clear() ;
                break;
            case 4:
                if (SlimeVida[3] > 0)
                {
                    SlimeVida[3] = SlimeVida[3] - 20;
                }

                else if (SlimeVida[3] <= 0)
                {
                    Console.WriteLine($"{SlimeNombre[3]} esta muerto, elija otro");
                    Thread.Sleep(1000);
                }

                if (SlimeVida[3] < 0)
                {
                    SlimeVida[3] = 0;
                }
                Console.Clear ();
                break;
            default:
                Console.WriteLine("Seleccion invalida");
                Thread.Sleep(1000);
                Console.Clear();
                break;
        }

    }
}

Console.Clear();
Console.WriteLine("Todos los slimes murieron");

Console.WriteLine(" ");

Console.WriteLine("yippie");
Console.ReadKey();
int[] soldadoMunicion = { 30, 15, 8 };
string[] soldadoArmas = { "Rifle", "Pistola", "Escopeta" };

int soldadoArmasVacias = 0;

int jugadorInput;

while (soldadoArmasVacias < 3)
{
    Console.WriteLine("Elija un arma para disparar:");
    Console.WriteLine("- - - - - - - - - - - - - -");
    Console.WriteLine($"1. Rifle (municion: {soldadoMunicion[0]})");
    Console.WriteLine($"2. Pistola (municion: {soldadoMunicion[1]})");
    Console.WriteLine($"3. Escopeta (municion: {soldadoMunicion[2]})");

    if (int.TryParse(Console.ReadLine(), out jugadorInput) && jugadorInput >= 0 && jugadorInput <= 3)
    {
        switch (jugadorInput)
        {
            case 1:
                Console.Clear();
                if (soldadoMunicion[0] > 0)
                {
                    while (soldadoMunicion[0] > 0)
                    {
                        Console.WriteLine($"disparo una bala, le quedan {soldadoMunicion[0]} balas");
                        soldadoMunicion[0]--;

                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    soldadoArmasVacias++;
                }
                else
                {
                    Console.WriteLine("no te quedan balas jiji");
                    Thread.Sleep(1000);

                    Console.Clear();
                }
                break;
            case 2:
                Console.Clear();
                if (soldadoMunicion[1] > 0)
                {
                    while (soldadoMunicion[1] > 0)
                    {
                        Console.WriteLine($"disparo una bala, le quedan {soldadoMunicion[1]} balas");
                        soldadoMunicion[1]--;

                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    soldadoArmasVacias++;
                }
                else
                {
                    Console.WriteLine("no te quedan balas jiji");
                    Thread.Sleep(1000);

                    Console.Clear();
                }
                break;
            case 3:
                Console.Clear();
                if (soldadoMunicion[2] > 0)
                {
                    while (soldadoMunicion[2] > 0)
                    {
                        Console.WriteLine($"disparo una bala, le quedan {soldadoMunicion[2]} balas");
                        soldadoMunicion[2]--;

                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    soldadoArmasVacias++;
                }
                else
                {
                    Console.WriteLine("no te quedan perdigones jiji");
                    Thread.Sleep(1000);

                    Console.Clear();
                }
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("error");
        Console.WriteLine("intente otra vez");

        Thread.Sleep(1000);
        Console.Clear();
    }
}


Console.Clear();

Console.WriteLine("Se le acabo toda la municion");
Console.ReadKey();
bool[] BaldosasTrampas = { false, true, false, false, true, false };
string[] BaldosasNombre = { "baldosa 1", "baldosa 2", "baldosa 3", "baldosa 4", "baldosa 5", "baldosa 6" };

string[] BaldosasFinal = new string[1];

bool SigueVivo = true;
int JugadorInput;

while(SigueVivo)
{
    for(int i = 0; i < BaldosasTrampas.Length; i++)
    {
        Console.Clear();
        Console.WriteLine($"estas en la {BaldosasNombre[i]}");
        Thread.Sleep(1500);

        if (BaldosasTrampas[i] == true)
        {
            Console.WriteLine("El jugador pisa una trampa");
            Console.WriteLine("- - - - - - - - - - - - - -");

            Console.WriteLine("1. Continuar");
            Console.WriteLine("2. Rendirse");

            if (SigueVivo)
            {
                if (int.TryParse(Console.ReadLine(), out JugadorInput) && JugadorInput > 0 && JugadorInput < 3)
                {
                    switch (JugadorInput)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"El jugador continua...");

                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            SigueVivo = false;

                            i = int.MaxValue - 1; //esta linea me salvo increible, gracias a esto el loop for termina de una, aunque no le entendi muy bien//

                            Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("error");
                Console.WriteLine("intente otra vez");

                Thread.Sleep(1000);
                Console.Clear();
                --i;
            }
        }
    }
}
if (!SigueVivo)
{
    Console.WriteLine("Aqui termina tu aventura");
    Console.WriteLine("- - - - - - - - - - - - - - - - -");
    Console.WriteLine("Presione una tecla para terminar");

    Console.ReadKey();
}
else if (SigueVivo)
{
    Console.WriteLine("Llegaste al final. Felicitaciones");
    Console.WriteLine("Presione una tecla para terminar");

    Console.ReadKey();
    Console.Clear();
}


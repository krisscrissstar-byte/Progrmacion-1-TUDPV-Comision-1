string[] GemasNombre = { "Fuego", "Hielo", "Rayo", "Veneno" };
int[] GemasCarga = new int[4];


for (int i = 0; i < GemasNombre.Length; i++)
{
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
    Console.WriteLine($"escriba las cargas de la gema tipo {GemasNombre[i]} (max 10)");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");

    if(int.TryParse(Console.ReadLine(), out GemasCarga[i]) && GemasCarga[i] > -1 && GemasCarga[i] < 11)
    {
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine($"la gema tipo {GemasNombre[i]} tiene {GemasCarga[i]} cargas.");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (!int.TryParse(Console.ReadLine(), out GemasCarga[i]) || GemasCarga[i] < 0 || GemasCarga[i] > 10)
    {
        Console.WriteLine("error");
        Console.WriteLine("intente otra vez");
        
        Thread.Sleep(1000);
        Console.Clear();
        i--;
    }
}

int JugadorInput;
bool ContinuarInput = true;

while (ContinuarInput)
{
    Console.WriteLine("Elija una opcion");

    Console.WriteLine("- - - - - - - - - - - - - -");
    Console.WriteLine("1. Recargar todas las gemas");
    Console.WriteLine("2. Identificar gemas sin carga");
    Console.WriteLine("3. Terminar el programa"); 
    Console.WriteLine("- - - - - - - - - - - - - -");

    if (int.TryParse(Console.ReadLine(), out JugadorInput) && JugadorInput > 0 && JugadorInput < 4)
    {
        switch (JugadorInput)
        {
            case 1:
                Console.Clear();
                for (int i = 0; i < GemasNombre.Length; i++)
                {
                    GemasCarga[i] += 5;
                    if (GemasCarga[i] > 10)
                    {
                        GemasCarga[i] = 10;
                    }

                    Console.WriteLine($"Gema tipo {GemasNombre[i]} + 5 = {GemasCarga[i]} cargas");
                    Thread.Sleep(500);

                }
                Console.ReadKey();
                Console.Clear();
                break;
            case 2:
                Console.Clear();
                for (int i = 0; i < GemasNombre.Length; i++)
                {
                    if (GemasCarga[i] == 0)
                    {
                        Console.WriteLine($"La gema tipo {GemasNombre[i]} esta vacia");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine($"La gema tipo {GemasNombre[i]} NO esta vacia");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Thread.Sleep(1000);
                    }
                }
                Console.ReadKey();
                Console.Clear();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Terminando programa");

                Thread.Sleep(1000);
                ContinuarInput = false;
                break;
        }
    }
    else if (!int.TryParse(Console.ReadLine(), out JugadorInput) || JugadorInput < 0 || JugadorInput > 4)
    {
        Console.Clear();
        Console.WriteLine("error");
        Console.WriteLine("intente otra vez");
        
        Thread.Sleep(1000);
        Console.Clear();
        continue;
    }
}

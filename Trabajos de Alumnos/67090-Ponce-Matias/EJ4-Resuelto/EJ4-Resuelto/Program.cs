int JugadorGemas;

int[] CartasCoste = { 10, 25, 50, 80, 120 };
string[] CartasNombre = { "carta1", "carta2", "carta3", "carta4", "carta5" };

int MaxCartaCoste = CartasCoste.Max(); //busca el numero mas alto de CartasCoste//
int MaxCartaPosicion = Array.IndexOf(CartasCoste, MaxCartaCoste); //consigue el index(num de posicion en el array) de MaxCartaCoste dentro de CartasCoste//

int JugadorInput;


Console.WriteLine("- - - - - - - - - - - - - - -");
Console.WriteLine("Escriba sus gemas disponibles (max 150)");
Console.WriteLine("- - - - - - - - - - - - - - -");

if (int.TryParse(Console.ReadLine(), out JugadorGemas) && JugadorGemas > 0 && JugadorGemas <= 150)
{
    if(JugadorGemas > 0 && JugadorGemas < 150)
    Console.WriteLine("- - - - - - - - - - - - - - -");
    Console.WriteLine($"Usted tiene {JugadorGemas} gemas");
    Console.WriteLine("- - - - - - - - - - - - - - -");
    Thread.Sleep(1000);
    Console.Clear();

    Console.WriteLine("Seleccione una opcion:");
    Console.WriteLine("");
    Console.WriteLine("1. Cartas que puede pagar");
    Console.WriteLine("");
    Console.WriteLine("2. Identificar la carta mas cara");

    while (int.TryParse(Console.ReadLine(), out JugadorInput))
    {

        switch (JugadorInput)
        {
            case 1:
                Console.Clear();
                for (int i = 0; i < CartasCoste.Length; i++)
                {
                    if (CartasCoste[i] <= JugadorGemas)
                    {
                        Console.WriteLine($"Puedes pagar {CartasNombre[i]}");
                    }
                }
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine($"La carta mas valiosa es: {CartasNombre[MaxCartaPosicion]} con un valor de {MaxCartaCoste}");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
}
else
{
    Console.WriteLine("error");
    Console.ReadKey();
}










int[] cartasCosto = new int[] {10, 25, 50, 80, 120};

Console.WriteLine("Ingresar cantidad de gemas");
int usuarioGemas = int.Parse(Console.ReadLine());

Console.WriteLine("1: Mostrar cartas de la tienda");
Console.WriteLine("2: Mostrar carta más cara");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        for (int i = 0; i < cartasCosto.Length; i++)
        {
            if (cartasCosto[i] <= usuarioGemas)
            {
                Console.WriteLine("Carta " + (i + 1) + ", valor: ");
                Console.WriteLine(cartasCosto[i] + " gemas");
            }
            else
            {
                Console.WriteLine("Carta " + (i + 1) + ", valor: ");
                Console.WriteLine(cartasCosto[i] + "gemas insuficientes");
            }
        }
        break;
    case 2:
        int masCara = cartasCosto[0];
        for (int i = 1; i < cartasCosto.Length; i++)
        {
            if (cartasCosto[i] > masCara)
            {
                masCara = cartasCosto[i];
            }
        }
        Console.WriteLine("La carta más cara cuesta: " + masCara + " gemas");
        break;
}
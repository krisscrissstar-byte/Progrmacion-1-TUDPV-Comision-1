//Ejercicio 4

int[] costos = { 10, 25, 50, 80, 120 };

Console.Write("Cuantas gemas tenes? ");

int gemas = int.Parse(Console.ReadLine());

Console.WriteLine("1: Ver cartas que puedo pagar");
Console.WriteLine("2: Ver la carta mas cara del catalogo");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        for (int i = 0; i < costos.Length; i++)
        {
            if (costos[i] <= gemas)
            {
                Console.WriteLine("Carta " + i + " - Costo: " + costos[i] + " (la podes comprar)");
            }
        }
        break;
    case 2:
        int maxima = costos[0];
        for (int i = 1; i < costos.Length; i++)
        {
            if (costos[i] > maxima)
            {
                maxima = costos[i];
            }
        }
        Console.WriteLine("La carta mas cara cuesta: " + maxima + " gemas");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}
    }
}

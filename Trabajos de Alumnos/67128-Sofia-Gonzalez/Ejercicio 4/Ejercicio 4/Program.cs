using System;

class costodeCartas
{
    static void Main()
    {
        int[] costodeCartas = { 10, 25, 50, 80, 120 };

        Console.Write("Ingrese su cantidad de gemas:");
        int gemas = int.Parse(Console.ReadLine());

        Console.WriteLine("***Tienda de Gemas***");
        Console.WriteLine("1:Cartas que puedes pagar");
        Console.WriteLine("2:Cartas mas caras del catalogo");
        Console.Write("Elija una opcion:");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {

            case 1:

                Console.WriteLine("-----------------------");
                Console.WriteLine("Cartas que puedes pagar");
                Console.WriteLine("-----------------------");

                for (int i = 0; i < 5; i++)
                {
                    if (gemas >= costodeCartas[i])
                    {
                        Console.WriteLine("Carta " + (i + 1) + " costo:" + costodeCartas[i]);
                    }
                }
                break;

            case 2:

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Cartas mas caras del catalogo");
                Console.WriteLine("-----------------------------");

                int mayor = costodeCartas[0];

                for (int i = 1; i < 5; i++)
                {
                    if (costodeCartas[i] > mayor)
                    {
                        mayor = costodeCartas[i];
                    }
                }
                Console.WriteLine("La carta mas cara tiene un costo de:" + mayor + " gemas");
  
                break;
        }
    }
}

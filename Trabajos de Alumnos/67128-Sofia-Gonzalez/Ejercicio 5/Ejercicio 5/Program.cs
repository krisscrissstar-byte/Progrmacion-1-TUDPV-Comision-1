using System;

class Rafaga
{
    static void Main()
    {
        int[] danioFlechas = new int[6];

        Console.WriteLine("**Registro de daño por rafaga**");
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Ingrese el daño de la flecha " + (i + 1) + ": ");
            danioFlechas[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese un daño de referencia para filtrar: ");
        int limite = int.Parse(Console.ReadLine());

        int acumuladorDanio = 0;
        int filtrado = 0;

        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("Impactos que superaron los " + limite + " puntos de daño");
        Console.WriteLine("--------------------------------------------------------");

        while (filtrado < 6)
        {
            if (danioFlechas[filtrado] > limite)
            {
                Console.WriteLine("Flecha " + (filtrado + 1) + ": " + danioFlechas[filtrado] + " de daño");
                acumuladorDanio = acumuladorDanio + danioFlechas[filtrado];
            }
            filtrado++;
        }

        Console.WriteLine("Total de daño acumulado por encima del límite: " + acumuladorDanio);
    }
}
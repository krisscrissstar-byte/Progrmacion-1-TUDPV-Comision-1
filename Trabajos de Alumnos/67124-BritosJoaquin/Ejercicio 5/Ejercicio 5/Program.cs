using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] danioFlechas = new int[6];

        Console.WriteLine("=== REGISTRO DE DAÑO POR RÁFAGA ===");


        for (int i = 0; i < danioFlechas.Length; i++)
        {
            Console.Write($"Ingrese el daño de la flecha {i + 1}: ");
            int.TryParse(Console.ReadLine(), out danioFlechas[i]);
        }

        Console.Write("\nIngrese el daño de referencia a filtrar: ");
        int.TryParse(Console.ReadLine(), out int danioReferencia);

        int totalAcumulado = 0;
        int index = 0;

        Console.WriteLine($"\n--- Impactos mayores a {danioReferencia} ---");

        while (index < danioFlechas.Length)
        {
            if (danioFlechas[index] > danioReferencia)
            {
                Console.WriteLine($"Flecha {index + 1}: {danioFlechas[index]} de daño (Supera)");
                totalAcumulado += danioFlechas[index];
            }
            else
            {
                Console.WriteLine($"Flecha {index + 1}: {danioFlechas[index]} de daño (No supera)");
            }

            index++;
        }

        Console.WriteLine($"\nTotal de daño acumulado filtrado: {totalAcumulado}");

        Console.ReadKey();
    }
}
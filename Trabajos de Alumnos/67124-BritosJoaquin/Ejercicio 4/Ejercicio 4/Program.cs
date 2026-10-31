using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] costosGemas = { 10, 25, 50, 80, 120 };

        Console.Write("Ingrese la cantidad de Gemas que posee: ");
        if (int.TryParse(Console.ReadLine(), out int gemasUsuario))
        {
            Console.WriteLine("\n === TIENDA DE CARTAS ===");
            Console.WriteLine("1: Mostrar cartas que puedes pagar");
            Console.WriteLine("2: Identificar la carta mas cara del catalogo");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"\nCartas accesibles con {gemasUsuario} gemas:");
                        for (int i = 0; i < costosGemas.Length; i++)
                        {
                            if (costosGemas[i] <= gemasUsuario)
                            {
                                Console.WriteLine($"- Carta {i + 1}: {costosGemas[i]} gemas");
                            }
                        }
                        break;
                    case 2:
                        int max = costosGemas[0];
                        for (int i = 1; i < costosGemas.Length; i++)
                        {
                            if (costosGemas[i] > max)
                            {
                                max = costosGemas[i];
                            }
                        }
                        Console.WriteLine($"\nLa carta más cara cuesta: {max} gemas");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        Console.ReadKey();
    }
}
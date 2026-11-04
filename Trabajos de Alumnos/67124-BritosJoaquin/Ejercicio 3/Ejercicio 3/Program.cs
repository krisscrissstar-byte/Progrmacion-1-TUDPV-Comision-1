internal class Program
{
    static void Main(string[] args)
    {
        int[] slimes = { 30, 40, 50, 60 };
        bool haySlimesVivos = true;
        System.Console.WriteLine("=== COMBATE CONTRA HORDA DE SLIMES ===");
        while (haySlimesVivos)
        {
            System.Console.WriteLine("\nEstado actual de la horda:");
            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                {
                    System.Console.WriteLine($"Slime {i}: {slimes[i]} HP");
                }
                else
                {
                    System.Console.WriteLine($"Slime {i}: [DERROTADO]");
                }
            }
            System.Console.Write("\nSeleccione el Slime a atacar (0 a 3): ");
            if (int.TryParse(System.Console.ReadLine(), out int objetivo))
            {
                switch (objetivo)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (slimes[objetivo] <= 0)
                        {
                            System.Console.WriteLine($"¡El Slime {objetivo} ya fue derrotado! Elige otro objetivo.");
                        }
                        else
                        {
                            slimes[objetivo] -= 20;
                            if (slimes[objetivo] < 0)
                            {
                                slimes[objetivo] = 0;
                            }
                            System.Console.WriteLine($"¡Atacaste al Slime {objetivo}! Le restaste 20 HP. Vida restante: {slimes[objetivo]} HP.");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Opción no válida. Debes elegir un índice entre 0 y 3.");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            }

            haySlimesVivos = false;
            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                {
                    haySlimesVivos = true;
                    break;
                }
            }
        }
        System.Console.WriteLine("\n¡Felicidades! Todos los slimes han sido derrotados.");
        System.Console.WriteLine("\nPresione cualquier tecla para salir...");
        System.Console.ReadKey();
    }
}
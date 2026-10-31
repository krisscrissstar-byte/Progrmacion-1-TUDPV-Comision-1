using System;

class vida_Slime
{
    static void Main()
    {
        int[] slimes = { 30, 40, 50, 60 };

        while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("ESTADO DE LOS SLIMES");
            Console.WriteLine("--------------------");
            Console.WriteLine("Slime 1: " + slimes[0] + " HP)");
            Console.WriteLine("Slime 2: " + slimes[1] + " HP)");
            Console.WriteLine("Slime 3: " + slimes[2] + " HP)");
            Console.WriteLine("Slime 4: " + slimes[3] + " HP)");

            Console.Write("Elige a qué slime atacar (0-3): ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    if (slimes[0] <= 0)
                    {
                        Console.WriteLine("¡El Slime 1 ya fue derrotado!");
                    }
                    else
                    {
                        slimes[0] = slimes[0] - 20;
                        Console.WriteLine("¡Atacaste al Slime 1! Le restaste 20 HP.");
                    }
                    break;

                case 1:
                    if (slimes[1] <= 0)
                    {
                        Console.WriteLine("¡El Slime 2 ya fue derrotado!");
                    }
                    else
                    {
                        slimes[1] = slimes[1] - 20;
                        Console.WriteLine("¡Atacaste al Slime 2! Le restaste 20 HP.");
                    }
                    break;

                case 2:
                    if (slimes[2] <= 0)
                    {
                        Console.WriteLine("¡El Slime 3 ya fue derrotado!");
                    }
                    else
                    {
                        slimes[2] = slimes[2] - 20;
                        Console.WriteLine("¡Atacaste al Slime 3! Le restaste 20 HP.");
                    }
                    break;

                case 3:
                    if (slimes[3] <= 0)
                    {
                        Console.WriteLine("¡El Slime 4 ya fue derrotado!");
                    }
                    else
                    {
                        slimes[3] = slimes[3] - 20;
                        Console.WriteLine("¡Atacaste al Slime 4! Le restaste 20 HP.");
                    }
                    break;

            }

            Console.WriteLine();
        }

        Console.WriteLine("¡VICTORIA! Todos los slimes han sido eliminados.");
    }
}


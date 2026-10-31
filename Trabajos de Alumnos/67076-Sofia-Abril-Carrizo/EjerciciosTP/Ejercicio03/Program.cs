using System;

namespace Ejercicio03;

class Ejercicio03
{
    static void Main()
        {
        int[] slimes = { 30, 40, 50, 60 };

        bool SlimesSi = true;

        while (SlimesSi)
        {
            Console.WriteLine("Vida de los Slimes: ");
            Console.WriteLine();
            for (int i = 0; i < slimes.Length; i++)
            {
                Console.WriteLine("Slime " + i + ": " + slimes[i] + " HP");
            }

            Console.Write("Elija un slime para atacar (0 al 3): ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                 case 0:
                 case 1:
                 case 2:
                 case 3:

                    if (slimes[opcion] > 0)
                    {
                        slimes[opcion] -= 20;
                        if (slimes[opcion] < 0)
                        {
                            slimes[opcion] = 0;
                        }
                        Console.WriteLine("¡Atacaste al Slime " + opcion + "!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ese Slime ya fue derrotado.");
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
            SlimesSi = false;

            for (int i = 0; i < slimes.Length; i++)
            {
                if (slimes[i] > 0)
                {
                    SlimesSi = true;
                }
            }
        }
        Console.WriteLine("¡Todos los Slimes fueron derrotados!");
    }

}

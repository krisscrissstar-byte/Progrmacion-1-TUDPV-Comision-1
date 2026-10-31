using System;

class MunicionyDisparo
{
    static void Main()
    {
        int[] municion = { 30, 15, 8 };
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("<--ARMAS-->");
            Console.WriteLine("1:Rifle (Balas: " + municion[0] + ")");
            Console.WriteLine("2:Pistola (Balas: " + municion[1] + ")");
            Console.WriteLine("3:Escopeta (Balas: " + municion[2] + ")");
            Console.WriteLine("0: Salir del combate");
            Console.Write("Elija una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (municion[0] > 0)
                    {
                        municion[0]-=3;
                        Console.WriteLine();
                        Console.WriteLine("Disparaste con el Rifle. Te quedan " + municion[0] + " balas.");
                    }
                    else
                    {
                        Console.WriteLine("¡El Rifle está sin balas!");
                    }
                    break;

                case 2:
                    if (municion[1] > 0)
                    {
                        municion[1]-=3;
                        Console.WriteLine();
                        Console.WriteLine("Disparaste con la Pistola. Te quedan " + municion[1] + " balas.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("¡La Pistola está sin balas!");
                    }
                    break;

                case 3:
                    if (municion[2] > 0)
                    {
                        municion[2]-=3;
                        Console.WriteLine();
                        Console.WriteLine("Disparaste con la Escopeta. Te quedan " + municion[2] + " balas.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("¡La Escopeta está sin balas!");
                    }
                    break;

                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Guardando armamento y saliendo...");
                    break;
            }
        }

        Console.ReadKey();
    }
}

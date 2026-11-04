/*Consigna: Declarar un array con la salud de 4 slimes:
int[] slimes = { 30, 40, 50, 60 };. Mediante un bucle while que permanezca activo mientras al
menos un slime tenga vida > 0, el usuario elige con un switch a cuál atacar (0 al 3). Con if/else
validar si el slime atacado ya fue derrotado o restarle 20 HP.
*/
using System;
class Ejercicio3
{
    static void Main()
    {
        int[] slimes = { 30, 40, 50, 60 };

        while (slimes[0]>0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
        {
            Console.WriteLine("Indique a que slime quiere atacar: 0 al 3");
            int Opcion = int.Parse(Console.ReadLine());

            switch(Opcion) 
            {
                case 0:
                    if (slimes[0] > 0)
                    {
                        slimes[0] = slimes[0] - 20;
                        if (slimes[0] < 0)
                        {
                            slimes[0] = 0;
                        }
                        Console.WriteLine("El slime sigue vivo, pero se le resto 20HP");
                        Console.WriteLine("Vida actual del slime seleccionado: "+slimes[0]);
                    }
                    else if(slimes[0] <= 0)
                    {
                        Console.WriteLine("El slime seleccionado, ya fue derrotado");
                    }

                    break;
                
                case 1:
                    if (slimes[1] > 0)
                    {
                        slimes[1] = slimes[1] - 20;
                        if (slimes[1] < 0)
                        {
                            slimes[1] = 0;
                        }
                        Console.WriteLine("El slime sigue vivo, pero se le resto 20HP");
                        Console.WriteLine("Vida actual del slime seleccionado: " + slimes[1]);
                    }
                    else if (slimes[1] <= 0)
                    {
                        Console.WriteLine("El slime seleccionado, ya fue derrotado");
                    }
                    break;
               
                case 2:
                    if (slimes[2] > 0)
                    {

                        slimes[2] = slimes[2] - 20;
                        if (slimes[2] < 0)
                        {
                            slimes[2] = 0;
                        }
                        Console.WriteLine("El slime sigue vivo, pero se le resto 20HP");
                        Console.WriteLine("Vida actual del slime seleccionado: " + slimes[2]);
                    }
                    else if (slimes[2] <= 0)
                    {
                        Console.WriteLine("El slime seleccionado, ya fue derrotado");
                    }
                    break;
                
                case 3:
                    if (slimes[3] > 0)
                    {
                        slimes[3] = slimes[3] - 20;
                        Console.WriteLine("El slime sigue vivo, pero se le resto 20HP");
                        Console.WriteLine("Vida actual del slime seleccionado: " + slimes[3]);
                    }
                    else if (slimes[3] <= 0)
                    {
                        Console.WriteLine("El slime seleccionado, ya fue derrotado");
                    }
                    break;
               
                default: break;
            }



        }

    }
}

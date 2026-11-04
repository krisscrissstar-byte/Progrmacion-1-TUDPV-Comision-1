using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJ9
    {
        static void Main(string[] args)
        {
            string[] Armas = { "Rifle", "Pistola", "Escopeta" };
            int[] Municion = { 30, 15, 8 };

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n--- ARMAS ---");

                for (int i = 0; i < Armas.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + Armas[i] +
                        ": " + Municion[i] + " balas");
                }

                Console.WriteLine("0 - Salir");

                Console.WriteLine("Elija un arma:");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Municion[0]--;

                        Console.WriteLine("Disparaste el " + Armas[0]);
                        Console.WriteLine("Munición restante: " + Municion[0]);

                        break;

                    case 2:

                        Municion[1]--;

                        Console.WriteLine("Disparaste la " + Armas[1]);
                        Console.WriteLine("Munición restante: " + Municion[1]);

                        break;

                    case 3:

                        Municion[2]--;

                        Console.WriteLine("Disparaste la " + Armas[2]);
                        Console.WriteLine("Munición restante: " + Municion[2]);

                        break;

                    case 0:

                        for (int i = 0; i < Municion.Length; i++)
                        {
                            if (Municion[i] == 0)
                            {
                                Console.WriteLine("El " + Armas[i] + " está vacío.");
                            }
                            else
                            {
                                Console.WriteLine("El " + Armas[i] +
                                    " todavía tiene " + Municion[i] + " balas.");
                            }
                        }

                        break;
                }

            }

    }   }
}
   

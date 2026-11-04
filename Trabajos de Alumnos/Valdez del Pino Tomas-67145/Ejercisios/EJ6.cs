using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJ6
    {
        static void Main(string[] args)
        {
             string[] Gemas = { "fuego", "hielo", "rayo", "veneno" };
            int[] Cargas = new int[4];

            // Cargar las cargas de cada gema
            for (int i = 0; i < Gemas.Length; i++)
            {
                Console.WriteLine("Ingrese las cargas de la gema de " + Gemas[i] + ":");
                Cargas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n¿Qué desea hacer?");
            Console.WriteLine("1 - Recargar todas las gemas");
            Console.WriteLine("2 - Buscar gemas agotadas");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    for (int i = 0; i < Cargas.Length; i++)
                    {
                        Cargas[i] = Cargas[i] + 5;

                        Console.WriteLine(
                            "La gema de " + Gemas[i] +
                            " ahora tiene " + Cargas[i] + " cargas."
                        );
                    }

                    break;

                case 2:

                    for (int i = 0; i < Cargas.Length; i++)
                    {
                        if (Cargas[i] == 0)
                        {
                            Console.WriteLine(
                                "La gema de " + Gemas[i] +
                                " está agotada."
                            );
                        }
                    }

                    break;
            }   }

    }
}


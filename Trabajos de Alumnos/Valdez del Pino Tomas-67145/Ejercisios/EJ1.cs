using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    public class Ej1
    {
        static void Main(string[] args)
        {
            string[] Armas = { "Espada", "Arco", "Hacha", "Daga" };
            int[] Durabilidad = new int[Armas.Length];

            Console.WriteLine("Revision de la Durabilidad de las Armas");

            for (int i = 0; i < Armas.Length; i++)
            {
                Console.WriteLine("Ingrese La durabilidad que posee el Arma", Armas[i]);
                Durabilidad[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine("1: Inspeccionar Armas criticas");
            Console.WriteLine("2: Ver arsenal completo");
            int Eleccion = int.Parse(Console.ReadLine());
            switch (Eleccion)
            {
                case 1:
                   
                    for (int i = 0; i < Armas.Length; i++)
                    {
                        if (Durabilidad[i] < 20)
                        {
                            Console.WriteLine($"El Arma {Armas[i]} se encuentra en Durabilidad Critica.");
                        }
                        else
                        {
                            Console.WriteLine($"El Arma {Armas[i]} esta en perfectas condiciones");
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < Durabilidad.Length; i++)
                    {
                        Console.WriteLine($"El arma {Armas[i]} cuenta con {Durabilidad[i]}");
                    }
                    break;
            }

        }

    }
}
    


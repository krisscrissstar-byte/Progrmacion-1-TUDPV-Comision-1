using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJultimo
    {
        static void Main(string[] args)
        {
            int[] EXP = new int[5];
            int ExperienciaTotal = 0;

            // Cargar la EXP de las 5 misiones
            for (int i = 0; i < EXP.Length; i++)
            {
                Console.WriteLine("Ingrese la EXP obtenida en la misión " + (i + 1) + ":");
                EXP[i] = int.Parse(Console.ReadLine());
            }

            // Aplicar el bono
            for (int i = 0; i < EXP.Length; i++)
            {
                if (EXP[i] > 100)
                {
                    EXP[i] = (int)(EXP[i] * 1.20);

                    Console.WriteLine( "La misión " + (i + 1) + " superó los 100 puntos y recibió un bono del 20%." );
                }
                else
                {
                    Console.WriteLine(
                        "La misión " + (i + 1) + " no superó los 100 puntos." );
                }

                ExperienciaTotal = ExperienciaTotal + EXP[i];
            }

            // Mostrar la tabla actualizada
            Console.WriteLine("--- EXP DE LAS MISIONES ---");

            for (int i = 0; i < EXP.Length; i++)
            {
                Console.WriteLine(
                    "Misión " + (i + 1) + ": " + EXP[i] + " EXP" );
            }

            Console.WriteLine( "Experiencia total acumulada: " + ExperienciaTotal);

        }

    }
}
   

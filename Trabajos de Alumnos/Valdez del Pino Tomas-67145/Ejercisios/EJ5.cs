using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class EJ5
    {
        static void Main(string[] args)
        {
            int[] DañoDeFlecha = new int[6];
            int DañoTanqueable;
            int DañoTotal = 0;
            for (int i=0; i < DañoDeFlecha.Length; i++) 
            {
                Console.WriteLine("Cuanto daño hace la flecha numero:" + (i+1));
                DañoDeFlecha[i] = int.Parse(Console.ReadLine());
            }

            // Pedir el daño de referencia
            Console.WriteLine("Ingrese el daño de referencia:");
            DañoTanqueable = int.Parse(Console.ReadLine());

            int i2 = 0;

            while (i2 < DañoDeFlecha.Length )
            {
                if (DañoDeFlecha[i2] > DañoTanqueable)
                {
                    Console.WriteLine("La flecha " + (i2 + 1) +
                        " superó el daño de referencia con " + DañoDeFlecha[i2] + " de daño.");

                    DañoTotal = DañoTotal + DañoDeFlecha[i2];
                }
                else
                {
                    Console.WriteLine("La flecha " + (i2 + 1) +
                        " no superó el daño de referencia.");
                }

                i2++;
            }

            Console.WriteLine("El daño total filtrado es: " + DañoTotal);
        }
    }

    
}
    

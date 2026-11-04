using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class Ej4
    {
        static void Main(string[] args)
        {
           string[] CartasName = {"Carta de +10 de daño","Carta de invocacion","Carta de veneno","Carta de cellado","Carta cartosa" };
            int[] CartasPrecio = { 100, 200, 1569,12,67 };

            Console.WriteLine("Cuantas gemas tiene usted?");
            int gemasJugador = int.Parse(Console.ReadLine());

            Console.WriteLine("Que le gustaria hacer?");
            Console.WriteLine("1) Ver que cartas se puede costear");
            Console.WriteLine("2) Ver cual es la carta mas cara");
            int Eleccion = int.Parse(Console.ReadLine());

            switch (Eleccion) 
            {
                case 1:
                    for (int i =0; i < CartasPrecio.Length; i++) 
                    { 
                      if (gemasJugador >= CartasPrecio[i]) 
                        {
                            Console.WriteLine("Usted se puede costear la "+ CartasName[i] + " ya que su valor es de " + CartasPrecio[i]);
                        }
                        else 
                        {
                            Console.WriteLine("La "+ CartasName[i] + " es muy cara para usted");
                        }
                    }break;

                case 2:

                    int mayor = CartasPrecio[0];
                    string nombre = CartasName[0];
                    for (int n =0; n < CartasPrecio.Length; n++) 
                    { 
                      if (CartasPrecio[n] > mayor)
                        {
                            mayor = CartasPrecio[n];
                            nombre = CartasName[n];
                        }
                    }
                    Console.WriteLine("La " + nombre + " es la carta mas cara. Con un valor de " + mayor + " gemas");

                    break;
            }
            

        }

    }
}
    
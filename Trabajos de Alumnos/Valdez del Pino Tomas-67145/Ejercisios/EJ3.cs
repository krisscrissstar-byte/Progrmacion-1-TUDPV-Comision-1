using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Valdez_del_Pino_Tomas_67145
{
    internal class Ej3
    {
      static void Main(string[] args) 
        {
          int[] Slime = {30, 40, 50, 60};
            int i = 0;
            while (Slime[0] > 0 || Slime[1] > 0 || Slime[2] > 0 || Slime[3] > 0)
            {
                Console.WriteLine("A que enemigo le gustaria atacar");
                Console.WriteLine("Slime 0, 1, 2 o 3?");
                int Eleccion = int.Parse(Console.ReadLine());

                if (Slime[Eleccion] > 0)
                {
                    switch (Eleccion)
                    {
                        case 0:
                            Slime[0] = Slime[0] - 20;
                            Console.WriteLine("Al Slime le quedan " + Slime[0] + " Puntos de Vida");
                            break;

                        case 1:
                            Slime[1] = Slime[1] - 20;
                            Console.WriteLine("Al Slime le quedan " + Slime[1] + " Puntos de Vida");
                            break;

                        case 2:
                            Slime[2] = Slime[2] - 20;
                            Console.WriteLine("Al Slime le quedan " + Slime[2] + " Puntos de Vida");
                            break;

                        case 3:
                            Slime[3] = Slime[3] - 20;
                            Console.WriteLine("Al Slime le quedan " + Slime[3] + " Puntos de Vida");
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("El enemigo ya fue derrotado");
                }
               
                
            } 
        }   

        

    }
}
    


using System;
using System.Collections.Generic;
using System.Text;

namespace Pac_Man_Main
{
    internal class Inky : Fantasma
    {
        public Inky(string nombre, string color)
            :base(nombre, color) 
        {
           
        }

        public override void Moverse()
        {
            Console.WriteLine($"{this.nombre} (Inky) calcula la posicion de Pac-Man y realiza una emboscada");
        }


    }
}

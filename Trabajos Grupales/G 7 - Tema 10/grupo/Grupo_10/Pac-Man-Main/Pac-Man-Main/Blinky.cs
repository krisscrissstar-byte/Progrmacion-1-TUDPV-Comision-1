using System;
using System.Collections.Generic;
using System.Text;

namespace Pac_Man_Main
{
    internal class Blinky : Fantasma
    {
        //Para poder modificar la velocidad creamos el metodo "velocidad"
        protected float velocidad;
        //Creamos el constructor que hereda de la clase "Fantasma"
        public Blinky (string nombre, string color, float velocidad) 
            : base(nombre, color)
        {
            this.velocidad = velocidad;
        }

        //Modificamos el metodo virtual usando override
        public override void Moverse()
        {

            Console.WriteLine($"{this.nombre} (Blinky) persigue directamente a Pac-Man a una velocidad de {this.velocidad}");

        }




    }
}

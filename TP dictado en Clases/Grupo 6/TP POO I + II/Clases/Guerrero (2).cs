using System;
using System.Collections.Generic;
using System.Text;

namespace TP_POO_I___II.Clases
{
    internal class Guerrero : Personaje
    {
        protected int FuerzaFisica;

        public Guerrero(string nombre, int vida, int fuerza) : base(nombre, vida)
        {
            this.FuerzaFisica = fuerza;
        }

        public override void Atacar(Personaje objetivo)
        {
            Console.WriteLine($"{this.nombre} (Guerrero) ataca con su espada a {objetivo.GetNombre()}" +
                $" y causa {this.FuerzaFisica} de daño.");
            objetivo.RecibirDanio(this.FuerzaFisica);
        }
    }
}

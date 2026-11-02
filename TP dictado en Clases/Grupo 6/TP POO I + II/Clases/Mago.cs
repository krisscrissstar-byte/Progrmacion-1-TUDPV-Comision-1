using System;
using System.Collections.Generic;
using System.Text;

namespace TP_POO_I___II.Clases
{
    internal class Mago : Personaje
    {
        private int mana;
        public int Mana
        {
            get { return mana; }

            set
            {
                if (value >= 0)
                {
                     mana = value;
                }
            }
        }

        public Mago(string nombre, int vida, int mana) : base(nombre, vida)
        {
            this.mana = mana;
        }

        public override void Atacar(Personaje objetivo)
        {
            if (this.mana >= 10)
            {
                this.mana -= 10;
                Console.WriteLine($"{this.nombre} (Mago) lanza un hechizo a {objetivo.GetNombre()}," +
                    $" gasta 10 de maná y causa 30 de daño.");
                objetivo.RecibirDanio(30);
                
            }
            else
            {
                objetivo.RecibirDanio(5);
                Console.WriteLine($"{this.nombre} (Mago) no tiene suficiente maná. " +
                    $"Hace un golpe débil a {objetivo.GetNombre()} causando 5 de daño.");
            }
        }
    }
}

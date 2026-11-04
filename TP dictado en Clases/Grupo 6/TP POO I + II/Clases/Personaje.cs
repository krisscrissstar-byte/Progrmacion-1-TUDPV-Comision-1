using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TP_POO_I___II.Clases
{
    internal class Personaje
    {
        protected string nombre;
        protected int vida;

        public Personaje(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public virtual void Atacar(Personaje objetivo)
        {
            objetivo.RecibirDanio(10);
        }

        public void RecibirDanio(int cantidad)
        {
            this.vida -= cantidad;
            if (this.vida < 0)
            {
                this.vida = 0;
            }
            Console.WriteLine($"{this.nombre} recibe {cantidad} de daño. Vida restante: {this.vida}");
        }

        public bool EstaVivo()
        {
            return this.vida > 0;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tema3Pokemon
{
    public abstract class Pokemon
    {
        protected string apodo;
        protected int salud;
        protected int nivel;

        // Propiedad 'Salud' controlada estrictamente en el rango [0, 100]
        public int Salud
        {
            get { return salud; }
            set
            {
                if (value < 0)
                    salud = 0;
                else if (value > 100)
                    salud = 100;
                else
                    salud = value;
            }
        }

        public string Apodo => apodo;
        public int Nivel => nivel;

        // Constructor parametrizado usando 'this'
        public Pokemon(string apodo, int salud, int nivel)
        {
            this.apodo = apodo;
            this.Salud = salud; // Validación mediante la propiedad
            this.nivel = nivel;
        }

        // Método virtual para polimorfismo
        public virtual void Atacar()
        {
            Console.WriteLine($"{apodo} realiza un ataque básico.");
        }
    }
}

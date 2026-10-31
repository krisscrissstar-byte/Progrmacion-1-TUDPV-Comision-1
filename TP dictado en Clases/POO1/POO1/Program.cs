using System;

namespace Juego
{
    class Personaje
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

        public void RecibirDanio(int cant)
        {
            this.vida -= cant;
            if (this.vida < 0)
                this.vida = 0;
        }

        public bool EstaVivo()
        {
            return this.vida > 0;
        }
    }

    class Guerrero : Personaje
    {
        private int fuerzaFisica;

        public Guerrero(string nombre, int vida, int fuerzaFisica) : base(nombre, vida)
        {
            this.fuerzaFisica = fuerzaFisica;
        }

        public override void Atacar(Personaje objetivo)
        {
            objetivo.RecibirDanio(this.fuerzaFisica);
            
        }
    }

    class Mago : Personaje
    {
        private int mana;

        public Mago(string nombre, int vida, int mana) : base(nombre, vida)
        {
            this.mana = mana;
        }

        public override void Atacar(Personaje objetivo)
        {
            if (this.mana >= 10)
            {
                this.mana -= 10;
                objetivo.RecibirDanio(30);
            }
            else
            {
                objetivo.RecibirDanio(5);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Guerrero guerrero = new Guerrero("Aragorn", 100, 25);
            Mago mago = new Mago("Gandalf", 60, 30);

            Personaje[] grupo = new Personaje[] { guerrero, mago };

            Console.WriteLine("=== ESTADO INICIAL ===");

            Console.WriteLine("\n=== RONDA DE COMBATE ===");

            grupo[0].Atacar(grupo[1]);

            grupo[1].Atacar(grupo[0]);

            grupo[0].Atacar(grupo[1]);

            grupo[1].Atacar(grupo[0]);

            Console.WriteLine("\n=== ESTADO FINAL ===");
            }
        }
    }

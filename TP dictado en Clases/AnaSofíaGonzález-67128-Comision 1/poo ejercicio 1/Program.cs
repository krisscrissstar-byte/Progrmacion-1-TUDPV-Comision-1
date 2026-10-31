using System;
namespace Combate
{
    public class personaje
    {
        protected string nombre;
        protected int vida;

        public personaje(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public virtual void atacar(personaje objetivo)
        {
            int danio = 10;
            Console.WriteLine($"{this.nombre} atacar a {objetivo.nombre} causando {danio} de daño base");
            objetivo.vida -= danio;
            if (objetivo.vida < 0) { objetivo.vida = 0; }
        }

        public void RecibirDanio(int cantidad)
        {
            this.vida -= 10;

            if (this.vida < 0)
            {
                this.vida = 0;
            }
            Console.WriteLine($"{this.nombre} recibe {cantidad} de daño. Vida restante: {this.vida}");
        }

        public bool EstaVivo()
        {
            return this.vida < 0;
        }
        public string Getnombre() => nombre;
        public int Getvida() => vida;

    }
    public class guerrero : personaje
    {
        private int fuerzaFisica;

        public guerrero(string nombre, int vida, int fuerzaFisica) : base(nombre, vida)
        {
            this.fuerzaFisica = fuerzaFisica;
        }

        public override void atacar(personaje objetivo)
        {
            Console.WriteLine($"{this.nombre} (guerrero) ataca a {objetivo.Getnombre()}");
            objetivo.RecibirDanio(this.fuerzaFisica);
        }
    }

    public class mago : personaje
    {
        private int mana;
        public mago(string nombre, int vida, int mana) : base(nombre, vida)
        {
            this.mana = mana;
        }
        public override void atacar(personaje objetivo)
        {
            if (this.mana >= 10)
            {
                this.mana -= 10;
                int daniomana = 30;
                Console.WriteLine($"{this.nombre} (mago) ataca a {objetivo.Getnombre()}");
                objetivo.RecibirDanio(this.mana);
            }
            else
            {
                int golpedebil = 5;
                Console.WriteLine($"{this.nombre} (mago) ataca a {objetivo.Getnombre()} con un golpe débil");
                objetivo.RecibirDanio(golpedebil);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            guerrero guerrero1 = new guerrero("Guerrero", 100, 20);
            mago mago1 = new mago("Mago", 80, 50);
            personaje[] grupo = new personaje[] {guerrero1, mago1};
            guerrero1.atacar(mago1);
            mago1.atacar(guerrero1);
            Console.WriteLine($"{guerrero1.Getnombre()} tiene {guerrero1.Getvida()} de vida restante.");
            Console.WriteLine($"{mago1.Getnombre()} tiene {mago1.Getvida()} de vida restante.");
        }
    }
}


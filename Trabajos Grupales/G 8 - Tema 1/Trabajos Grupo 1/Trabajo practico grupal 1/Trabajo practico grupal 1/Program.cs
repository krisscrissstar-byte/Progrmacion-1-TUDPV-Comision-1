using System;

namespace SistemaCombateRPG
{
    public class Personaje
    {
        protected string nombre;
        protected int vida;

        public Personaje(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public string Nombre => nombre;
        public int Vida => vida;

        public virtual void Atacar(Personaje objetivo)
        {
            int danioBase = 10;
            Console.WriteLine($"{this.nombre} realiza un ataque básico a {objetivo.Nombre} infligiendo {danioBase} de daño.");
            objetivo.RecibirDanio(danioBase);
        }

        public void RecibirDanio(int cant)
        {
            this.vida -= cant;
            if (this.vida < 0)
            {
                this.vida = 0;
            }
        }

        public bool EstaVivo()
        {
            return this.vida > 0;
        }
    }

    public class Guerrero : Personaje
    {
        private int fuerzaFisica;

        public Guerrero(string nombre, int vida, int fuerzaFisica) : base(nombre, vida)
        {
            this.fuerzaFisica = fuerzaFisica;
        }

        public override void Atacar(Personaje objetivo)
        {
            Console.WriteLine($"[GUERRERO] {this.nombre} ataca con su espada a {objetivo.Nombre} infligiendo {this.fuerzaFisica} de daño físico.");
            objetivo.RecibirDanio(this.fuerzaFisica);
        }
    }

    public class Mago : Personaje
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
                int danioHechizo = 30;
                Console.WriteLine($"[MAGO] {this.nombre} lanza un hechizo a {objetivo.Nombre} infligiendo {danioHechizo} de daño. Maná restante: {this.mana}.");
                objetivo.RecibirDanio(danioHechizo);
            }
            else
            {
                int danioDebil = 5;
                Console.WriteLine($"[MAGO] {this.nombre} no tiene suficiente maná. Realiza un golpe débil a {objetivo.Nombre} infligiendo {danioDebil} de daño.");
                objetivo.RecibirDanio(danioDebil);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DATOS DEL GUERRERO ===");
            Console.Write("Ingrese el nombre del Guerrero: ");
            string nombreG = Console.ReadLine();

            Console.Write("Ingrese la vida del Guerrero: ");
            int vidaG = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la fuerza física del Guerrero: ");
            int fuerzaG = int.Parse(Console.ReadLine());

            Guerrero guerrero = new Guerrero(nombreG, vidaG, fuerzaG);

            Console.WriteLine("\n=== DATOS DEL MAGO ===");
            Console.Write("Ingrese el nombre del Mago: ");
            string nombreM = Console.ReadLine();

            Console.Write("Ingrese la vida del Mago: ");
            int vidaM = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el maná del Mago: ");
            int manaM = int.Parse(Console.ReadLine());

            Mago mago = new Mago(nombreM, vidaM, manaM);

            Personaje[] grupo = new Personaje[] { guerrero, mago };

            Console.WriteLine("\n=== ESTADO INICIAL ===");
            foreach (Personaje p in grupo)
            {
                Console.WriteLine($"{p.Nombre} - Vida: {p.Vida}");
            }

            Console.WriteLine("\n=== SIMULACIÓN DE COMBATE ===");
            grupo[0].Atacar(grupo[1]);
            grupo[1].Atacar(grupo[0]);

            Console.WriteLine("\n=== ESTADO RESULTANTE ===");
            foreach (Personaje p in grupo)
            {
                string estado = p.EstaVivo() ? "Vivo" : "Derrotado";
                Console.WriteLine($"{p.Nombre} - Vida restante: {p.Vida} ({estado})");
            }

            Console.ReadLine();
        }
    }
}
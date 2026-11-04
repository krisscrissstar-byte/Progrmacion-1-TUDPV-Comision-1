using System;

namespace SistemaSuperMario
{
    public class PersonajeMario
    {
        protected string nombre;
        protected int vidas;
        protected int monedas;

        public PersonajeMario(string nombre, int vidas, int monedas)
        {
            this.nombre = nombre;
            this.vidas = vidas;
            this.monedas = monedas;
        }

        public string Nombre => nombre;
        public int Monedas
        {
            get => monedas;
            set => monedas = value;
        }

        public int Vidas
        {
            get => vidas;
            set
            {
                vidas = value;
                if (vidas <= 0)
                {
                    vidas = 0;
                    Console.WriteLine($"[GAME OVER] ¡{nombre} se ha quedado sin vidas!");
                }
            }
        }

        public virtual void Saltar()
        {
            Console.WriteLine($"{nombre} realiza un salto estándar.");
        }

        public void RecibirDanio()
        {
            Vidas--;
            Console.WriteLine($"{nombre} ha recibido daño. Vidas restantes: {vidas}");
        }
    }

    public class Mario : PersonajeMario
    {
        private string estadoTransformacion;

        public Mario(string nombre, int vidas, int monedas, string estadoTransformacion)
            : base(nombre, vidas, monedas)
        {
            this.estadoTransformacion = estadoTransformacion;
        }

        public override void Saltar()
        {
            Console.WriteLine($"[MARIO] {nombre} ({estadoTransformacion}) salta con agilidad alcanzando 2 bloques de altura.");
        }
    }

    public class Luigi : PersonajeMario
    {
        public Luigi(string nombre, int vidas, int monedas)
            : base(nombre, vidas, monedas)
        {
        }

        public override void Saltar()
        {
            Console.WriteLine($"[LUIGI] {nombre} realiza un salto con mayor altura flotante, pero menor tracción al aterrizar.");
        }
    }

    public class BloqueInterrogacion
    {
        private bool abierto;

        public BloqueInterrogacion()
        {
            this.abierto = false;
        }

        public void Golpear(PersonajeMario pj)
        {
            if (!abierto)
            {
                abierto = true;
                pj.Monedas += 1;
                Console.WriteLine($"¡Bloque golpeado por {pj.Nombre}! El bloque se vacía y entrega 1 moneda. Monedas totales: {pj.Monedas}");
            }
            else
            {
                Console.WriteLine($"El bloque ya está abierto y vacío. {pj.Nombre} lo golpea, pero no pasa nada.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PersonajeMario[] hermanos = new PersonajeMario[]
            {
                new Mario("Mario", 3, 0, "Super"),
                new Luigi("Luigi", 3, 0)
            };

            BloqueInterrogacion bloque1 = new BloqueInterrogacion();
            BloqueInterrogacion bloque2 = new BloqueInterrogacion();

            Console.WriteLine("=== PRUEBA DE SALTO ===");
            foreach (PersonajeMario hermano in hermanos)
            {
                hermano.Saltar();
            }

            Console.WriteLine("\n=== INTERACCIÓN CON BLOQUES DE INTERROGACIÓN ===");
            bloque1.Golpear(hermanos[0]);

            bloque1.Golpear(hermanos[0]);

            bloque2.Golpear(hermanos[1]);

            Console.WriteLine("\n=== PRUEBA DE VIDAS Y GAME OVER ===");
            hermanos[1].RecibirDanio();
            hermanos[1].RecibirDanio();
            hermanos[1].RecibirDanio();

            Console.ReadLine();
        }
    }
}
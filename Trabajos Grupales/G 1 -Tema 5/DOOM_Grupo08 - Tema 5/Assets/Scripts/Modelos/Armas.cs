// ============================================================
//  DOOM CLASICO - Armas.cs
//  Aca estan las armas del jugador y los objetos que se
//  recogen en el mapa (botiquines, armaduras y cajas de municion).
//
//  POO 1: clases, atributos, constructores, metodos y
//         encapsulamiento (campos protected con get).
//  POO 2: herencia y polimorfismo (cada arma calcula su dano
//         distinto, cada objeto hace un efecto distinto).
//
//  Este archivo usa la clase "Jugador" que esta en Personajes.cs
// ============================================================
using System;

namespace DoomSimple
{
    // CLASE BASE de todas las armas
    public class Arma
    {
        // "protected" = solo esta clase y sus hijas pueden tocar estos datos
        protected string nombre;
        protected int danioMinimo;
        protected int danioMaximo;
        protected int alcance;          // a cuantas casillas llega
        protected bool usaMunicion;     // true = gasta balas, false = cuerpo a cuerpo
        protected int costoMunicion;    // cuantas balas gasta por ataque
        protected static Random azar = new Random();

        public Arma(string nombre, int danioMinimo, int danioMaximo, int alcance, bool usaMunicion, int costoMunicion)
        {
            this.nombre = nombre;
            this.danioMinimo = danioMinimo;
            this.danioMaximo = danioMaximo;
            this.alcance = alcance;
            this.usaMunicion = usaMunicion;
            this.costoMunicion = costoMunicion;
        }

        // Desde afuera estos datos solo se pueden leer
        public string Nombre
        {
            get { return nombre; }
        }

        public int Alcance
        {
            get { return alcance; }
        }

        public bool UsaMunicion
        {
            get { return usaMunicion; }
        }

        public int CostoMunicion
        {
            get { return costoMunicion; }
        }

        // Devuelve un numero al azar entre el dano minimo y el maximo.
        // "virtual" porque alguna arma hija lo puede cambiar.
        public virtual int CalcularDanio()
        {
            return azar.Next(danioMinimo, danioMaximo + 1);
        }
    }

    // MOTOSIERRA: no gasta municion, solo sirve de cerca
    public class Motosierra : Arma
    {
        public Motosierra() : base("Motosierra", 15, 30, 1, false, 0)
        {
        }
    }

    // PISTOLA: gasta 1 bala, llega lejos
    public class Pistola : Arma
    {
        public Pistola() : base("Pistola", 5, 15, 8, true, 1)
        {
        }
    }

    // ESCOPETA: gasta 2 balas, hace mucho dano de cerca
    public class Escopeta : Arma
    {
        public Escopeta() : base("Escopeta", 0, 0, 4, true, 2)
        {
        }

        // override: la escopeta tira 5 perdigones y suma el dano de todos
        public override int CalcularDanio()
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total = total + azar.Next(4, 9);
            }
            return total;
        }
    }

    // CLASE BASE de los objetos que estan tirados en el mapa
    public class Objeto
    {
        protected int x;
        protected int y;
        protected char simbolo;   // letra con la que se dibuja

        public Objeto(int x, int y, char simbolo)
        {
            this.x = x;
            this.y = y;
            this.simbolo = simbolo;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public char Simbolo
        {
            get { return simbolo; }
        }

        // Cada objeto hijo hace algo distinto cuando el jugador lo agarra
        public virtual string Usar(Jugador jugador)
        {
            return "Agarraste un objeto.";
        }
    }

    // BOTIQUIN: devuelve vida
    public class Botiquin : Objeto
    {
        public Botiquin(int x, int y) : base(x, y, '+')
        {
        }

        public override string Usar(Jugador jugador)
        {
            jugador.Curar(25);
            return "Agarraste un botiquin: +25 de vida.";
        }
    }

    // CAJA DE MUNICION: suma balas
    public class CajaMunicion : Objeto
    {
        public CajaMunicion(int x, int y) : base(x, y, 'a')
        {
        }

        public override string Usar(Jugador jugador)
        {
            jugador.Municion = jugador.Municion + 20;
            return "Agarraste una caja de municion: +20 balas.";
        }
    }

    // ARMADURA: suma puntos de armadura
    public class ObjetoArmadura : Objeto
    {
        public ObjetoArmadura(int x, int y) : base(x, y, 'A')
        {
        }

        public override string Usar(Jugador jugador)
        {
            jugador.Armadura = jugador.Armadura + 50;
            return "Agarraste una armadura: +50.";
        }
    }
}

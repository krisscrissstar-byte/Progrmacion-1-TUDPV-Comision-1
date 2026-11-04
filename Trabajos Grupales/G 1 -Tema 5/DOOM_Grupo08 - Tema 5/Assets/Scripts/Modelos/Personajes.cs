// ============================================================
//  DOOM CLASICO - Personajes.cs
//  Aca estan los personajes del juego: el jugador y los enemigos.
//
//  POO 1: clases, atributos, constructores, metodos y
//         encapsulamiento (campos private/protected con get y set).
//  POO 2: herencia (Jugador y Enemigo heredan de Personaje)
//         y polimorfismo (cada enemigo ataca distinto con override).
//
//  Este archivo usa la clase "Arma" que esta en Armas.cs
// ============================================================
using System;

namespace DoomSimple
{
    // CLASE BASE: todo personaje tiene nombre, vida y una posicion en el mapa.
    public class Personaje
    {
        // "protected" = solo la propia clase y sus hijas pueden tocar estos datos
        protected string nombre;
        protected int vida;
        protected int x;   // columna en el mapa
        protected int y;   // fila en el mapa

        // Constructor: se ejecuta cuando creamos un personaje nuevo
        public Personaje(string nombre, int vida, int x, int y)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.x = x;
            this.y = y;
        }

        // Propiedades: desde afuera solo se pueden LEER (get), no cambiar
        public string Nombre
        {
            get { return nombre; }
        }

        public int Vida
        {
            get { return vida; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        // La unica forma de cambiar la posicion es con este metodo
        public void MoverA(int nuevoX, int nuevoY)
        {
            x = nuevoX;
            y = nuevoY;
        }

        // "virtual" significa que las clases hijas pueden cambiar este metodo
        public virtual void RecibirDanio(int danio)
        {
            if (danio < 0)
            {
                danio = 0;   // un dano negativo no puede curar
            }

            vida = vida - danio;
            if (vida < 0)
            {
                vida = 0;    // la vida nunca queda negativa
            }
        }

        // Devuelve true si el personaje todavia tiene vida
        public bool EstaVivo()
        {
            return vida > 0;
        }
    }

    // JUGADOR: hereda de Personaje y agrega armadura, municion y armas.
    public class Jugador : Personaje
    {
        private int armadura;
        private int municion;
        private int puntos;
        private Arma[] armas;      // lista de armas que tiene
        private int armaActual;    // posicion del arma que esta usando (0, 1 o 2)

        public Jugador(int x, int y) : base("Doomguy", 100, x, y)
        {
            armadura = 0;
            municion = 30;
            puntos = 0;

            // El jugador arranca con 3 armas (definidas en Armas.cs)
            armas = new Arma[3];
            armas[0] = new Motosierra();
            armas[1] = new Pistola();
            armas[2] = new Escopeta();
            armaActual = 1;
        }

        // Propiedad con get y set: el set valida que el valor sea correcto
        public int Armadura
        {
            get { return armadura; }
            set
            {
                if (value < 0)
                {
                    armadura = 0;
                }
                else if (value > 200)
                {
                    armadura = 200;   // maximo de armadura
                }
                else
                {
                    armadura = value;
                }
            }
        }

        public int Municion
        {
            get { return municion; }
            set
            {
                if (value < 0)
                {
                    municion = 0;     // no puede haber municion negativa
                }
                else
                {
                    municion = value;
                }
            }
        }

        // Los puntos solo se pueden leer; para sumar se usa SumarPuntos
        public int Puntos
        {
            get { return puntos; }
        }

        // Devuelve el arma que el jugador tiene equipada
        public Arma ArmaEquipada
        {
            get { return armas[armaActual]; }
        }

        public void SumarPuntos(int cantidad)
        {
            if (cantidad > 0)
            {
                puntos = puntos + cantidad;
            }
        }

        // override: cambiamos el metodo del padre porque el jugador tiene armadura.
        // La armadura absorbe la mitad del dano mientras le quede.
        public override void RecibirDanio(int danio)
        {
            if (armadura > 0)
            {
                int absorbido = danio / 2;
                if (absorbido > armadura)
                {
                    absorbido = armadura;
                }
                armadura = armadura - absorbido;
                danio = danio - absorbido;
            }
            base.RecibirDanio(danio);   // llama al metodo del padre
        }

        public void Curar(int cantidad)
        {
            if (cantidad < 0)
            {
                return;   // no se puede curar una cantidad negativa
            }

            vida = vida + cantidad;
            if (vida > 100)
            {
                vida = 100;   // la vida maxima es 100
            }
        }

        public void CambiarArma(int posicion)
        {
            if (posicion >= 0 && posicion < armas.Length)
            {
                armaActual = posicion;
            }
        }

        // El jugador ataca a un enemigo con el arma que tiene equipada.
        // Devuelve un texto para mostrar en pantalla.
        public string Atacar(Enemigo enemigo)
        {
            Arma arma = armas[armaActual];

            if (arma.UsaMunicion == true && municion < arma.CostoMunicion)
            {
                return "No tenes municion!";
            }

            if (arma.UsaMunicion == true)
            {
                municion = municion - arma.CostoMunicion;
            }

            int danio = arma.CalcularDanio();
            enemigo.RecibirDanio(danio);
            return "Atacas con " + arma.Nombre + " y haces " + danio + " de dano.";
        }
    }

    // ENEMIGO: hereda de Personaje. Es la base de todos los monstruos.
    public class Enemigo : Personaje
    {
        private int alcance;     // a cuantas casillas puede atacar
        private int puntos;      // puntos que da al morir
        private char simbolo;    // letra con la que se dibuja en el mapa
        protected static Random azar = new Random();

        public Enemigo(string nombre, int vida, int alcance, int puntos, char simbolo, int x, int y)
            : base(nombre, vida, x, y)
        {
            this.alcance = alcance;
            this.puntos = puntos;
            this.simbolo = simbolo;
        }

        public int Alcance
        {
            get { return alcance; }
        }

        public int Puntos
        {
            get { return puntos; }
        }

        public char Simbolo
        {
            get { return simbolo; }
        }

        // Los enemigos hijos van a cambiar este metodo (polimorfismo)
        public virtual string Atacar(Jugador jugador)
        {
            jugador.RecibirDanio(1);
            return nombre + " te golpea.";
        }
    }

    // ZOMBIE: poca vida, dispara de lejos con dano bajo
    public class Zombie : Enemigo
    {
        public Zombie(int x, int y) : base("Zombie", 20, 6, 100, 'Z', x, y)
        {
        }

        public override string Atacar(Jugador jugador)
        {
            int danio = azar.Next(3, 8);
            jugador.RecibirDanio(danio);
            return "El Zombie te dispara: -" + danio;
        }
    }

    // IMP: vida media, tira bolas de fuego
    public class Imp : Enemigo
    {
        public Imp(int x, int y) : base("Imp", 60, 5, 200, 'I', x, y)
        {
        }

        public override string Atacar(Jugador jugador)
        {
            int danio = azar.Next(6, 15);
            jugador.RecibirDanio(danio);
            return "El Imp te tira fuego: -" + danio;
        }
    }

    // DEMONIO: mucha vida, solo ataca de cerca
    public class Demonio : Enemigo
    {
        public Demonio(int x, int y) : base("Demonio", 120, 1, 400, 'D', x, y)
        {
        }

        public override string Atacar(Jugador jugador)
        {
            int danio = azar.Next(10, 19);
            jugador.RecibirDanio(danio);
            return "El Demonio te muerde: -" + danio;
        }
    }
}

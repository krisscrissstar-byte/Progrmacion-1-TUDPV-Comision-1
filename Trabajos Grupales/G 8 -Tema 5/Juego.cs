// ============================================================
//  DOOM CLASICO - Juego.cs
//  Aca esta el mapa, las reglas del juego y el Main
//  (el lugar donde empieza el programa).
//
//  La clase Juego es la GESTORA: guarda las colecciones de
//  enemigos y de objetos (List) y controla todo lo que pasa.
//
//  POO 1: clase con atributos private y varios metodos.
//  POO 2: usamos las clases hijas como si fueran del padre
//         (una lista de Enemigo con Zombie, Imp y Demonio adentro,
//          una lista de Objeto con Botiquin, CajaMunicion, etc.)
//
//  Usa las clases de Personajes.cs y de Armas.cs
//
//  CONTROLES: W A S D = mover | F = atacar | 1 2 3 = cambiar arma | Q = salir
//  OBJETIVO: matar a todos los enemigos y llegar a la salida (E)
// ============================================================
using System;
using System.Collections.Generic;

namespace DoomSimple
{
    public class Juego
    {
        // El mapa: # es pared, . es piso, E es la salida
        private string[] mapa = new string[]
        {
            "####################",
            "#..................#",
            "#..####....####....#",
            "#..#..........#....#",
            "#..#..........#....#",
            "#..####....####....#",
            "#..................#",
            "#....##......##....#",
            "#..................#",
            "#################E##"
        };

        private Jugador jugador;
        private List<Enemigo> enemigos;
        private List<Objeto> objetos;
        private List<string> mensajes;   // textos que se muestran en cada turno

        // Constructor: prepara el juego con todo en su lugar
        public Juego()
        {
            jugador = new Jugador(1, 1);

            enemigos = new List<Enemigo>();
            enemigos.Add(new Zombie(10, 3));
            enemigos.Add(new Zombie(15, 6));
            enemigos.Add(new Imp(17, 2));
            enemigos.Add(new Imp(8, 8));
            enemigos.Add(new Demonio(14, 8));

            objetos = new List<Objeto>();
            objetos.Add(new Botiquin(3, 6));
            objetos.Add(new ObjetoArmadura(12, 1));
            objetos.Add(new CajaMunicion(6, 8));

            mensajes = new List<string>();
        }

        // Cuenta cuantos enemigos siguen vivos
        private int EnemigosVivos()
        {
            int cantidad = 0;
            for (int i = 0; i < enemigos.Count; i++)
            {
                if (enemigos[i].EstaVivo() == true)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        // Dice si hay un enemigo vivo en esa casilla
        private bool HayEnemigoEn(int x, int y)
        {
            for (int i = 0; i < enemigos.Count; i++)
            {
                if (enemigos[i].EstaVivo() == true && enemigos[i].X == x && enemigos[i].Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        // Dice si se puede caminar por esa casilla (no es pared ni esta fuera del mapa)
        private bool EsCaminable(int x, int y)
        {
            if (x < 0 || y < 0 || y >= mapa.Length || x >= mapa[0].Length)
            {
                return false;
            }
            return mapa[y][x] != '#';
        }

        // Mueve al jugador y agarra el objeto si hay uno
        private void MoverJugador(int dx, int dy)
        {
            int nuevoX = jugador.X + dx;
            int nuevoY = jugador.Y + dy;

            if (EsCaminable(nuevoX, nuevoY) == false || HayEnemigoEn(nuevoX, nuevoY) == true)
            {
                mensajes.Add("No podes pasar por ahi.");
                return;
            }

            jugador.MoverA(nuevoX, nuevoY);

            // Revisamos si hay un objeto en esa casilla
            for (int i = 0; i < objetos.Count; i++)
            {
                if (objetos[i].X == nuevoX && objetos[i].Y == nuevoY)
                {
                    mensajes.Add(objetos[i].Usar(jugador));   // polimorfismo
                    objetos.RemoveAt(i);
                    break;
                }
            }
        }

        // Distancia entre el jugador y un enemigo (sumando diferencia de columnas y filas)
        private int Distancia(Enemigo enemigo)
        {
            int difX = Math.Abs(jugador.X - enemigo.X);
            int difY = Math.Abs(jugador.Y - enemigo.Y);
            return difX + difY;
        }

        // El jugador ataca al enemigo vivo mas cercano que este dentro del alcance del arma
        private void AtacarJugador()
        {
            Enemigo elegido = null;
            int menorDistancia = 999;

            for (int i = 0; i < enemigos.Count; i++)
            {
                Enemigo e = enemigos[i];
                int d = Distancia(e);
                if (e.EstaVivo() == true && d <= jugador.ArmaEquipada.Alcance && d < menorDistancia)
                {
                    elegido = e;
                    menorDistancia = d;
                }
            }

            if (elegido == null)
            {
                mensajes.Add("No hay enemigos al alcance.");
                return;
            }

            mensajes.Add(jugador.Atacar(elegido));

            if (elegido.EstaVivo() == false)
            {
                jugador.SumarPuntos(elegido.Puntos);
                mensajes.Add("Mataste a " + elegido.Nombre + "! +" + elegido.Puntos + " puntos.");
            }
        }

        // Turno de los enemigos: si estan cerca atacan, si no se acercan
        private void TurnoEnemigos()
        {
            for (int i = 0; i < enemigos.Count; i++)
            {
                Enemigo e = enemigos[i];
                if (e.EstaVivo() == false)
                {
                    continue;   // si esta muerto, no hace nada
                }

                if (Distancia(e) <= e.Alcance)
                {
                    mensajes.Add(e.Atacar(jugador));   // polimorfismo: cada enemigo ataca distinto
                }
                else
                {
                    AcercarEnemigo(e);
                }
            }
        }

        // Mueve un enemigo un paso hacia el jugador
        private void AcercarEnemigo(Enemigo e)
        {
            int nuevoX = e.X;
            int nuevoY = e.Y;

            if (e.X < jugador.X) { nuevoX = e.X + 1; }
            else if (e.X > jugador.X) { nuevoX = e.X - 1; }
            else if (e.Y < jugador.Y) { nuevoY = e.Y + 1; }
            else if (e.Y > jugador.Y) { nuevoY = e.Y - 1; }

            bool esElJugador = (nuevoX == jugador.X && nuevoY == jugador.Y);
            if (EsCaminable(nuevoX, nuevoY) == true && HayEnemigoEn(nuevoX, nuevoY) == false && esElJugador == false)
            {
                e.MoverA(nuevoX, nuevoY);
            }
        }

        // Dibuja todo en la consola
        private void Dibujar()
        {
            Console.Clear();
            Console.WriteLine("=== DOOM CLASICO ===");

            for (int y = 0; y < mapa.Length; y++)
            {
                for (int x = 0; x < mapa[y].Length; x++)
                {
                    char simbolo = mapa[y][x];

                    for (int i = 0; i < objetos.Count; i++)
                    {
                        if (objetos[i].X == x && objetos[i].Y == y)
                        {
                            simbolo = objetos[i].Simbolo;
                        }
                    }

                    for (int i = 0; i < enemigos.Count; i++)
                    {
                        if (enemigos[i].EstaVivo() == true && enemigos[i].X == x && enemigos[i].Y == y)
                        {
                            simbolo = enemigos[i].Simbolo;
                        }
                    }

                    if (jugador.X == x && jugador.Y == y)
                    {
                        simbolo = '@';
                    }

                    Console.Write(simbolo);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Vida: " + jugador.Vida + "  Armadura: " + jugador.Armadura + "  Puntos: " + jugador.Puntos);
            Console.WriteLine("Arma: " + jugador.ArmaEquipada.Nombre + "  Municion: " + jugador.Municion);
            Console.WriteLine("Enemigos vivos: " + EnemigosVivos());
            Console.WriteLine("W A S D = mover | F = atacar | 1 2 3 = armas | Q = salir");
            Console.WriteLine("@ = vos | Z I D = enemigos | + A a = objetos | E = salida");
            Console.WriteLine();

            for (int i = 0; i < mensajes.Count; i++)
            {
                Console.WriteLine("> " + mensajes[i]);
            }
        }

        // Bucle principal del juego
        public void Jugar()
        {
            bool salir = false;
            bool gano = false;

            while (salir == false && jugador.EstaVivo() == true && gano == false)
            {
                Dibujar();
                mensajes.Clear();

                ConsoleKey tecla = Console.ReadKey(true).Key;
                bool gastoTurno = true;

                if (tecla == ConsoleKey.W) { MoverJugador(0, -1); }
                else if (tecla == ConsoleKey.S) { MoverJugador(0, 1); }
                else if (tecla == ConsoleKey.A) { MoverJugador(-1, 0); }
                else if (tecla == ConsoleKey.D) { MoverJugador(1, 0); }
                else if (tecla == ConsoleKey.F) { AtacarJugador(); }
                else if (tecla == ConsoleKey.D1) { jugador.CambiarArma(0); gastoTurno = false; }
                else if (tecla == ConsoleKey.D2) { jugador.CambiarArma(1); gastoTurno = false; }
                else if (tecla == ConsoleKey.D3) { jugador.CambiarArma(2); gastoTurno = false; }
                else if (tecla == ConsoleKey.Q) { salir = true; gastoTurno = false; }
                else { gastoTurno = false; }

                // Ganamos si no quedan enemigos y estamos parados en la salida
                if (EnemigosVivos() == 0 && mapa[jugador.Y][jugador.X] == 'E')
                {
                    gano = true;
                }

                if (gastoTurno == true && gano == false)
                {
                    TurnoEnemigos();
                }
            }

            Dibujar();
            Console.WriteLine();
            if (gano == true)
            {
                Console.WriteLine("GANASTE! Completaste el nivel.");
            }
            else if (jugador.EstaVivo() == false)
            {
                Console.WriteLine("Moriste... GAME OVER");
            }
            else
            {
                Console.WriteLine("Saliste del juego.");
            }
            Console.WriteLine("Puntaje final: " + jugador.Puntos);
        }
    }

    // Aca empieza el programa
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.Jugar();
        }
    }
}

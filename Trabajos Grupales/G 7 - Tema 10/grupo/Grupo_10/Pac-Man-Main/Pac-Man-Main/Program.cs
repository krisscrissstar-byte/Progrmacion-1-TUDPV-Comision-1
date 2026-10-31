using System;
using System.Collections.Generic;

namespace Pac_Man_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de personaje principal
            PacMan miPacMan = new PacMan("Pac-Man");

            //Declaracion individual de los fantasmas
            Blinky blinky = new Blinky("Blinky", "Rojo", 5.5f);
            Inky inky = new Inky("Inky", "Azul");

            //Creacion de lista de fantasmas
            List<Fantasma> fantasmas = new List<Fantasma>();
            fantasmas.Add(blinky);
            fantasmas.Add(inky);

            Console.WriteLine("---Simulacion de movimiento de fantasmas---");
            
            //Recorremos la lista (Cada fantasma se mueve segun su clase)
            foreach (Fantasma f in fantasmas)
            {
                f.Moverse();
                miPacMan.PerderVida();
            }

            //Simulamos las acciones de un jugador con pacman
            Console.WriteLine("---Acciones de Pacman---");
            miPacMan.ComerPunto(100);
            miPacMan.ComerPunto(250);
            miPacMan.ComerPildoraPoder(fantasmas);
            foreach(Fantasma f in fantasmas)
            {
                f.SerDevorado();
            }




        }


    }
}

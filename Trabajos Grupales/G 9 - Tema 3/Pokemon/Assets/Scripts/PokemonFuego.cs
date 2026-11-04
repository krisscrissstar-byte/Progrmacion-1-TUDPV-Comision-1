using System;
using System.Collections.Generic;
using System.Text;

namespace Tema3Pokemon
{
    public class PokemonFuego : Pokemon
    {
        public PokemonFuego(string apodo, int salud, int nivel) : base(apodo, salud, nivel) { }

        public override void Atacar()
        {
            int danio = nivel * 3;
            Console.WriteLine($"[FUEGO] [{apodo}] (Tipo Fuego - Nivel {nivel}) ejecuta Lanzallamas. Causando {danio} de daño ígneo.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Tema3Pokemon
{
    public class PokemonAgua : Pokemon
    {
        public PokemonAgua(string apodo, int salud, int nivel) : base(apodo, salud, nivel) { }

        public override void Atacar()
        {
            int danio = nivel * 2;
            Console.WriteLine($"[AGUA] [{apodo}] (Tipo Agua - Nivel {nivel}) ejecuta Pistola de Agua. Causando {danio} de daño por presión.");
        }
    }
}
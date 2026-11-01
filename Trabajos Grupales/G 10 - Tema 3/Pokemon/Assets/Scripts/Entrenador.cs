using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Tema3Pokemon
{
    public class Entrenador
    {
        private string nombre;
        private Pokemon[] equipo; // Array polimórfico de hasta 3 criaturas
        private int cantidadPokemones;

        public string Nombre => nombre;

        public Entrenador(string nombre)
        {
            this.nombre = nombre;
            this.equipo = new Pokemon[3];
            this.cantidadPokemones = 0;
        }

        public bool Capturar(Pokemon nuevoPokemon)
        {
            if (cantidadPokemones < 3)
            {
                equipo[cantidadPokemones] = nuevoPokemon;
                cantidadPokemones++;
                Console.WriteLine($"¡{nombre} ha capturado a {nuevoPokemon.Apodo}!");
                return true;
            }
            else
            {
                Console.WriteLine($"¡El equipo de {nombre} está lleno (máximo 3 Pokémon)! No se pudo capturar a {nuevoPokemon.Apodo}.");
                return false;
            }
        }

        // Recorre el array polimórficamente
        public void ComandarAtaqueEquipo()
        {
            Console.WriteLine($"\n--- ¡{nombre} ordena el ataque general de su equipo! ---");
            for (int i = 0; i < cantidadPokemones; i++)
            {
                equipo[i].Atacar();
            }
        }
    }
}
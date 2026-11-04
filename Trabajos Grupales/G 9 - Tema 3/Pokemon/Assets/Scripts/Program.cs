using System;

namespace Tema3Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SIMULADOR DE COMBATE POKÉMON (UTN FRT - FASE 1) ===\n");

            // Crear un entrenador
            Entrenador entrenador = new Entrenador("Ash Ketchum");

            // Instanciar criaturas de fuego y agua
            PokemonFuego charmander = new PokemonFuego("Charmander", 100, 12);
            PokemonAgua squirtle = new PokemonAgua("Squirtle", 95, 14);
            PokemonFuego charizard = new PokemonFuego("Charizard", 100, 36);
            PokemonAgua psyduck = new PokemonAgua("Psyduck", 80, 8); // Se rechazará por límite

            // Capturar hasta el límite de 3
            entrenador.Capturar(charmander);
            entrenador.Capturar(squirtle);
            entrenador.Capturar(charizard);

            // Prueba de validación de límite de equipo
            entrenador.Capturar(psyduck);

            // Ejecución del ataque polimórfico en Main
            entrenador.ComandarAtaqueEquipo();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
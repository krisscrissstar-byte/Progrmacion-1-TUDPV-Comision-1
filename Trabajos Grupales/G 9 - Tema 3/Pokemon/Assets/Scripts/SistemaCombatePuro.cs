using System;

namespace Tema3Pokemon
{
    public static class SistemaCombatePuro
    {
        private static Random random = new Random();

        public static bool CalcularProbabilidadEncuentro()
        {
            int roll = random.Next(1, 101); // Número aleatorio entre 1 y 100

            // Usamos Console.WriteLine porque esto es lógica pura de C#
            Console.WriteLine($"[C# Lógica Pura] Evaluando probabilidad de encuentro... (Roll: {roll})");

            if (roll <= 25)
            {
                return true;
            }

            return false;
        }
    }
}
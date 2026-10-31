
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== STREET FIGHTER =====");
        Console.WriteLine();

        // Crear luchadores
        Ryu ryu = new Ryu("Ryu", 100, 100);
        ChunLi chunli = new ChunLi("Chun-Li", 100, 100);

        // Mostrar estado inicial
        Console.WriteLine("=== LUCHADORES ===");
        ryu.MostrarEstado();
        Console.WriteLine();
        chunli.MostrarEstado();

        Console.WriteLine();

        // Crear torneo
        RingTorneo torneo = new RingTorneo(ryu, chunli);

        // Iniciar round
        torneo.IniciarRound();

        // Simular daño durante el combate
        Console.WriteLine();
        Console.WriteLine("=== COMBATE ===");

        chunli.RecibirDanio(40);
        ryu.RecibirDanio(25);

        // Mostrar estado final
        Console.WriteLine();
        Console.WriteLine("=== ESTADO FINAL ===");

        ryu.MostrarEstado();
        Console.WriteLine();
        chunli.MostrarEstado();

        // Declarar ganador
        torneo.DeclararGanador();

        Console.WriteLine();
        Console.WriteLine("===== FIN DEL TORNEO =====");
    }
}

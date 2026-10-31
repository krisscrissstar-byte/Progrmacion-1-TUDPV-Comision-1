
using System;
public class RingTorneo
{
    // Atributos
    private Luchador luchador1;
    private Luchador luchador2;

    // Constructor
    public RingTorneo(Luchador luchador1, Luchador luchador2)
    {
        this.luchador1 = luchador1;
        this.luchador2 = luchador2;
    }

    // Iniciar combate
    public void IniciarRound()
    {
        Console.WriteLine("=== INICIO DEL ROUND ===");
        Console.WriteLine(luchador1.Nombre + " VS " + luchador2.Nombre);
        Console.WriteLine();

        luchador1.EjecutarEspecial();
        luchador2.EjecutarEspecial();
    }

    // Declarar ganador
    public void DeclararGanador()
    {
        Console.WriteLine();
        Console.WriteLine("=== RESULTADO DEL ROUND ===");

        if (luchador1.BarraSalud > luchador2.BarraSalud)
        {
            Console.WriteLine("Ganador: " + luchador1.Nombre);
        }
        else if (luchador2.BarraSalud > luchador1.BarraSalud)
        {
            Console.WriteLine("Ganador: " + luchador2.Nombre);
        }
        else
        {
            Console.WriteLine("¡Empate!");
        }
    }
}

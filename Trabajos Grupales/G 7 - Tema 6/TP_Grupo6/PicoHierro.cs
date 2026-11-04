using System;

namespace TP_Grupo6
{
    public class PicoHierro : Herramienta
    {
        public PicoHierro() : base("Hierro", 250) { }

        public override void PicarBloque(Bloque b)
        {
            if (Durabilidad <= 0)
            {
                Console.WriteLine("La herramienta está rota.");
                return;
            }

            if (b.Tipo.Equals("Obsidiana", System.StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No se puede dañar obsidiana con pico de hierro.");
                return;
            }

            // Daño por golpe
            b.Romper(20);
            Durabilidad -= 1;
            Console.WriteLine($"Pico de Hierro picó {b.Tipo}. Dureza restante: {b.Dureza}. Durabilidad: {Durabilidad}");
        }
    }
}

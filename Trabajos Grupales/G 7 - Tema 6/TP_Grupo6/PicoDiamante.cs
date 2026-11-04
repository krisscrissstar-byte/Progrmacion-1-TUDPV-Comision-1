using System;

namespace TP_Grupo6
{
    public class PicoDiamante : Herramienta
    {
        private int golpes = 0;

        public PicoDiamante() : base("Diamante", 1561) { }

        public override void PicarBloque(Bloque b)
        {
            if (Durabilidad <= 0)
            {
                Console.WriteLine("La herramienta está rota.");
                return;
            }

            b.Romper(30);
            golpes++;

            // Disminuye 1 de durabilidad cada 3 golpes
            if (golpes % 3 == 0) Durabilidad -= 1;

            Console.WriteLine($"Pico de Diamante picó {b.Tipo}. Dureza restante: {b.Dureza}. Durabilidad: {Durabilidad}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bloque> Bloques = new List<Bloque>();
            Herramienta PicoDiamante = new PicoDiamante(38);
            Herramienta PicoHierro = new PicoHierro(2);

            Bloque tierra = new Bloque("Tierra", 1);
            Bloque piedra = new Bloque("Piedra", 3);
            Bloque obsidiana = new Bloque("Obsidiana", 10);
            Bloque madera = new Bloque("Madera", 2);

            Bloques.Add(tierra);
            Bloques.Add(piedra);
            Bloques.Add(obsidiana);
            Bloques.Add(madera);

            foreach (Bloque b in Bloques)
            {
                PicoDiamante.PicarBloque(b);
                Console.WriteLine();
            }
            Console.ReadKey();

            foreach (Bloque b in Bloques)
            {
                PicoHierro.PicarBloque(b);
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

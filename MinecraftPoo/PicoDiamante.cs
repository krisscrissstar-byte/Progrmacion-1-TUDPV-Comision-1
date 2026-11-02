using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinecraftPoo
{
    internal class PicoDiamante : Herramienta
    {
        // Contador de golpes para controlar el desgaste.
        private int golpes = 0;

        // Constructor: establece el material y la durabilidad inicial.
        public PicoDiamante(int durabilidad)
            : base("Diamante", durabilidad)
        {
        }

        // Sobrescribe el metodo de la clase Herramienta.
        public override void PicarBloque(Bloque b)
        {
            // Comprobamos que el pico no este roto.
            if (Durabilidad <= 0)
            {
                Console.WriteLine("El pico de diamante esta roto.");
                return;
            }

            // Mostramos el bloque que se esta picando.
            if (b.Tipo.ToLower() == "obsidiana")
            {
                Console.WriteLine("El pico de diamante esta picando OBSIDIANA.");
            }
            else
            {
                Console.WriteLine("El pico de diamante esta picando " + b.Tipo + ".");
            }

            // Simulamos el tiempo de extraccion.
            Thread.Sleep(1000);
            // Se llama al metodo de Romper de bloque para saber que se rompio el bloque.
            b.Romper();

            // Cada tres golpes, pierde un punto de durabilidad.
            golpes++;

            if (golpes == 3)
            {
                Durabilidad--;
                golpes = 0;
            }

            // Mostramos la durabilidad que queda.
            Console.WriteLine("Durabilidad restante: " + Durabilidad);

            if (Durabilidad == 0)
            {
                Console.WriteLine("El pico de diamante se rompio.");
            }
        }
    }       
}

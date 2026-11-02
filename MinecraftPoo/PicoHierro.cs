using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinecraftPoo
{
    internal class PicoHierro : Herramienta
    {
        // Constructor del pico de hierro.
        // base inicializa el material y la durabilidad.
        public PicoHierro(int durabilidad)
            : base("Hierro", durabilidad)
        {
        }

        // Sobrescribimos el método de la clase base.
        public override void PicarBloque(Bloque b)
        {
            // Comprobamos si el pico está roto.
            if (Durabilidad <= 0)
            {
                Console.WriteLine("El pico de hierro esta roto.");
                return;
            }

            // Simulamos una extracción más rápida.
            Console.WriteLine(
                "Picando " + b.Tipo + " con el pico de hierro..."
            );

            Thread.Sleep(500); // Espera de 0,5 segundos.
            // Se llama al metodo de Romper de bloque para saber que se rompio el bloque.
            b.Romper();

            Console.WriteLine(
                "Bloque extraido rapidamente."
            );

            // El pico pierde 1 punto por cada golpe.
            Durabilidad--;

            Console.WriteLine(
                "Durabilidad restante: " + Durabilidad
            );

            // Si la durabilidad llega a cero, se rompe.
            if (Durabilidad == 0)
            {
                Console.WriteLine("El pico de hierro se rompio.");
            }

        }

    }

}

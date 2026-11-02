using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftPoo
{
    internal class Bloque
    {
        // Campos privados: guardan los datos del bloque.
        // Al ser privados, no se pueden modificar directamente desde otras clases.
        private string tipo;
        private int dureza;

        // Propiedad Tipo: permite consultar y modificar el tipo del bloque.
        public string Tipo
        {
            get { return tipo; } // Devuelve el tipo del bloque.

            set
            {
                // Solo acepta un texto que no esté vacío.
                if (!string.IsNullOrWhiteSpace(value))
                {
                    tipo = value;
                }
            }
        }

        // Propiedad Dureza: permite consultar y modificar la dureza.
        public int Dureza
        {
            get { return dureza; } // Devuelve la dureza.

            set
            {
                // Evita que la dureza sea negativa.
                if (value >= 0)
                {
                    dureza = value;
                }
            }
        }

        // Constructor: se ejecuta cuando creamos un bloque.
        // Recibe el tipo y la dureza como parámetros.
        public Bloque(string tipo, int dureza)
        {
            // this.Tipo y this.Dureza hacen referencia a las propiedades
            // del objeto que estamos creando.
            this.Tipo = tipo;
            this.Dureza = dureza;
        }

        // Método que representa la acción de romper un bloque.
        public void Romper()
        {
            Console.WriteLine("Se rompio el bloque de " + Tipo);
        }
    }
}

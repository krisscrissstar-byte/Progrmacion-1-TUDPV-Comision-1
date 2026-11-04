using System;
using System.Collections.Generic;
using System.Text;

namespace TP_2_POO_I___II.Clases
{
    internal class Item
    {
        public string Nombre { get; set; }

        // Atributo privado '_peso' y su Propiedad encapsulada 'Peso'
        private float _peso;
        public float Peso
        {
            get { return _peso; }

            set
            {
                if (value <= 0)
                {
                    _peso = 0.5f; // Si es menor o igual a 0, se fija en 0.5f
                }
            }
        }


        // Constructor parametrizado usando 'this'
        public Item(string nombre, float peso)
        {
            this.Nombre = nombre;
            this.Peso = peso;
        }

        // Método virtual 'Usar'
        public virtual void Usar()
        {
            Console.WriteLine($"[Item Genérico] Usando el ítem {this.Nombre}.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TP_2_POO_I___II.Clases
{
    internal class ArmaEquipable : Item
    {
        // Propiedad añadida
        private int danio;
        public int Danio
        {
            get { return danio; }

            set
            {
                if (value > 0)
                {
                    danio = value;
                }
            }
        }

        // Constructor delegando a la base
        public ArmaEquipable(string nombre, float peso, int danio) : base(nombre, peso)
        {
            this.Danio = danio;
        }


        // Sobrescribe (override) 'Usar'
        public override void Usar()
        {
            Console.WriteLine($"[Arma] Equipando {this.Nombre}." +
                $" Ahora tu poder de ataque aumenta en {this.Danio} puntos.");
        }
    }
}

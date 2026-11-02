using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TP_2_POO_I___II.Clases
{
    internal class Pocion : Item
    {
        // Propiedad añadida
        private int PuntosRecuperacion;
        public int puntosRecuperacion
        {
            get { return PuntosRecuperacion; }

            set
            {
                if (value <= 0)
                {
                    PuntosRecuperacion = 5;
                }
            }
        }

        // Constructor delegando a la base con ': base'
        public Pocion(string nombre, float peso, int puntos) : base(nombre, peso)
        {
            this.puntosRecuperacion = puntos;
        }

        // Sobrescribe (override) 'Usar'
        public override void Usar()
        {
            Console.WriteLine($"[Poción] Bebiendo {this.Nombre}... " +
                $"¡Has restaurado {this.PuntosRecuperacion} puntos de vida!");
        }
    }
}

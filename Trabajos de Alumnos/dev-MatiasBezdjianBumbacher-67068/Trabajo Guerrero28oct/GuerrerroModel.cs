using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_clase
{

    public class GuerreroLogico
    {

        private string nombre;     // el nombre del guerrero
        private int vidaMax;       // la vida máxima que puede tener
        private int vidaActual;    // la vida actual del personaje
        private int escudo;        //  absorben golpes antes de tocar la vida


        public string Nombre
        {
            get { return nombre; }
        }


        public int VidaActual
        {
            get { return vidaActual; }

            private set
            {

                if (value < 0)
                {
                    vidaActual = 0;
                }
                else if (value > vidaMax)
                {
                    vidaActual = vidaMax;
                }
                else
                {
                    vidaActual = value;
                }
            }
        }
        public int Escudo
        {
            get { return escudo; }
        }
        public bool EstaVivo
        {
            get { return vidaActual > 0; }
        }
        public GuerreroLogico(string nombre, int vidaMax, int escudoInicial)
        {
            this.nombre = nombre;
            this.vidaMax = vidaMax;
            this.vidaActual = vidaMax;
            this.escudo = escudoInicial;
        }

        public void RecibirDanio(int cantidad)
        {
            if (!EstaVivo)
            {
                return;
            }

            if (escudo >= cantidad)
            {
                escudo = escudo - cantidad;
            }
            else
            {
                int ticLava = cantidad - escudo;
                escudo = 0;
                VidaActual = VidaActual - ticLava;
            }
        }


        public void Curar(int cantidad)
        {
            if (EstaVivo)
            {
                VidaActual = VidaActual + cantidad;
            }
        }
    }
}
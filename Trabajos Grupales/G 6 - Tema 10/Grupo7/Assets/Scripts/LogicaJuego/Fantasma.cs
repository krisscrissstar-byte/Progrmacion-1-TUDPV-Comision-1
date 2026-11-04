using System;
using System.Collections.Generic;
using System.Text;

namespace Pac_Man_Main
{
   public class Fantasma
       {
            //Definicion de atributos protegidos
            protected string nombre;
            protected string color;
            protected bool estadoVulnerable;

            //Creamos propiedades publicas con get y set para encapsular
            //los atributos protegidos, permitiendo que otras clases
            //(Como PacMan o el Main) puedan consultar o modificar los valores
            //de forma controlada
            public bool EstadoVulnerable
            {
                get { return estadoVulnerable; }
                set { estadoVulnerable = value; }
            }

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Color
            {
                get { return color; }
                set { color = value; }
            }


            //Constructor parametrizado
            public Fantasma(string nombre, string color)
            {
                this.nombre = nombre;
                this.color = color;
                this.estadoVulnerable = false;
                //Hacemos que por defecto, el fantasma comience
                //el nivel en su estado base (invulnerable)

            }

            //Metodo virtual para el movimiento
            public virtual void Moverse()
            {
                Console.WriteLine($"El fantasma {this.nombre} se mueve por el laberinto.");

            }

            //Metodo virtual para cuando el fantasma sea devorado
            public virtual void SerDevorado()
            {

                if (this.estadoVulnerable == true)
                {
                    Console.WriteLine($"{this.nombre} fue devorado por Pac-Man");
                }
                else
                {
                    Console.WriteLine($"El fantasma {this.nombre} atrapo a Pac-Man");
                }

            }


        }
    }

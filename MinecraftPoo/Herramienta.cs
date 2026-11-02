using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftPoo
{
    //Clase abstracta para instanciar herramientas especificas
    abstract class Herramienta
    {
        // Campo protegido: las clases hijas también podrán acceder
        // al material de la herramienta.
        protected string material;

        // Campo privado: guarda la durabilidad de la herramienta.
        private int durabilidad;

        // Propiedad para consultar y modificar la durabilidad.
        public int Durabilidad
        {
            get { return durabilidad; }

            set
            {
                // Evita asignar valores negativos.
                if (value >= 0)
                {
                    durabilidad = value;
                }
            }
        }

        // Constructor parametrizado: recibe el material
        // y la durabilidad inicial.
        public Herramienta(string material, int durabilidad)
        {
            // this.material identifica el campo de la clase.
            this.material = material;

            // Inicializamos la durabilidad mediante la propiedad,
            // para aplicar su validación.
            this.Durabilidad = durabilidad;
        }

        // Método virtual: las clases hijas pueden sobrescribirlo
        // para definir una forma diferente de picar bloques.
        public virtual void PicarBloque(Bloque b)
        {
            // Si no queda durabilidad, no se puede seguir picando.
            if (Durabilidad <= 0)
            {
                Console.WriteLine("La herramienta esta rota.");
                return; // Finaliza el método.
            }

            // Mostramos qué bloque estamos picando.
            Console.WriteLine(
                "Picando bloque de " + b.Tipo +
                " con herramienta de " + material
            );

            // Cada golpe consume un punto de durabilidad.
            Durabilidad--;
            // Se llama al metodo de Romper de bloque para saber que se rompio el bloque.
            b.Romper();

            // Comprobamos si la herramienta se rompió.
            if (Durabilidad == 0)
            {
                Console.WriteLine("La herramienta se rompio.");
            }

        }        
    }
}

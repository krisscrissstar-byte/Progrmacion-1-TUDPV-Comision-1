using System;

namespace TheLegendOfZelda
{

    //###GRAMAJO MATIAS###
    public abstract class ItemZelda
    {
        private string nombre;
        protected int durabilidad;

        public string Nombre
        {
            get { return this.nombre; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del objeto esta vacio");
                }
                this.nombre = value;
            }
        }

        public int Durabilidad
        {

            get { return this.durabilidad; }

        }

        //Constructor, con un if dentro en durabilidad para evitar que se ingresen datos erroneos
        protected ItemZelda(string nombre, int durabilidad)
        {
            this.nombre = nombre;

            if (durabilidad < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(durabilidad), "la durabilidad es negativa");

            }
            this.durabilidad = durabilidad;
        }

        //Verificacion si la durabilidad del objeto permite su uso y, en caso de que si, disminuir esta misma
        protected bool IniciarUso()
        {
            if (this.durabilidad <= 0)
            {
                Console.WriteLine("El objeto esta por romperse");
                return false;
            }
            this.durabilidad--;
            return true;
        }

        public virtual void Usar(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));

            }

            if (!this.IniciarUso())
            {
                return;
            }

            Console.WriteLine("Usaste: {this.Nombre}.");
        }
    }


    // Santillan Jorge Alfredo - 67125 ====================================================================
    // CLASE HIJA: EspadaMaestra
    // ====================================================================================================


    public class EspadaMaestra : ItemZelda
    {
        // Campo privado que guarda el daño sagrado del arma
        private int danioSagrado;
        // Propiedad pública con validación: no permite valores menores o iguales a cero
        public int DanioSagrado
        {
            get { return this.danioSagrado; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(danioSagrado), "El daño sagrado debe ser mayor que cero");
                }
                this.danioSagrado = value;
            }
        }
        // Base, ejecuta el constructor de ItemZelda, y le pasa los parametros nombre y durabilidad, mientras que el parametro danioSagrado se asigna a la propiedad DanioSagrado
        public EspadaMaestra(string nombre, int durabilidad, int danioSagrado) : base(nombre, durabilidad)
        {
            this.DanioSagrado = danioSagrado;
        }
        // Sobrescritura del método virtual
        public override void Usar(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            if (!this.IniciarUso())
            {
                return;
            }

            if (link.TieneSaludMaxima())
            {
                Console.WriteLine(link.Nombre + " Utiliza la Espada Maestra y lanza rayos de energia sagrada que causan " + this.DanioSagrado + " puntos de daño");
            }
            else
            {
                Console.WriteLine(link.Nombre + " Ataca con la Esapda Maestr y no puede lanzar rayos porque no tiene salud maxima, causando " + this.DanioSagrado + " puntos de daño");
            }
        }

    }
    // ====================================================================================================
    //  CLASE HIJA: ArcoFuerza
    // ====================================================================================================

    public class ArcoFuerza : ItemZelda
    {
        // Campo privado que lleva la cuenta de las flechas disponibles
        private int flechasRestantes;
        // Propiedad pública con validación: impide que las flechas queden en negativo
        public int FlechasRestantes
        {
            get { return this.flechasRestantes; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El número de flechas restantes no puede ser negativo")
                }

                this.flechasRestantes = value;
            }
        }
        // Base, ejecuta el constructor de ItemZelda
        public ArcoFuerza(string nombre, int durabilidad, int flechasRestantes) : base(nombre, durabilidad)
        {
            this.FlechasRestantes = flechasRestantes;
        }
        // Sobrescritura del método virtual
        public override void Usar(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            // Validamos las flechas antes de utilizar el arco
            if (this.FlechasRestantes <= 0)
            {
                Console.WriteLine(link.Nombre + " No tiene flechas para disparar con el Arco de Fuerza");
                return;
            }
            if (!this.IniciarUso())
            {
                return;
            }

            this.FlechasRestantes--;

            Console.WriteLine(link.Nombre + " Dispara una flecha con el Arco de Fuerza, causando daño a su objetivo. Flechas restantes: " + this.FlechasRestantes);
        }
    }

    /*Rodriguez Villa Sofia Luz - 67150
    ==================================================
    4. CLASE GESTORA: Link
    ==================================================*/

    public class Link
    {
        private string nombre;
        private int corazones;

        private ItemZelda[] inventario;

        public string Nombre
        {
            get { return this.nombre; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre de Link no puede estar en blanco.");
                }
                this.nombre = value;
            }
        }

        // Propiedad automática de solo lectura
        public int MaxCorazones { get; }

        public int Corazones
        {
            get { return this.corazones; }
            private set
            {
                if (value < 0 || value > this.MaxCorazones)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Los corazones deben estar entre 0 y el máximo.");
                }
                this.corazones = value;
            }
        }
    }

    //Propiedad calculada
    public bool TieneSaludMaxima
        {
            get { return this.corazones == this.MaxCorazones; }
        }

        //Constructor
        public Link(string nombre, int maxCorazones)
        {
            this.Nombre = nombre;

            if (maxCorazones <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxCorazones), "Link debe tener al menos un corazón máximo.");
            }

            this.MaxCorazones = maxCorazones;
            this.Corazones = maxCorazones;

            this.inventario = new ItemZelda[2];
        }

        //Equipa un objeto en el espacio indicado
        public void Equipar(ItemZelda item, int slot)
        {
            this.ValidarSlot(slot);

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            this.inventario[slot] = item;

            Console.WriteLine($"{this.Nombre} equipó {item.Nombre} en el espacio {slot}.");
        }

        //Utiliza el objeto equipado
        public void AccionarItem(int slot)
        {
            this.ValidarSlot(slot);

            ItemZelda item = this.inventario[slot];

            if (item == null)
            {
                Console.WriteLine($"El espacio {slot} del inventario está vacío");
            }

            return;

        }

        //Polimorfismo: se ejecuta la versión Usar() de la clase del objeto real.
        item.Usar(this);
    }

    //Recibe daño sin permitir una cantidad negativa de corazones
    public void RecibirDanio(int cantidad)
    {
        if (cantidad < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cantidad), "El daño no puede ser negativo.");
        }

        this.Corazones = Math.Max(0, this.Corazones - cantidad);

        Console.WriteLine($"{this.Nombre} recibió {cantidad} de daño." + $"Corazones: {this.Corazones}/{this.MaxCorazones}");
    }

    //Validación de los dos espacios del inventario
    private void ValidarSlot(int slot)
    {
        if (slot < 0 || slot >= this.inventario.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(slot), "El espacio debe ser 0 o 1.");
        }
    }
}

    //GRAMAJO MATIAS = MAIN()

    public class Program
    {
        public static void Main()
        {
            //Creacion del personaje
            Link link = new Link("Link", 10);

            //Creacion de armas
            EspadaMaestra espada = new EspadaMaestra("Espada Maestra", 100, 30);

            ArcoFuerza arco = new ArcoFuerza("Arco de Fuerza", 50, 3);

            ItemZelda[] equipo = {espada, arco};

            Console.WriteLine("===INVENTARIO===");

            for(int i = 0; i< equipo.Length; i++)
            {
                link.Equipar(equipo[i], i);

                Console.WriteLine("Accionando el espacio {i}");
                link.AccionarItem(i);
            }

            Console.WriteLine("===LINK ES DAÑADO===");

            link.RecibirDanio(2);
            
            Console.WriteLine("USAR ARMAS");

            //Al no tener la vida al maximo link ya no ataca con rayos
            link.AccionarItem(0);
            //Se gasta una flecha
            link.AccionarItem(1);

             Console.WriteLine("=== ESTADO FINAL ===");
        Console.WriteLine($"Salud de Link: {link.Corazones}/{link.MaxCorazones}");
        Console.WriteLine($"Durabilidad de la espada: {espada.Durabilidad}");
        Console.WriteLine($"Durabilidad del arco: {arco.Durabilidad}");
        Console.WriteLine($"Flechas restantes: {arco.FlechasRestantes}");
        }
    }
}

public class item
{
    public string nombre { get; set; }

    private float _peso;

    public float peso
    {
        get { return _peso; }
        set
        {
            if (value <= 0)
            {
                _peso = 0.5f;
            }
            else
            {
                _peso = value;
            }
        }
    }

    public item(string nombre, float peso)
    {
        this.nombre = nombre;
        this.peso = peso;
    }

    public virtual void usar()
    {
        Console.WriteLine("Usando un item genérico...");
    }
    public class pocion : item
    {
        public int PuntosRecuperacion { get; set; }

        public pocion(string nombre, float peso, int puntosRecuperacion) : base(nombre, peso)
        {
            this.PuntosRecuperacion = puntosRecuperacion;
        }

        public override void usar()
        {
            Console.WriteLine($"Usando la {nombre}. Restaura {PuntosRecuperacion} puntos de salud.");
        }
    }

    public class armaEquipable : item
    {
        private object danio;

        public int Danio { get; set; }

        public armaEquipable(string nombre, float peso, int danio) : base(nombre, peso)
        {
            this.danio = danio;
        }

        public override void usar()
        {
            Console.WriteLine($"Equipando la {nombre}. Su poder de ataque es de {danio} puntos.");
        }
    }
    public class cofreBotin
    {
        private bool _abierto = false;

        private item[] itemsContenidos;

        public cofreBotin(item item1, item item2)
        {
            itemsContenidos = new item[2];
            itemsContenidos[0] = item1;
            itemsContenidos[1] = item2;
        }

        public void abrir()
        {
            if (!_abierto)
            {
                _abierto = true;
                Console.WriteLine("¡Has abierto el cofre del botín!");

                for (int i = 0; i < itemsContenidos.Length; i++)
                {
                    if (itemsContenidos[i] != null)
                    {
                        itemsContenidos[i].usar();
                    }
                }
            }
            else
            {
                Console.WriteLine("El cofre ya estaba abierto.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pocion miPocion = new pocion("Poción de Vida", 0.5f, 50);

            armaEquipable miEspada = new armaEquipable("Espada de Hierro", 4.5f, 25);

            cofreBotin cofre = new cofreBotin(miPocion, miEspada);

            cofre.abrir();
            cofre.abrir();
        }
    }
}
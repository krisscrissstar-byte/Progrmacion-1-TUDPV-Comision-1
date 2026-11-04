// See https://aka.ms/new-console-template for more information


using System;


// Marcelo Ezequiel Cerri 67035

class Item
{
    public string Nombre { get; set; }

    private float _peso;

    public float Peso
    {
        get
        {
            return _peso;
        }
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

    public Item(string Nombre, float Peso)
    {
        this.Nombre = Nombre;
        this.Peso = Peso;
    }

    public virtual void Usar()
    {
        Console.WriteLine("Usando un item generico.");
    }
}

class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string Nombre, float Peso, int PuntosRecuperacion)
        : base(Nombre, Peso)
    {
        this.PuntosRecuperacion = PuntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine(Nombre + " restaura "
            + PuntosRecuperacion + " puntos de vida.");
    }
}

class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string Nombre, float Peso, int Danio)
        : base(Nombre, Peso)
    {
        this.Danio = Danio;
    }

    public override void Usar()
    {
        Console.WriteLine("Equipando " + Nombre
            + ". Poder de ataque: " + Danio);
    }
}

class CofreBotin
{
    private bool _abierto = false;
    private Item[] itemsContenidos;

    public CofreBotin(Item item1, Item item2)
    {
        itemsContenidos = new Item[2];

        itemsContenidos[0] = item1;
        itemsContenidos[1] = item2;
    }

    public void Abrir()
    {
        if (_abierto == false)
        {
            _abierto = true;

            Console.WriteLine("Abriendo el cofre...");

            for (int i = 0; i < itemsContenidos.Length; i++)
            {
                itemsContenidos[i].Usar();
            }
        }
        else
        {
            Console.WriteLine("El cofre ya esta abierto.");
        }
    }
}

class Program
{
    static void Main()
    {
        Pocion pocion = new Pocion("Pocion de vida", 0.5f, 50);

        ArmaEquipable espada = new ArmaEquipable("Espada", 3.0f, 25);

        CofreBotin cofre = new CofreBotin(pocion, espada);

        cofre.Abrir();

        Console.ReadKey();
    }
}


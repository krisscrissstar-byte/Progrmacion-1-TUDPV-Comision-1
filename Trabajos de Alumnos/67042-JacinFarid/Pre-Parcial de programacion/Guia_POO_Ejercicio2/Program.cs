<<<<<<< HEAD
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Item pocion = new Pocion("Pocion de vida", 0.5f, 30);
        Item espada = new ArmaEquipable("Espada", 3.5f, 20);

        CofreBotin cofre = new CofreBotin(pocion, espada);

        cofre.Abrir();
    }
}

class Item
{
    public string Nombre { get; set; }

    private float _peso;

    public float Peso
    {
        get { return _peso; }
        set
        {
            if (value <= 0)
                _peso = 0.5f;
            else
                _peso = value;
        }
    }

    public Item(string nombre, float peso)
    {
        this.Nombre = nombre;
        this.Peso = peso;
    }

    public virtual void Usar()
    {
        Console.WriteLine("Usando el item: " + Nombre);
    }
}

class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string nombre, float peso, int puntosRecuperacion)
        : base(nombre, peso)
    {
        this.PuntosRecuperacion = puntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine(Nombre + ": recupera "
            + PuntosRecuperacion + " puntos.");
    }
}

class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string nombre, float peso, int danio)
        : base(nombre, peso)
    {
        this.Danio = danio;
    }

    public override void Usar()
    {
        Console.WriteLine(Nombre + ": arma equipada. Daño: " + Danio);
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
        if (!_abierto)
        {
            _abierto = true;

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
=======
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Item pocion = new Pocion("Pocion de vida", 0.5f, 30);
        Item espada = new ArmaEquipable("Espada", 3.5f, 20);

        CofreBotin cofre = new CofreBotin(pocion, espada);

        cofre.Abrir();
    }
}

class Item
{
    public string Nombre { get; set; }

    private float _peso;

    public float Peso
    {
        get { return _peso; }
        set
        {
            if (value <= 0)
                _peso = 0.5f;
            else
                _peso = value;
        }
    }

    public Item(string nombre, float peso)
    {
        this.Nombre = nombre;
        this.Peso = peso;
    }

    public virtual void Usar()
    {
        Console.WriteLine("Usando el item: " + Nombre);
    }
}

class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string nombre, float peso, int puntosRecuperacion)
        : base(nombre, peso)
    {
        this.PuntosRecuperacion = puntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine(Nombre + ": recupera "
            + PuntosRecuperacion + " puntos.");
    }
}

class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string nombre, float peso, int danio)
        : base(nombre, peso)
    {
        this.Danio = danio;
    }

    public override void Usar()
    {
        Console.WriteLine(Nombre + ": arma equipada. Daño: " + Danio);
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
        if (!_abierto)
        {
            _abierto = true;

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
>>>>>>> b522946e173735387b48d7ff8fe679d3ecd03afb
}
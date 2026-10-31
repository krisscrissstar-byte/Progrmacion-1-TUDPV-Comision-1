using System;

public class Item
{
    public string Nombre { get; set; }
    private float _peso;

    public float Peso
    {
        get { return _peso; }
        set
        {
            if (value < 0) _peso = 0;
            else if (value > 0.5f) _peso = 0.5f;
            else _peso = value;
        }
    }

    public Item(string nombre, float peso)
    {
        this.Nombre = nombre;
        this.Peso = peso;
    }

    public virtual void Usar()
    {
        Console.WriteLine("Usando el iteam: " + Nombre + ", Peso: " + Peso);
    }
}

class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }
    
    public Pocion (string nombre, float peso, int puntos) : base(nombre, peso)
    {
        this.PuntosRecuperacion = puntos;
    }

    public override void Usar()
    {
        Console.WriteLine("Usando la pocion: " + Nombre + ". Recupera: " + PuntosRecuperacion + " HP");
    }
}

class ArmaEquipable : Item
{
    public int danio { get; set; } 

    public ArmaEquipable(string nombre, float peso, int danio) : base(nombre, peso)
    {
        this.danio = danio;
    }

    public override void Usar()
    {
        Console.WriteLine("Usando el arma: " + Nombre + ". Daño: " + danio);
    }
}

class CofreBotin
{
    private bool _abierto = false;
    private Item[] itemsContenidos = new Item[2];

    public CofreBotin(Item item1, Item item2)
    {
        itemsContenidos[0] = item1;
        itemsContenidos[1] = item2;
    }

    public void Abrir()
    {
        if (_abierto)
        {
            Console.WriteLine("El cofre ya está abierto.");
            return;

        }
        else
        {
            _abierto = true;
            Console.WriteLine("Abriendo el cofre...");

            for (int i = 0; i < itemsContenidos.Length; i++)
            {
                itemsContenidos[i].Usar();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pocion p = new Pocion("Pocion de Vida", 0.5f, 50);
            ArmaEquipable espada = new ArmaEquipable("Espada", 3.0f, 25);

            CofreBotin cofre = new CofreBotin(p, espada);
            cofre.Abrir();

            Console.ReadKey();
        }
    }

}
using System;

// ===================== CLASE BASE =====================
class Item
{
    // Propiedad auto-implementada
    public string Nombre { get; set; }

    // Atributo privado + propiedad encapsulada con validación
    private float _peso;
    public float Peso
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

    // Constructor parametrizado con 'this'
    public Item(string nombre, float peso)
    {
        this.Nombre = nombre;
        this.Peso = peso; // pasa por la validación de la propiedad
    }

    // Método virtual: las clases hijas pueden sobrescribirlo
    public virtual void Usar()
    {
        Console.WriteLine("Usás el ítem " + Nombre + " (peso: " + Peso + " kg).");
    }
}

// ===================== POCIÓN =====================
class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string nombre, float peso, int puntosRecuperacion) : base(nombre, peso)
    {
        this.PuntosRecuperacion = puntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine("Bebés la " + Nombre + " y recuperás " + PuntosRecuperacion + " puntos de vida. (peso: " + Peso + " kg)");
    }
}

// ===================== ARMA EQUIPABLE =====================
class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string nombre, float peso, int danio) : base(nombre, peso)
    {
        this.Danio = danio;
    }

    public override void Usar()
    {
        Console.WriteLine("Equipás la " + Nombre + ". Poder de ataque: " + Danio + ". (peso: " + Peso + " kg)");
    }
}

// ===================== COFRE =====================
class CofreBotin
{
    private bool _abierto = false;
    private Item[] itemsContenidos = new Item[2];

    // Recibe los 2 ítems y los guarda en el arreglo
    public CofreBotin(Item item1, Item item2)
    {
        itemsContenidos[0] = item1;
        itemsContenidos[1] = item2;
    }

    public void Abrir()
    {
        if (!_abierto)
        {
            _abierto = true;
            Console.WriteLine("¡Abriste el cofre! Contenía:");

            for (int i = 0; i < itemsContenidos.Length; i++)
            {
                // Polimorfismo: se ejecuta el Usar() de Pocion o de ArmaEquipable
                itemsContenidos[i].Usar();
            }
        }
        else
        {
            Console.WriteLine("El cofre ya está abierto y vacío.");
        }
    }
}

// ===================== PROGRAMA PRINCIPAL =====================
class Program
{
    static void Main(string[] args)
    {
        Pocion pocion = new Pocion("Poción de Vida", 0.3f, 50);
        ArmaEquipable espada = new ArmaEquipable("Espada de Hierro", 3.5f, 25);

        CofreBotin cofre = new CofreBotin(pocion, espada);

        cofre.Abrir();

        Console.WriteLine();
        Console.WriteLine("Intentás abrir el cofre otra vez...");
        cofre.Abrir();

        Console.ReadKey();
    }
}


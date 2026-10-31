using System;

public class Item
{
    public string Nombre { get; set; }

    private float _peso;
    public float Peso
    {
        get => _peso;
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

    public Item(string nombre, float peso)
    {
        Nombre = nombre;
        Peso = peso;
    }

    public virtual void Usar()
    {
        Console.WriteLine($"Usando el ítem genérico: {Nombre}.");
    }
}

public class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string nombre, float peso, int puntosRecuperacion) : base(nombre, peso)
    {
        PuntosRecuperacion = puntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine($"Se bebe la poción '{Nombre}'. Restaura {PuntosRecuperacion} puntos de salud.");
    }
}

public class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string nombre, float peso, int danio) : base(nombre, peso)
    {
        Danio = danio;
    }

    public override void Usar()
    {
        string tipoArma = Danio > 0 ? "letal" : "";
        Console.WriteLine($"Se equipa el arma '{tipoArma}' '{Nombre}'. Poder de ataque: {Danio} puntos.");
    }
}

public class CofreBotin
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
            Console.WriteLine("¡Has abierto el cofre de botín!");

            for (int i = 0; i < itemsContenidos.Length; i++)
            {
                if (itemsContenidos[i] != null)
                {
                    Console.Write($"- Ítem {i + 1}: ");
                    itemsContenidos[i].Usar();
                }
            }
        }
        else
        {
            Console.WriteLine("El cofre ya se encontraba abierto.");
        }
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Pocion pocionSalud = new Pocion("Poción de Vida Mayor", 0.3f, 50);
        ArmaEquipable espadaFogata = new ArmaEquipable("Espada de Hierro", 4.5f, 25);

        CofreBotin cofre = new CofreBotin(pocionSalud, espadaFogata);

        Console.WriteLine("=== ESTADO INICIAL ===");
        Console.WriteLine("El cofre está cerrado en la mazmorra.\n");

        Console.WriteLine("=== INTERACCIÓN CON EL COFRE ===");
        cofre.Abrir();
    }
}
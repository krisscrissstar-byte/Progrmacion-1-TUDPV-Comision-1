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
        Console.WriteLine($"Usás el ítem {Nombre} (peso {Peso}).");
    }
}

public class Pocion : Item
{
    public int PuntosRecuperacion { get; set; }

    public Pocion(string nombre, float peso, int puntosRecuperacion)
        : base(nombre, peso)
    {
        this.PuntosRecuperacion = puntosRecuperacion;
    }

    public override void Usar()
    {
        Console.WriteLine($"Bebés la poción {Nombre}: restaurás {PuntosRecuperacion} puntos de vida.");
    }
}

public class ArmaEquipable : Item
{
    public int Danio { get; set; }

    public ArmaEquipable(string nombre, float peso, int danio)
        : base(nombre, peso)
    {
        this.Danio = danio;
    }

    public override void Usar()
    {
        Console.WriteLine($"Equipás {Nombre}: poder de ataque {Danio}.");
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

    public bool Abierto
    {
        get { return _abierto; }
    }

    public Item ObtenerItem(int indice)
    {
        return itemsContenidos[indice];
    }

    // Abre el cofre y deja elegir qué ítem usar
    public void Abrir()
    {
        if (_abierto)
        {
            Console.WriteLine("El cofre ya estaba abierto.");
            return;
        }

        _abierto = true;
        Console.WriteLine("¡Abriste el cofre!");

        int opcion = -1;

        do
        {
            Console.WriteLine("\n--- Contenido del cofre ---");
            for (int i = 0; i < itemsContenidos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {itemsContenidos[i].Nombre}");
            }
            Console.WriteLine("0. Cerrar el cofre");
            Console.Write("¿Qué ítem querés usar? ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Eso no es un número válido.");
                continue;
            }

            if (opcion >= 1 && opcion <= itemsContenidos.Length)
            {
                // Polimorfismo: Usar() corre la versión del tipo real
                itemsContenidos[opcion - 1].Usar();
            }
            else if (opcion != 0)
            {
                Console.WriteLine("Opción no válida.");
            }

        } while (opcion != 0);

        Console.WriteLine("Cerraste el cofre.");
    }
}

class Program
{
    static void Main()
    {
        Pocion pocion = new Pocion("Poción de vida", 0.3f, 50);
        ArmaEquipable espada = new ArmaEquipable("Espada de hierro", 4.5f, 18);

        CofreBotin cofre = new CofreBotin(pocion, espada);
        cofre.Abrir();
    }
}

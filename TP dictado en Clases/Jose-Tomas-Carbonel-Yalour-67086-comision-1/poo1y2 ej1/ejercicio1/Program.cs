using System;

public class Personaje
{
    protected string nombre;
    protected int vida;

    public Personaje(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{nombre} ataca con un golpe base (10 de daño).");
        objetivo.RecibirDanio(10);
    }

    public void RecibirDanio(int cant)
    {
        vida -= cant;
        if (vida < 0) vida = 0;
    }

    public bool EstaVivo()
    {
        return vida > 0;
    }

    public string Nombre { get { return nombre; } }
    public int Vida { get { return vida; } }
}

public class Guerrero : Personaje
{
    private int fuerzaFisica;

    public Guerrero(string nombre, int vida, int fuerzaFisica)
        : base(nombre, vida)
    {
        this.fuerzaFisica = fuerzaFisica;
    }

    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{nombre} ataca con su espada ({fuerzaFisica} de daño).");
        objetivo.RecibirDanio(fuerzaFisica);
    }
}

public class Mago : Personaje
{
    private int mana;

    public Mago(string nombre, int vida, int mana)
        : base(nombre, vida)
    {
        this.mana = mana;
    }

    public override void Atacar(Personaje objetivo)
    {
        if (mana >= 10)
        {
            mana -= 10;
            Console.WriteLine($"{nombre} lanza un hechizo (30 de daño). Maná restante: {mana}");
            objetivo.RecibirDanio(30);
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene maná, golpea débilmente (5 de daño).");
            objetivo.RecibirDanio(5);
        }
    }
}

class Program
{
    static void Main()
    {
        Guerrero guerrero = new Guerrero("Guerrero", 100, 25);
        Mago mago = new Mago("Mago", 80, 30);

        Personaje[] grupo = new Personaje[2];
        grupo[0] = guerrero;
        grupo[1] = mago;

        int opcion = 0;

        do
        {
            Console.WriteLine("\n=== COMBATE RPG ===");
            Console.WriteLine($"1. {grupo[0].Nombre} ataca a {grupo[1].Nombre} (Vida: {grupo[1].Vida})");
            Console.WriteLine($"2. {grupo[1].Nombre} ataca a {grupo[0].Nombre} (Vida: {grupo[0].Vida})");
            Console.WriteLine("3. Ver estado de los personajes");
            Console.WriteLine("0. Salir");
            Console.Write("Elegí una opción: ");

            // Validación: si no es un número, no rompe el programa
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Eso no es un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    grupo[0].Atacar(grupo[1]);
                    break;

                case 2:
                    grupo[1].Atacar(grupo[0]);
                    break;

                case 3:
                    foreach (Personaje p in grupo)
                    {
                        Console.WriteLine($"{p.Nombre} -> Vida: {p.Vida} | ¿Vivo? {p.EstaVivo()}");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del combate...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}

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

    public string Nombre => nombre;
    public int Vida => vida;

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{nombre} ataca a {objetivo.Nombre} causando 10 de daño base.");
        objetivo.RecibirDanio(10);
    }

    public void RecibirDanio(int cant)
    {
        vida -= cant;
        if (vida < 0)
        {
            vida = 0;
        }
        Console.WriteLine($"{nombre} recibe {cant} de daño. Vida restante: {vida}");
    }

    public bool EstaVivo()
    {
        return vida > 0;
    }
}

public class Guerrero : Personaje
{
    private int fuerzaFisica;

    public Guerrero(string nombre, int vida, int fuerzaFisica) : base(nombre, vida)
    {
        this.fuerzaFisica = fuerzaFisica;
    }

    public override void Atacar(Personaje objetivo)
    {
        int dañoTotal = 10 + fuerzaFisica; 
        Console.WriteLine($"{nombre} (Guerrero) realiza un ataque físico a {objetivo.Nombre} infligiendo {dañoTotal} de daño (Fuerza: {fuerzaFisica}).");
        objetivo.RecibirDanio(dañoTotal);
    }
}

public class Mago : Personaje
{
    private int mana; 

    public Mago(string nombre, int vida, int mana) : base(nombre, vida)
    {
        this.mana = mana;
    }

    public override void Atacar(Personaje objetivo)
    {
        if (mana >= 10)
        {
            mana -= 10;
            Console.WriteLine($"{nombre} (Mago) lanza un poderoso hechizo a {objetivo.Nombre}, gasta 10 de maná y hace 30 de daño. (Maná restante: {mana})");
            objetivo.RecibirDanio(30);
        }
        else
        {
            Console.WriteLine($"{nombre} (Mago) no tiene suficiente maná y propina un golpe débil con su bastón a {objetivo.Nombre} haciendo 5 de daño.");
            objetivo.RecibirDanio(5);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrero miGuerrero = new Guerrero("Thorin", 120, 15);
        Mago miMago = new Mago("Gandalf", 80, 20);

        Personaje[] grupo = new Personaje[] { miGuerrero, miMago };

        Console.WriteLine("=== ESTADO INICIAL DEL GRUPO ===");
        foreach (Personaje p in grupo)
        {
            Console.WriteLine($"- {p.Nombre} | Vida: {p.Vida} | ¿Está vivo?: {p.EstaVivo()}");
        }

        Console.WriteLine("\n=== SIMULACIÓN DE RONDA DE COMBATE ===");

        if (grupo[0].EstaVivo() && grupo[1].EstaVivo())
        {
            grupo[0].Atacar(grupo[1]);
            Console.WriteLine();

            if (grupo[1].EstaVivo())
            {
                grupo[1].Atacar(grupo[0]);
            }
        }

        Console.WriteLine("\n=== ESTADO FINAL TRAS EL COMBATE ===");
        foreach (Personaje p in grupo)
        {
            Console.WriteLine($"- {p.Nombre} | Vida: {p.Vida} | ¿Está vivo?: {p.EstaVivo()}");
        }
    }
}
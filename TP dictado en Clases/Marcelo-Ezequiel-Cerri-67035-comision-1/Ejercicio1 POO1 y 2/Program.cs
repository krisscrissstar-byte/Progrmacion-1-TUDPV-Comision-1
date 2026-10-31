// See https://aka.ms/new-console-template for more information



using System;


// Marcelo Ezequiel Cerri 67035
class Personaje
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
        objetivo.RecibirDanio(10);
    }

    public void RecibirDanio(int cant)
    {
        vida -= cant;

        if (vida < 0)
            vida = 0;
    }

    public bool EstaVivo()
    {
        return vida > 0;
    }

    public int ObtenerVida()
    {
        return vida;
    }
}

class Guerrero : Personaje
{
    private int fuerzaFisica;

    public Guerrero(string nombre, int vida, int fuerzaFisica)
        : base(nombre, vida)
    {
        this.fuerzaFisica = fuerzaFisica;
    }

    public override void Atacar(Personaje objetivo)
    {
        objetivo.RecibirDanio(fuerzaFisica);
    }
}

class Mago : Personaje
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
            objetivo.RecibirDanio(30);
        }
        else
        {
            objetivo.RecibirDanio(5);
        }
    }
}

class Program
{
    static void Main()
    {
        Guerrero guerrero = new Guerrero("Thor", 100, 20);
        Mago mago = new Mago("Merlin", 80, 30);

        Personaje[] grupo = { guerrero, mago };

        Console.WriteLine("¡Comienza el combate!");

        grupo[0].Atacar(grupo[1]);
        grupo[1].Atacar(grupo[0]);

        Console.WriteLine("Vida de Thor: " + guerrero.ObtenerVida());
        Console.WriteLine("Vida de Merlin: " + mago.ObtenerVida());

        Console.WriteLine("¿Thor sigue vivo? " + guerrero.EstaVivo());
        Console.WriteLine("¿Merlin sigue vivo? " + mago.EstaVivo());

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}



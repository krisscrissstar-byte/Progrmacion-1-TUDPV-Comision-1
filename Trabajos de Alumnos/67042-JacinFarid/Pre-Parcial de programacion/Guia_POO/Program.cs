<<<<<<< HEAD
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero("Goku", 100, 25);
        Mago mago = new Mago("Merlin", 80, 20);

        Personaje[] grupo = new Personaje[2];

        grupo[0] = guerrero;
        grupo[1] = mago;

        grupo[0].Atacar(grupo[1]);
        grupo[1].Atacar(grupo[0]);

        Console.WriteLine("Vida del Guerrero: " + grupo[0].ObtenerVida());
        Console.WriteLine("Vida del Mago: " + grupo[1].ObtenerVida());
    }
}

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
        {
            vida = 0;
        }
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
    protected int fuerzaFisica;

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
    protected int mana;

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
=======
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero("Goku", 100, 25);
        Mago mago = new Mago("Merlin", 80, 20);

        Personaje[] grupo = new Personaje[2];

        grupo[0] = guerrero;
        grupo[1] = mago;

        grupo[0].Atacar(grupo[1]);
        grupo[1].Atacar(grupo[0]);

        Console.WriteLine("Vida del Guerrero: " + grupo[0].ObtenerVida());
        Console.WriteLine("Vida del Mago: " + grupo[1].ObtenerVida());
    }
}

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
        {
            vida = 0;
        }
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
    protected int fuerzaFisica;

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
    protected int mana;

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
>>>>>>> b522946e173735387b48d7ff8fe679d3ecd03afb
}
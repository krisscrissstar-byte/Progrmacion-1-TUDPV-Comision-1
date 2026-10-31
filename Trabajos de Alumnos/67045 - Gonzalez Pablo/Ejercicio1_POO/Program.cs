using System;

// ===================== CLASE BASE =====================
class Personaje
{
    // Encapsulamiento: protegidos, accesibles solo desde esta clase y sus derivadas
    protected string nombre;
    protected int vida;

    // Constructor parametrizado usando 'this'
    public Personaje(string nombre, int vida)
    {
        this.nombre = nombre;
        this.vida = vida;
    }

    // Getters (métodos con retorno) para leer los datos desde afuera
    public string GetNombre()
    {
        return nombre;
    }

    public int GetVida()
    {
        return vida;
    }

    // Método virtual: las clases hijas pueden sobrescribirlo
    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine(nombre + " ataca a " + objetivo.GetNombre() + " con un golpe básico (10 de daño).");
        objetivo.RecibirDanio(10);
    }

    // Descuenta vida sin permitir valores negativos
    public void RecibirDanio(int cant)
    {
        vida -= cant;
        if (vida < 0)
        {
            vida = 0;
        }
    }

    // Devuelve true si el personaje sigue con vida
    public bool EstaVivo()
    {
        return vida > 0;
    }

    public void MostrarEstado()
    {
        string estado = EstaVivo() ? "Vivo" : "Derrotado";
        Console.WriteLine("- " + nombre + ": " + vida + " de vida (" + estado + ")");
    }
}

// ===================== GUERRERO =====================
class Guerrero : Personaje
{
    private int fuerzaFisica;

    // Delega nombre y vida al constructor de la clase base
    public Guerrero(string nombre, int vida, int fuerzaFisica) : base(nombre, vida)
    {
        this.fuerzaFisica = fuerzaFisica;
    }

    // Polimorfismo: el guerrero pega según su fuerza física
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine(nombre + " golpea con su espada a " + objetivo.GetNombre() + " (" + fuerzaFisica + " de daño).");
        objetivo.RecibirDanio(fuerzaFisica);
    }
}

// ===================== MAGO =====================
class Mago : Personaje
{
    private int mana;

    public Mago(string nombre, int vida, int mana) : base(nombre, vida)
    {
        this.mana = mana;
    }

    // Polimorfismo: hechizo si tiene maná, golpe débil si no
    public override void Atacar(Personaje objetivo)
    {
        if (mana >= 10)
        {
            mana -= 10;
            Console.WriteLine(nombre + " lanza una bola de fuego a " + objetivo.GetNombre() + " (30 de daño). Maná restante: " + mana);
            objetivo.RecibirDanio(30);
        }
        else
        {
            Console.WriteLine(nombre + " no tiene maná y golpea con su bastón a " + objetivo.GetNombre() + " (5 de daño).");
            objetivo.RecibirDanio(5);
        }
    }
}

// ===================== PROGRAMA PRINCIPAL =====================
class Program
{
    static void Main(string[] args)
    {
        // Instanciación de objetos con 'new'
        Guerrero guerrero = new Guerrero("Arthas", 100, 25);
        Mago mago = new Mago("Merlín", 80, 20);

        // Arreglo polimórfico: ambos se guardan como Personaje
        Personaje[] grupo = new Personaje[2];
        grupo[0] = guerrero;
        grupo[1] = mago;

        Console.WriteLine("=== ESTADO INICIAL ===");
        foreach (Personaje p in grupo)
        {
            p.MostrarEstado();
        }

        // Ronda de combate: cada personaje ataca al otro
        Console.WriteLine();
        Console.WriteLine("=== RONDA DE COMBATE ===");
        for (int i = 0; i < grupo.Length; i++)
        {
            Personaje atacante = grupo[i];
            Personaje objetivo = grupo[(i + 1) % grupo.Length];

            if (atacante.EstaVivo())
            {
                // Se llama a Atacar sobre un Personaje, pero se ejecuta
                // la versión de Guerrero o de Mago (polimorfismo)
                atacante.Atacar(objetivo);
            }
        }

        Console.WriteLine();
        Console.WriteLine("=== ESTADO FINAL ===");
        foreach (Personaje p in grupo)
        {
            p.MostrarEstado();
        }

        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Superviviente leon = new Superviviente("Leon", 35, true);

        ConsumibleSurvival[] suministros = new ConsumibleSurvival[2];
        suministros[0] = new HierbaVerde("Hierba Verde");
        suministros[1] = new SprayPrimerosAuxilios("Spray");

        for (int i = 0; i < suministros.Length; i++)
        {
            leon.AgregarItem(suministros[i]);
        }

        leon.MostrarEstado();
        leon.MostrarInventario();

        for (int i = 1; i <= suministros.Length; i++)
        {
            Console.WriteLine("\nUsando espacio " + i);
            leon.UsarItem(i);
            leon.MostrarEstado();
        }

        leon.MostrarInventario();
    }
}

class ConsumibleSurvival
{
    protected string nombre;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nombre = value;
        }
    }

    public ConsumibleSurvival(string nombre)
    {
        this.Nombre = nombre;
    }

    public virtual void Consumir(Superviviente s)
    {
        Console.WriteLine("Usando " + Nombre);
    }
}

class HierbaVerde : ConsumibleSurvival
{
    public HierbaVerde(string nombre) : base(nombre)
    {
    }

    public override void Consumir(Superviviente s)
    {
        s.RecuperarSalud(40);
        s.CurarEnvenenamiento();

        Console.WriteLine("Recuperaste 40 puntos de salud.");
        Console.WriteLine("El envenenamiento fue curado.");
    }
}

class SprayPrimerosAuxilios : ConsumibleSurvival
{
    private bool usado;

    public SprayPrimerosAuxilios(string nombre) : base(nombre)
    {
        this.usado = false;
    }

    public override void Consumir(Superviviente s)
    {
        if (!usado)
        {
            s.RestaurarSaludCompleta();
            usado = true;

            Console.WriteLine("Salud restaurada al 100%.");
        }
        else
        {
            Console.WriteLine("El spray ya fue utilizado.");
        }
    }
}

class Superviviente
{
    private string nombre;
    private int salud;
    private bool envenenado;
    private ConsumibleSurvival[] inventario;

    public string Nombre
    {
        get { return nombre; }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nombre = value;
        }
    }

    public int Salud
    {
        get { return salud; }
        set
        {
            if (value < 0)
                salud = 0;
            else if (value > 100)
                salud = 100;
            else
                salud = value;
        }
    }

    public bool Envenenado
    {
        get { return envenenado; }
        set { envenenado = value; }
    }

    public Superviviente(string nombre, int salud, bool envenenado)
    {
        this.Nombre = nombre;
        this.Salud = salud;
        this.Envenenado = envenenado;
        this.inventario = new ConsumibleSurvival[4];
    }

    public void RecuperarSalud(int cantidad)
    {
        if (cantidad > 0)
            Salud += cantidad;
    }

    public void RestaurarSaludCompleta()
    {
        Salud = 100;
    }

    public void CurarEnvenenamiento()
    {
        Envenenado = false;
    }

    public void AgregarItem(ConsumibleSurvival item)
    {
        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i] == null)
            {
                inventario[i] = item;
                Console.WriteLine(item.Nombre + " agregado al inventario.");
                return;
            }
        }

        Console.WriteLine("Inventario lleno.");
    }

    public void UsarItem(int slot)
    {
        if (slot < 1 || slot > inventario.Length)
        {
            Console.WriteLine("Espacio invalido.");
            return;
        }

        if (inventario[slot - 1] == null)
        {
            Console.WriteLine("Ese espacio esta vacio.");
            return;
        }

        inventario[slot - 1].Consumir(this);
        inventario[slot - 1] = null;
    }

    public void MostrarInventario()
    {
        Console.WriteLine("\nInventario:");

        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i] != null)
                Console.WriteLine((i + 1) + ". " + inventario[i].Nombre);
            else
                Console.WriteLine((i + 1) + ". Vacio");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("\nSuperviviente: " + Nombre);
        Console.WriteLine("Salud: " + Salud);

        if (Envenenado)
            Console.WriteLine("Envenenado: Si");
        else
            Console.WriteLine("Envenenado: No");
    }
}
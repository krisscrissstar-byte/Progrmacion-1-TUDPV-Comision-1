
using System;

public class Luchador
{
    // Atributos
    protected string nombre;
    protected int barraSalud;
    protected int barraKi;

    // Constructor
    public Luchador(string nombre, int barraSalud, int barraKi)
    {
        Nombre = nombre;
        BarraSalud = barraSalud;
        BarraKi = barraKi;
    }

    // Propiedades
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (value != null && value != "")
                nombre = value;
            else
                nombre = "Desconocido";
        }
    }

    public int BarraSalud
    {
        get { return barraSalud; }
        set
        {
            if (value >= 0 && value <= 100)
                barraSalud = value;
            else
                barraSalud = 100;
        }
    }

    public int BarraKi
    {
        get { return barraKi; }
        set
        {
            if (value >= 0 && value <= 100)
                barraKi = value;
            else
                barraKi = 100;
        }
    }

    // Método virtual para los ataques especiales
    public virtual void EjecutarEspecial()
    {
        Console.WriteLine(nombre + " no tiene un ataque especial.");
    }

    // Recibir daño
    public void RecibirDanio(int danio)
    {
        if (danio > 0)
        {
            if (danio >= barraSalud)
                BarraSalud = 0;
            else
                BarraSalud -= danio;
        }
    }

    // Mostrar estado del luchador
    public void MostrarEstado()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Salud: " + barraSalud);
        Console.WriteLine("Ki: " + barraKi);
    }
}

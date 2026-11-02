using System;

class Program
{
    static void Main(string[] args)
    {

    }
}

public class Personaje
{
    //Declaracion de las variables
    private string nombre { get; set; }
    private int vidaMax;
    private int vidaActual;
    private int escudo; //puntos de defensa
    private bool estaVivo;

    //Propiedades get, set
    public string Nombre
    {
        get {  return nombre; }
    }
    public int VidaActual
    {
        get { return vidaActual; }

        set
        {
            if (vidaActual < 0)
            {
                vidaActual = 0;
            }
            else if (vidaActual > vidaMax)
            {
                vidaActual = vidaMax;
            }
            else
            {
                vidaActual = value;
            }
        }
    }
    public int VidaMax
    {
        get {return vidaMax; }
    }
    public int Escudo
    {
        get { return escudo; }
    }
    public bool EstaVivo
    {
        get { return estaVivo; }
        set
        {
            if (vidaActual > 0)
            {
                estaVivo = true;
            }
            else if (vidaActual == 0)
            {
                estaVivo = false;
            }
        }
    }

    //Constructor
    public Personaje(string nombre, int vidaMax, int escudoInicial)
    {
        this.nombre = nombre;
        this.vidaActual = vidaMax;
        this.escudo = escudoInicial;
    }

    //Metodos
    public void RecibirDanio (int cantidad)
    {
        if (EstaVivo == false)
        {
            vidaActual = vidaActual;
        }
        else if (escudo >= cantidad)
        {
            escudo -= cantidad;
        }
        else if (cantidad > escudo)
        {
            escudo = 0;
            vidaActual -= cantidad - escudo;
        }
    }

    public void Curar (int cantidad)
    {
        if (EstaVivo == true)
        {
            vidaActual += cantidad;
        }
        else
        {
            vidaActual = vidaActual;
        }
    }
}


using System;
class GuerreroLogico
{
    private string nombre;
    private int vidaMax;
    private int vidaActual;
    private int escudo;

    public string Nombre
    {
        get{return nombre;}

    }

    public int VidaMax
    {
        get {vidaMax;}
        set{if(value < 0) value = 0;
            else if (value > vidaMax) value = vidaMax;
            else value = value;}
    }    

    public int Escudo
    {
        get{return escudo;}
    }

    public bool EstaVivo
    {
        get{if (vidaActual > 0) EstaVivo = true;
        else if(vidaActual = 0) EstaVivo = false;}
    }

    public GuerreroLogico(string nombre, int vidaMax, int escudoInicial)
    {
        this.nombre = nombre;
        this.vidaMax = vidaMax;
        this.escudo= escudoInicial;
    }
    

    public void RecibirDanio(int cantidad)
    {
        if(EstaVivo = false)
        {
            return;
        }
        if (escudo >= 0)
        {
            escudo -= cantidad;
        }
        else
        {
            int remanente = cantidad - escudo;
            escudo = 0;
            vidaActual -= remanente;

        }
    }

    public void Curar(int cantidad)
    {
        if (EstaVivo)
        {
            vidaActual += cantidad;
        }
    }

}
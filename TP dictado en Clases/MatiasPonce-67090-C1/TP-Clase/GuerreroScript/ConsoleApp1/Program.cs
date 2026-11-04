class GuerreroLogico
{
    private int vidaActual;
    public int VidaActual
    {
        get { return vidaActual; }
        set { if(value > vidaMaxima) vidaActual = vidaMaxima; else vidaActual = value; }


    }
    private int vidaMaxima;

    private int escudo;
    public int Escudo
    {
        get { return escudo; }
        set { if(value > escudoMaximo) escudo = escudoMaximo; else escudo = value; }
    }

    private int escudoMaximo;

    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public bool EstaVivo
    {
        get { return EstaVivo; }
        set { if (VidaActual > 0) EstaVivo = true; else EstaVivo = false; }
    }

    public void RecibirDanio(int danio)
    {
        if (EstaVivo)
        {
            if (Escudo > 0)
            {
                int danioRestante = danio - Escudo;
                Escudo -= danio;
                if (danioRestante > 0)
                {
                    VidaActual -= danioRestante;
                }
            }
            else
            {
                VidaActual -= danio;
            }
        }
        else
        {
            Console.WriteLine($"{Nombre} ya está muerto y no puede recibir daño.");
        }
    }

    public void Curar(int cantidadCura)
    {
        if (EstaVivo)
        {
            VidaActual += cantidadCura;
            if (VidaActual > vidaMaxima)
            {
                VidaActual = vidaMaxima;
            }
        }
        else
        {
            Console.WriteLine($"{Nombre} está muerto y no puede ser curado.");
        }
    }
}
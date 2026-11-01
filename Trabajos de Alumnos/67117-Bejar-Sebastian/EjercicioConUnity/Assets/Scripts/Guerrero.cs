public class GuerreroLogico
{
    // Atributos privados obligatorios
    private string nombre;
    private int vidaMax;
    private int vidaActual;
    private int escudo;

    // Propiedades (get / set)
    public string Nombre => nombre;

    public int VidaActual
    {
        get => vidaActual;
        private set
        {
            if (value < 0)
                vidaActual = 0;
            else if (value > vidaMax)
                vidaActual = vidaMax;
            else
                vidaActual = value;
        }
    }

    public int Escudo => escudo;

    // Propiedad calculada de solo lectura
    public bool EstaVivo => vidaActual > 0;

    // Constructor Parametrizado
    public GuerreroLogico(string nombre, int vidaMax, int escudoInicial)
    {
        this.nombre = nombre;
        this.vidaMax = vidaMax;
        this.vidaActual = vidaMax; // La salud actual arranca igual a vidaMax
        this.escudo = escudoInicial;
    }

    // Métodos Obligatorios
    public void RecibirDanio(int cantidad)
    {
        // Si EstaVivo es falso, no ejecuta ninguna acción
        if (!EstaVivo) return;

        if (escudo >= cantidad)
        {
            // El escudo absorbe todo el impacto
            escudo -= cantidad;
        }
        else
        {
            // El impacto supera al escudo
            int remanente = cantidad - escudo;
            escudo = 0;
            // Descuenta el remanente a través de la propiedad (aplica validación)
            VidaActual -= remanente;
        }
    }

    public void Curar(int cantidad)
    {
        // Si EstaVivo es verdadero, suma la cantidad a la propiedad VidaActual
        if (EstaVivo)
        {
            VidaActual += cantidad; // El setter privado limita automáticamente que no supere vidaMax
        }
    }
}
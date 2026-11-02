public abstract class Guerrero
{
    public int ValorActual { get; protected set; }
    public int ValorMaximo { get; protected set; }

    public bool EstaAgotado => ValorActual <= 0;

    protected Guerrero(int maximo)
    {
        ValorMaximo = maximo > 0 ? maximo : 1;
        ValorActual = ValorMaximo;
    }
}
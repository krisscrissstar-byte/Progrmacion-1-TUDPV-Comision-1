using System;

public class Salud : Guerrero
{
    public Salud(int maximo) : base(maximo) { }
    public bool EstaVivo => !EstaAgotado;

    public void RecibirDanio(int cantidad)
    {
        if (cantidad <= 0 || !EstaVivo) return;
        ValorActual = Math.Max(0, ValorActual - cantidad);
    }
    public void Curar(int cantidad)
    {
        if (cantidad <= 0 || !EstaVivo) return;
        ValorActual = Math.Min(ValorMaximo, ValorActual + cantidad);
    }
    public void Vaciar()
    {
        ValorActual = 0;
    }
}
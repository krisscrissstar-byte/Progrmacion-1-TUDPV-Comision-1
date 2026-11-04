using System;

public class Escudo : Guerrero
{
    public Escudo(int maximo) : base(maximo) { }

    public int AbsorberDanio(int cantidad)
    {
        if (cantidad <= 0) return 0;

        int absorbido = Math.Min(ValorActual, cantidad);

        ValorActual -= absorbido;

        return cantidad - absorbido;
    }

    public void Recargar(int cantidad)
    {
        if (cantidad <= 0) return;

        ValorActual = Math.Min(ValorMaximo, ValorActual + cantidad);
    }
    public void Vaciar()
    {
        ValorActual = 0;
    }
}
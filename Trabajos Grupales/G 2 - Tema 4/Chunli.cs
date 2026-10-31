// ChunLi corregido, la clase era un copypaste de Ryu.
using System;

public class ChunLi : Luchador
{
    private const int CostoKikoken = 25;
    private int velocidadKikoken = 2;

    public ChunLi(string nombre, int barraSalud, int barraKi)
        : base(nombre, barraSalud, barraKi)
    {
    }

    public override void EjecutarEspecial()
    {
        if (barraKi >= CostoKikoken)
        {
            barraKi -= CostoKikoken;

            Console.WriteLine($"{nombre} lanza: ¡KIKOKEN!");
            Console.WriteLine($"Velocidad del Kikoken: {velocidadKikoken}x");
            Console.WriteLine($"Ki restante: {barraKi}");
        }
        else
        {
            Console.WriteLine($"{nombre} no tiene Ki suficiente para el Kikoken.");
            Console.WriteLine($"Ki actual: {barraKi}, necesita {CostoKikoken}");
        }
    }
}

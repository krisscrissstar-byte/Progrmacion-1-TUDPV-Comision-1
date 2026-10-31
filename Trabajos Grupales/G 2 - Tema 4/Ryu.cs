// Clase hija de Luchador: Ryu
// Sobrescribe EjecutarEspecial() lanzando un Hadoken que gasta 25 de Ki.
public class Ryu : Luchador
{
    private const int CostoHadoken = 25;

    public Ryu(string nombre, int barraSalud, int barraKi)
        : base(nombre, barraSalud, barraKi)
    {
    }

    public override void EjecutarEspecial()
    {
        if (barraKi >= CostoHadoken)
        {
            barraKi -= CostoHadoken;
            System.Console.WriteLine(nombre + " lanza: ¡HADOKEN! (Ki restante: " + barraKi + ")");
        }
        else
        {
            System.Console.WriteLine(nombre + " no tiene Ki suficiente para el Hadoken (Ki actual: " + barraKi + ", necesita " + CostoHadoken + ")");
        }
    }
}

class CriaturaHollownest
{
    protected int Salud;
    protected string Nombre;

    virtual ReaccionarGolpe()
    {
        Console.WriteLine("Ouch");
    }
}
class ElCaballero : CriaturaHollownest
{
    private int reservaAlma = 99;
    ElCaballero.Salud = 100;

    ConcentrarAlma()
    {
        if (reservaAlma > 0)
        {
            reservaAlma -= 15;
            ElCaballero.Salud += 15;
            Console.WriteLine("Te curaste 15 de vida");
        }
        else
        {
            Console.WriteLine("No hay alma para concentrar.");
        }
    }
}

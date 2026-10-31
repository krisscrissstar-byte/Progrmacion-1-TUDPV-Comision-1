public class CaballeroNegro : GuerreroHueco
{
    public CaballeroNegro(string nombre, int salud, int stamina)
        : base(nombre, salud, stamina) { }

    public override void Esquivar()
    {
        if (stamina >= 40)
        {
            stamina -= 40;
            Console.WriteLine($"[FAT ROLL] {nombre} realiza un rodaje pesado con su gran escudo. Consume 40 de stamina. Stamina restante: {stamina}");
        }
        else
        {
            Console.WriteLine($"{nombre} está muy pesado y no tiene stamina para rodar.");
        }
    }
}
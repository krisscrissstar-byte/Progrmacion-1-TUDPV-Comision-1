public class AsesinoSombra : GuerreroHueco
{
	public AsesinoSombra(string nombre, int salud, int stamina)
		: base(nombre, salud, stamina) { }

	public override void Esquivar()
	{
		if (stamina >= 15)
		{
			stamina -= 15;
			Console.WriteLine($"[FAST ROLL] {nombre} ejecuta un esquive veloz y ágil. Consume 15 de stamina. Stamina restante: {stamina}");
		}
		else
		{
			Console.WriteLine($"{nombre} no tiene stamina para esquivar.");
		}
	}
}
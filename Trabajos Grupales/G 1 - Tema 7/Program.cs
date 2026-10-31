internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULADOR DE COMBATE - DARK SOULS ===\n");

        GuerreroHueco[] ejercito = new GuerreroHueco[]
        {
                new CaballeroNegro("Tarkus el Hierro", 150, 80),
                new AsesinoSombra("Karan la Sombra", 90, 60)
        };

        Hoguera hogueraSantuario = new Hoguera("Santuario del Enlace del Fuego");


        foreach (GuerreroHueco g in ejercito)
        {
            Console.WriteLine($"--- Turno de {g.Nombre} ---");
            g.Atacar();
            g.Esquivar();
            Console.WriteLine();
        }


        hogueraSantuario.Descansar(ejercito[0], 150, 80);

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
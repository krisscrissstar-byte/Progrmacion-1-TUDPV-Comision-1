using System;
using DarkSouls.Modelo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULADOR DE COMBATE - DARK SOULS ===\n");

        GuerreroHueco[] ejercito =
        {
            new CaballeroNegro("Tarkus el Hierro", 150, 80),
            new AsesinoSombra("Karan la Sombra", 90, 60)
        };

        Hoguera hoguera = new Hoguera("Santuario del Enlace del Fuego");

        foreach (GuerreroHueco g in ejercito)
        {
            Console.WriteLine($"--- Turno de {g.Nombre} ---");

            Console.WriteLine(g.Atacar()
                ? $"{g.Nombre} ataca (-{g.CostoAtaque}). Stamina: {g.Stamina}/{g.StaminaMax}"
                : $"{g.Nombre} no tiene stamina para atacar.");

            Console.WriteLine(g.Esquivar()
                ? $"{g.Nombre} esquiva (-{g.CostoEsquivar}). Stamina: {g.Stamina}/{g.StaminaMax}"
                : $"{g.Nombre} no tiene stamina para esquivar.");

            int recibido = g.RecibirDanio(30);
            Console.WriteLine($"{g.Nombre} recibe {recibido} de danio. Salud: {g.Salud}/{g.SaludMax}\n");
        }

        // Prueba de limites: el danio excesivo no deja salud negativa
        ejercito[1].RecibirDanio(9999);
        Console.WriteLine($"{ejercito[1].Nombre} - Salud: {ejercito[1].Salud}, vivo: {ejercito[1].EstaVivo}\n");

        foreach (GuerreroHueco g in ejercito)
        {
            hoguera.Descansar(g);
            Console.WriteLine($"{g.Nombre} descanso en '{hoguera.Ubicacion}'. Salud {g.Salud}/{g.SaludMax}, Stamina {g.Stamina}/{g.StaminaMax}");
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

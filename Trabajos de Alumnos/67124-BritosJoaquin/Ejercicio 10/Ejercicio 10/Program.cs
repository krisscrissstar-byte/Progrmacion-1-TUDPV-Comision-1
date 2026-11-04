using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] expMisiones = new int[5];
        Console.WriteLine("=== ASIGNADOR DE EXPERIENCIA DE CLAN ===");
        for (int i = 0; i < expMisiones.Length; i++)
        {
            Console.Write($"Ingrese la EXP conseguida en la Misión {i + 1}: ");
            int.TryParse(Console.ReadLine(), out expMisiones[i]);
        }
        int totalExp = 0;
        Console.WriteLine("\n=== RESULTADOS FINALES DE LAS MISIONES ===");
        for (int i = 0; i < expMisiones.Length; i++)
        {
            if (expMisiones[i] > 100)
            {
                expMisiones[i] = (int)(expMisiones[i] * 1.20);
                Console.WriteLine($"Misión {i + 1}: {expMisiones[i]} EXP (¡Aplica Bono +20%!)");
            }
            else
            {
                Console.WriteLine($"Misión {i + 1}: {expMisiones[i]} EXP");
            }
            totalExp += expMisiones[i];
        }
        Console.WriteLine($"\nExperiencia total acumulada: {totalExp} EXP");
        Console.ReadKey();
    }
}
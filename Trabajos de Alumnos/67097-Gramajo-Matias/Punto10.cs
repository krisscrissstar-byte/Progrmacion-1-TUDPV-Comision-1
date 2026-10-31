int[] misiones = new int[5];


for (int i = 0; i < misiones.Length; i++)
{
    Console.WriteLine("Ingrese los puntos de EXP de la misión " + (i + 1) + ":");
    misiones[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < misiones.Length; i++)
{
    if (misiones[i] > 100)
    {
        misiones[i] += misiones[i] * 20 / 100;
    }
}

Console.WriteLine("--- TABLA DE MISIONES ---");
Console.WriteLine("Misión\tEXP\tBono aplicado");
for (int i = 0; i < misiones.Length; i++)
{
    Console.WriteLine((i + 1) + "\t" + misiones[i] + "\t" + (misiones[i] > 100 ? "Sí (20%)" : "No"));
}

int total = 0;
for (int i = 0; i < misiones.Length; i++)
{
    total += misiones[i];
}

Console.WriteLine("\nEXP total acumulada: " + total);   
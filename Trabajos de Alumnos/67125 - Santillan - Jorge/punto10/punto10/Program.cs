int[] mision = new int[5];

for (int i = 0; i < mision.Length; i++)
{
    Console.WriteLine("Ingrese el valor de la misión " + (i + 1) + ":");
    mision[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < mision.Length; i++)
{
    if (mision[i] > 100)
    {
        mision[i] += mision[i] * 20 / 100;
    }
}

Console.WriteLine("Tabla de misiones");
Console.WriteLine("Mision\tEXP\tBono Aplicado");

for (int i = 0; i < mision.Length; i++)
{
    Console.WriteLine((i + 1) + "\t" + mision[i] + "\t" + (mision[i] > 100 ? "Sí (20%)" : "No"));
}

int totalEXP = 0;
for (int i = 0; i < mision.Length; i++)
{
    totalEXP += mision[i];

}
Console.WriteLine("Total de EXP: " + totalEXP);
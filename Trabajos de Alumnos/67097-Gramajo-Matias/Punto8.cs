int[] dañoJefe = new int[3];
int acumuladorDaño = 0;
int prom;
int valorMax = 0;
int faseMax = 0;

for (int i = 0; i < dañoJefe.Length; i++)
{
    Console.WriteLine("Daño de la fase " + (i + 1) + ":");
    dañoJefe[i] = int.Parse(Console.ReadLine());
    acumuladorDaño += dañoJefe[i];
}

Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
Console.WriteLine("2: Identificar la fase más destructiva");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        prom = acumuladorDaño / dañoJefe.Length;
        Console.WriteLine("El promedio es " + prom);
        break;

    case 2:
        for (int i = 0; i < dañoJefe.Length; i++)
        {
            if (dañoJefe[i] > valorMax)
            {
                valorMax = dañoJefe[i];
                faseMax = (i + 1);
            }
        }
        Console.WriteLine("La fase más destructiva fue " + faseMax + " con " + valorMax + " de daño");
        break;
}   
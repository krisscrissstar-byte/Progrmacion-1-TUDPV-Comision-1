int[] danoJefe = new int[3];
int danoAcumulado = 0;
int promedioDano = 0;
int valorMax = 0;
int faseMax = 0;

for (int i = 0; i < danoJefe.Length; i++)
{
    Console.WriteLine("Daño de la fase " + (i + 1) + ": ");
    danoJefe[i] = int.Parse(Console.ReadLine());
    danoAcumulado += danoJefe[i];
}

Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
Console.WriteLine("2: Identificar la fase más destructiva");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        promedioDano = danoAcumulado / danoJefe.Length;
        Console.WriteLine("El promedio de daño entre las 3 fases es: " + promedioDano);
        break;

    case 2:
        for (int i = 0; i < danoJefe.Length; i++)
        {
            if (danoJefe[i] > valorMax)
            {
                valorMax = danoJefe[i];
                faseMax = (i + 1);
            }
        }
        Console.WriteLine("La fase más destructiva es la fase " + faseMax + "con un daño de: " + valorMax);
        break;
}
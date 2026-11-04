int[] gemas = { 10, 25, 50, 80, 120 };

Console.WriteLine("Ingrese la cantidad de gemas disponibles");
int gemasDisponibles= int.Parse(Console.ReadLine());

Console.WriteLine("1. Mostrar cartas disponibles en la tienda");
Console.WriteLine("2. Mostrar carta más costosa");
int eleccion = int.Parse(Console.ReadLine());

switch (eleccion)
{
    case 1:
    for (int i = 0; i < gemas.Length; i++)
        {
            if (gemas[i] <= gemasDisponibles)
            {
               
                Console.WriteLine($"Carta {i + 1},valor: {gemas[i]}");
            }
            else 
            {
                Console.Write($"{gemas[i]} GEMAS INSUFICIENTES");
            }
        
        }
        break;
    case 2:

        var ordenadas = gemas.OrderByDescending(x => x);

        foreach (int i in ordenadas)
        {
            Console.WriteLine("Valor: " + i);
        }
        break;

}
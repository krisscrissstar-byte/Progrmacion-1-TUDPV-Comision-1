string[] gemas = { "Fuego", "¨Hielo", "Rayo", "Veneno" };
int[] cargas = new int[4];

for (int i = 0; i < gemas.Length; i++)
{
    Console.WriteLine($"Ingrese la carga de la gema {gemas[i]}: ");
    cargas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Elegir opción");
Console.WriteLine("1. Recargar todas las cargas");
Console.WriteLine("2. Buscar gema más agotada");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        for (int i = 0; i < cargas.Length; i++)
        {
            cargas[i] += 5;
            Console.WriteLine("La gema " + gemas[i] + "se recargo y ahora tiene " + cargas[i] + "de carga");
        }
        break;
    case 2:
        for (int i = 0; i < gemas.Length; i++)
        {
            if (cargas[i] <= 0)
            {
                Console.WriteLine("La gema " + (i+1) + "está agotada");
            }
        }
        break;
}
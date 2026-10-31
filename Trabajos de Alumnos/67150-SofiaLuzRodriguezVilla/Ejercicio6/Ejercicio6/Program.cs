/*Ejercicio 6: Selector de Elementos y Cargas Mágicas*/

string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
int[] cargas = new int[4];

for (int i = 0; i < gemas.Length; i++) 
{
    Console.WriteLine("Ingrese las cargas para " + gemas[i]);
    cargas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Elija una opción:");
Console.WriteLine("1. Recargar todos");
Console.WriteLine("2. Buscar gemas agotadas");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        for (int i = 0; i < gemas.Length; i++)
        {
            cargas[i] += 5;
            Console.WriteLine($"La gema {gemas[i]} se recargó y ahora tiene {cargas[i]} cargas");
        }
        break;
    case 2: 
        for (int i = 0; i < gemas.Length; i++)
        {
            if (cargas[i] <= 0)
            {
                Console.WriteLine($"La gema {gemas[i]} está agotada");
            }
            else
            {
                Console.WriteLine("No hay gemas agotadas");
            }
        }
        break;
}


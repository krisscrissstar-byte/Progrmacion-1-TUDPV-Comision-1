/*

Declarar un array con 4 tipos de gemas ["Fuego", "Hielo", "Rayo", "Veneno"] y solicitar 
las cargas de cada una en un vector paralelo. Con un switch permitir:
1: Recargar todas (+5 cargas con bucle for) o
2: Buscar si hay alguna gema agotada (0 cargas con if). 

*/

string[] gemas = {"Fuego", "Hielo", "Rayo", "Veneno"};
int[] cargas = new int[4];
Console.WriteLine("--- INGRESO DE CARGAS INICIALES ---");
for (int i = 0; i < gemas.Length; i++)
{
    Console.Write($"Ingresá las cargas para la gema de {gemas[i]}: ");
    cargas[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
Console.WriteLine("1. Recargar todas (+5 cargas)");
Console.WriteLine("2. Buscar gemas agotadas (0 cargas)");
Console.Write("Elegí una opción: ");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        for (int i = 0; i < cargas.Length; i++)
        {
            cargas[i] += 5;
            Console.WriteLine($"Gema {gemas[i]}: ahora tiene {cargas[i]} cargas.");
        }
        break;

    case 2:
        bool hayAgotadas = false;
        for (int i = 0; i < cargas.Length; i++)
        {
            if (cargas[i] == 0)
            {
                Console.WriteLine($"¡La gema de {gemas[i]} está AGOTADA!");
                hayAgotadas = true;
            }
        }

        if (!hayAgotadas)
        {
            Console.WriteLine("Ninguna gema se encuentra agotada.");
        }
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}
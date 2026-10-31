/*

Declarar un array con la salud de 4 slimes: 
int[] slimes = { 30, 40, 50, 60 };. Mediante un bucle while que permanezca activo mientras al 
menos un slime tenga vida > 0, el usuario elige con un switch a cuál atacar (0 al 3). Con if/else 
validar si el slime atacado ya fue derrotado o restarle 20 HP
 
*/


int[] slimes = { 30, 40, 50, 60 };
while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
{
    Console.WriteLine("=========== ¡Elige qué slime atacar! (1-4) ===========");
    for (int i = 0; i < slimes.Length; i++)
    {
        Console.WriteLine($"Slime {i + 1} tiene {slimes[i]} de vida restante.");
    }
    int opcion = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (opcion)
    {
        case 1:
        case 2:
        case 3:
        case 4:
            if (slimes[opcion - 1] <= 0)
            {
                Console.WriteLine("¡Este slime ya fue derrotado!");
            }
            else
            {
                slimes[opcion - 1] -= 20;
                if (slimes[opcion - 1] <= 0)
                {
                    Console.WriteLine($"¡Has derrotado al Slime {opcion}!");
                }
                else
                {
                    Console.WriteLine($"Has atacado al Slime {opcion}. Salud restante: {slimes[opcion - 1]}");
                }
                if (slimes[opcion - 1] < 0)
                {
                    slimes[opcion - 1] = 0;
                }
            }
            break;
        default:
            Console.WriteLine("Error: Opción no válida.");
            break;
    }
}
Console.Clear();
Console.WriteLine("========================================================================================");
Console.WriteLine("¡Felicidades! Todos los slimes han sido derrotados. Fin del juego. ");
Console.WriteLine("Presione cualquier tecla para salir");
Console.WriteLine("========================================================================================");


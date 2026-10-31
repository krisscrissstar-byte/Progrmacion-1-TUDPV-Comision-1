/*

Un mazo de 5 cartas tiene sus costos en gemas en un array: { 10, 25, 50, 80, 120 }. 
Pedir las gemas del usuario y ofrecer con un switch:  
1: Mostrar cartas que puede pagar (filtrando con for e if),  
2: Identificar la carta más cara del catálogo
 
*/


int[] costosCartas = { 10, 25, 50, 80, 120 };
Console.Write("Ingrese la cantidad de gemas que posee: ");
int gemasUsuario = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("=========== Seleccione una opción ===========");
Console.WriteLine("1: Mostrar las cartas que puedo pagar");
Console.WriteLine("2: Identificar la carta más cara del catálogo");
int opcion = int.Parse(Console.ReadLine());
Console.Clear();
switch (opcion)
{
    case 1:
        Console.WriteLine("=========== Cartas que puedo comprar ===========");
        for (int i = 0; i < costosCartas.Length; i++)
        {
            if (costosCartas[i] <= gemasUsuario)
            {
                Console.WriteLine($"La carta {i + 1} tiene un costo de {costosCartas[i]} gemas");
            }
        }
        break;
    case 2:
        int cartaMasCara = costosCartas[0];
        for (int i = 1; i < costosCartas.Length; i++)
        {
            if (costosCartas[i] > cartaMasCara)
            {
                cartaMasCara = costosCartas[i];
            }
        }
        Console.WriteLine($"La carta más cara del catálogo tiene un costo de {cartaMasCara} gemas");
        break;
    default:
        Console.WriteLine("Error: Opción no válida.");
        break;
}
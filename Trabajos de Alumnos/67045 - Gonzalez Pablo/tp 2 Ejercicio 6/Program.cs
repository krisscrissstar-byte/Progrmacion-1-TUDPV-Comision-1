//Ejercicio 6

string[] = gemas { "Fuego", "Hielo", "Rayo", "Veneno" } ;
int[] cargas = new int[4];

for (int i = 0; i < gemas.Length; i++) ;
{
    Console.Write("Cargas de" gemas[i] + ":");

    cargas[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine("1: Recargar todas las gemas (+5)");
Console.WriteLine("2: Buscar gemas agotadas");
int opcion = int.Parse(Console.ReadLine());

switch opcion
    {
    case 1:
        for (int i = 0 i < cargas.Length; i++) ;
        {
            cargas[i] += 5;
        }
        Console.WriteLine("Todas las gemas fueron recargadas");

        break;

    case 2:
        for (int i = 0; i < cargas.Length; i++) ;
        {
            if (cargas[i] == 0) ;
            {
                Console.WriteLine(gemas[i] + "esta agotada");

            }
        }
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}
}

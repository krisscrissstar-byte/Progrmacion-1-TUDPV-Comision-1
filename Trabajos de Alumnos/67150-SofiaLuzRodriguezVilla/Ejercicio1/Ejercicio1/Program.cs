/*Ejercicio 1: Sistema de Inventario y Durabilidad de Armas
Combina: Array + for + switch + if/else.*/

string[] armas = { "Espada", "Arco", "Hacha", "Daga" };
int[] durabilidad = new int[4];

Console.WriteLine("Ingrese la durabilidad de las armas");
for (int i = 0; i < armas.Length; i++)
{
    durabilidad[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Seleccione una opción: ");
Console.WriteLine("1. Mostrar armas en estado crítico");
Console.WriteLine("2. Mostrar arsenal completo");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] <= 20)
            {
                Console.WriteLine(armas[i] + "-DURABILIDAD BAJA");
            }
            else
            {
                Console.WriteLine(armas[i] + "-DURABILIDAD ESTABLE");
            }

        }
        break;
    case 2:
        Console.WriteLine("Arsenal:");
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine(armas[i]);
        }
        break;

}
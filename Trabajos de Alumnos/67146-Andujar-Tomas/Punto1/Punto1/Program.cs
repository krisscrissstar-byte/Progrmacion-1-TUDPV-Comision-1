
/*Declarar un array con 4 armas ["Espada", "Hacha", "Arco", "Daga"] y un array paralelo entero de durabilidad.
Con un bucle for, cargar la durabilidad de cada arma por teclado. Luego, con un switch ofrecer:
1: Inspeccionar armas críticas
o
2: Ver arsenal completo.
Si elige 1, recorrer con for y evaluar con if qué armas tienen durabilidad >20 mostrando un mensaje de alerta. */


string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
int[] durabilidad = new int[armas.Length];

for (int i = 0; i < armas.Length; i++)
{
    Console.Write($"Ingrese la durabilidad de {armas[i]}: ");
    durabilidad[i] = Convert.ToInt32(Console.ReadLine());
}
// Menú de opciones
Console.WriteLine("\nSeleccione una opción:");
Console.WriteLine("1: Inspeccionar armas críticas");
Console.WriteLine("2: Ver arsenal completo");
int opcion = Convert.ToInt32(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Armas críticas (durabilidad ≤ 20):");
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] <= 20)
            {
                Console.WriteLine($"- {armas[i]}: Durabilidad {durabilidad[i]} (¡Alerta!)");
            }
        }
        break;
    case 2:
        Console.WriteLine("Arsenal completo:");
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine($"- {armas[i]}: Durabilidad {durabilidad[i]}");
        }
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}

string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
int[] durabilidad = new int [armas.Length];
int eleccion;

for (int i = 0; i < armas.Length; i++)
{
    Console.WriteLine ("Ingrese la durabilidad del arma " + armas[i] + ": ");
    durabilidad[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("1: Inspeccionar armas críticas");
Console.WriteLine("2: Ver arsenal completo");
eleccion = int.Parse(Console.ReadLine());

switch (eleccion)
{
    case 1:
        Console.WriteLine("armas criticas:");
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] <= 20)
            {
                Console.WriteLine(armas[i] + " con durabilidad de " + durabilidad[i]);
            }
        }
        break;
    case 2:
        Console.WriteLine("Arsenal de armas:");
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine(armas[i]);
        }
        break;
}

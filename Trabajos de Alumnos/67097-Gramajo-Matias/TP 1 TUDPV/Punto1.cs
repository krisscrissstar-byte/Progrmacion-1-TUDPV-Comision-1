string[] armas = {"Espada", "Hacha", "Arco", "Daga"};

    int[] durabilidad = new int [armas.Length];

for (int i = 0; i < armas.Length; i++)
{
    Console.WriteLine("Ingrese la durabilidad de " + armas[i] + ":");
    durabilidad[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("1: Inspeccionar armas críticas");
Console.WriteLine("2: Ver arsenal completo");
int eleccion = int.Parse(Console.ReadLine());

switch (eleccion)
{
    case 1:
        for (int i = 0; i < armas.Length; i++)
        {
            if (durabilidad[i] <= 20)
            {
                Console.WriteLine(armas[i] + "EN ESTADO CRITICO");
            }
        }

        break;
    case 2:
        for (int i = 0; i < armas.Length; i++)
        {
            Console.WriteLine(armas[i]);
        }
        break;

}

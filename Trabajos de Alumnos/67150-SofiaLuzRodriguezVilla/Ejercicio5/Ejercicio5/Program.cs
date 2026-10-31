/*Ejercicio 5: Registro y Filtrado de Daño por Ráfaga*/

int[] dañoFlechas = new int[6];
int menu = 1;
int referencia = 0;
int dañoTotal = 0;

for (int i = 0; i < dañoFlechas.Length; i++)
{
    Console.WriteLine("Ingrese el daño por flechas");
    dañoFlechas[i] = int.Parse(Console.ReadLine());
}

while (menu == 1)
{
    Console.WriteLine("Ingrese daño de referencia");
    referencia = int.Parse(Console.ReadLine());

    menu = 0;
}

for (int i = 0; i < dañoFlechas.Length; i++)
{
    if (dañoFlechas[i] > referencia)
    {
        Console.WriteLine("La flecha " + (i + 1) + " supera el valor de referencia");
        dañoTotal += dañoFlechas[i];
    }

}

Console.WriteLine("El daño total es de: " + dañoTotal);

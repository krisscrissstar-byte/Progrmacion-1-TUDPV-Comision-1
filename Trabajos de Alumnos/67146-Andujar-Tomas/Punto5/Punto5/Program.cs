/*

Cargar con un bucle for el daño de 6 flechas en un array de enteros. Luego, con un 
bucle while pedir un daño de referencia y filtrar con if/else los impactos que superaron ese 
número, acumulando y mostrando el total de daño filtrado.
 
*/

int[] danos = new int[6];
int referencia;
int totalDanio = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write("Ingrese el daño de la flecha " + (i + 1) + ": ");
    danos[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ingrese el daño de referencia: ");
referencia = int.Parse(Console.ReadLine());
Console.Clear();

int contador = 0;
while (contador < 6)
{
    if (danos[contador] > referencia)
    {
        totalDanio += danos[contador];
    }
    else
    {
        Console.WriteLine("La flecha " + (contador + 1) + " no superó la referencia.");
    }

    contador++;
}

Console.WriteLine("El total de daño filtrado es: " + totalDanio);
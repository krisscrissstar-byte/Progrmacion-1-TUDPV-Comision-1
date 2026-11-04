/*
Un clan realiza 5 misiones. Con un bucle for, almacenar
los puntos de EXP de cada misión en un array de enteros.
Si alguna misión superó los 100 puntos, aplicar
con  if/else un bono extra del 20% sobre esa posición.
Al final, imprimir la tabla del array actualizada y la experiencia total acumulada.
*/

double[] expMisiones = new double[5];
double acumulador = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Ingrese la EXP obtenida en la misión {i+1}");
    expMisiones[i] = int.Parse(Console.ReadLine());
    if (expMisiones[i] >100)
    {
        expMisiones[i] = expMisiones[i] * 1.20;
    }
}
Console.WriteLine("Las misiones con más de 100 de EXP han ganado un bono de un 20%");
for (int i = 0;i < 5; i++)
{
    Console.WriteLine($"Misión {i+1}, EXP: " + expMisiones[i]);
    acumulador = acumulador + expMisiones[i];
}

Console.WriteLine("Experiencia acumulada de sus misiones: " + acumulador);
   

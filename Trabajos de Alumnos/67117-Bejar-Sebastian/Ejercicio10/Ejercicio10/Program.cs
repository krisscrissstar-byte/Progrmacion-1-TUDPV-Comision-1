/*Consigna: Un clan realiza 5 misiones. Con un bucle for, almacenar los puntos de EXP de cada
misión en un array de enteros. Si alguna misión superó los 100 puntos, aplicar con if/else un
bono extra del 20% sobre esa posición. Al final, imprimir la tabla del array actualizada y la
experiencia total acumulada.*/
using System;
public class Ejercicio10
{
    static void Main()
    {
        int[] misiones = new int[5];
        int total = 0;

        for (int i = 1; i <= misiones.Length; i++)
        {
            Console.WriteLine("Ingrese la experiencia obtenida en la mision: " + i);
            misiones[i-1] = int.Parse(Console.ReadLine());
            if (misiones[i-1] >= 100)
            {
                Console.WriteLine("Al obtener mas de 100 de experiencia, se aplico un bono del 20% adicional");
                int bono = misiones[i - 1] * 20 / 100;
                misiones[i - 1] = misiones[i - 1] + bono;
            }
          
        }

        Console.WriteLine("TABLA DE EXPERIENCIA");

        for (int i = 1; i <= misiones.Length; i++)
        {
            Console.WriteLine("Experiencia obtenida en la mision: " + i + "= " + misiones[i - 1]);
            total = total + misiones[i-1];
        }

        Console.WriteLine("Experiencia total obtenida en todas las misiones: " + total);


    }
}
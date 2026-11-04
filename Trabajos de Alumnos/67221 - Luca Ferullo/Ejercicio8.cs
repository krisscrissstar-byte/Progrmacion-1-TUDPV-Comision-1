using System;

namespace Ejercicio8;

public class Program{
    public static void Main(string[] args){
        int[] fases = new int[3];

        for (int i = 0; i < fases.Length; i++){
            Console.WriteLine("Presiona alguna tecla:");
            Console.ReadKey();
        }

        Console.WriteLine("Elije una opcion:");
        Console.WriteLine("1. Calcular el promedio de daño.");
        Console.WriteLine("2. Identificar la fase mas destructiva.");
        int op1 = int.Parse(Console.ReadLine());

        switch (op1){
            case 1:
            int promedio = 0;
            promedio = fases[i] / 2;
            Console.WriteLine("El promedio es: " + promedio);
            break;

            case 2:
            if (fases[i] >= 3){
                Console.WriteLine("La fase mas destructiva es: " + fases[i]);
            }
            break;

            default:
            Console.WriteLine("Opcion invalida.");
            break;
        }
    }
}
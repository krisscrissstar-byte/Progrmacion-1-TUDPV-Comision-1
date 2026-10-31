using System;

namespace Ejercicio5;

public class Program{
    public static void Main(string[] args){
        int[] flechas = new int[6]; 
        int resultado = 0;

        for (int i = 0; i < flechas.Length; i++){
            Console.WriteLine("Ingresa el daño de cada flechazo:");
            flechas[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Daño: " + flechas[i]);
        }

        while (flechas[i] > 0){
            if (flechas[i] > flechas[i]){
                Console.WriteLine("El mayor daño es: " + flechas[i]);
                resultado = flechas[0] + flechas[1] + flechas[2] + flechas[3] + flechas[4] + flechas[5];

                Console.WriteLine("Daño en total: " + resultado);
            }

            else {
                Console.WriteLine("Por favor, ingresa el daño de manera correcta.");
            }
        }

        Console.WriteLine("SALISTE ILESO!");
    }
}
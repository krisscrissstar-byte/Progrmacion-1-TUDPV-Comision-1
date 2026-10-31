using System;

namespace Ejercicio1;

public class Program{
    public static void Main(string[] args){
        string[] armas = {"Espada" , "Hacha" , "Arco" , "Daga"};
        int[] durabilidad = new int[4];

        for (int i = 0;  i < durabilidad.Length; i++){
            Console.WriteLine("Ingresa la durabilidad de " + armas[i]);
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("1. Inspeccionar armas criticas.");
        Console.WriteLine("2. Ver arsenal completo.");

        int op = int.Parse(Console.ReadLine());
    }
}
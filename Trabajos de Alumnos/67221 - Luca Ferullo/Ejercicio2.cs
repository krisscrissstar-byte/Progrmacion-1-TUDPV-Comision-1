using System;

namespace Ejercicio2;

public class Program{
    public static void Main(string[] args){
        float[] tiempoCor = new int[5];

        for (int i = 0; i < tiempoCor.Length; i++){
            Console.WriteLine("---- TOP DE SPEEDRUN ----");
            Console.WriteLine("Establece el tiempo del recorrido:");
            tiempoCor[i] = float.Parse(Console.ReadLine());
        }

        if (tiempoCor[i] >= tiempoCor[i]){
            Console.WriteLine("El numero superior es " + tiempoCor[i]);
            Console.WriteLine("Presiona alguna tecla para salir del programa:");
            Console.ReadKey();
        }

        else {
            Console.WriteLine("Valores invalidos.");
            Console.ReadKey();
        }
        
    }
}
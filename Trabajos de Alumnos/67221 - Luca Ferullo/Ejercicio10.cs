using System;

namespace Ejercicio10;

public class Program{
    public static void Main(string[] args){
        int[] exp = {20 , 51, 84, 100, 26};
        float expExtra = 0f;

        Console.WriteLine("MISIONES SUPERADAS!");
        
        for (int i = 0; i < exp.Length; i++){
            Console.WriteLine("EXP obtenidas por cada misiones:");
            Console.WriteLine(exp[i]);
            Console.ReadKey();

        }

        if (exp[i] >= 100){
            expExtra = exp[i] / 5;

            for (int i = 0; i < exp.Length; i++){
                Console.WriteLine("RECOMPENSAS ACUALIZADAS.");
                Console.WriteLine("Una de las misiones supero a los 100 exp.");
                Console.WriteLine(exp[i]);
                Console.ReadKey();
            }
        }
    }
}
using System;

namespace Ejercicio7;

public class Program{
    public static void Main(string[] args){
        bool[] trampas = {false, true, false, true, false, true};
        int[] op = {0 , 1 , 2 ,3 , 4 ,5};

        for (int i = 0; i < trampas.Length; i++){
            Console.WriteLine("---- JUEGO DE TRAMPAS ----");
            Console.WriteLine("Presiona una tecla para empezar el juego:");
            Console.ReadKey();
        }

         for (int i = 0; i < op.Length; i++){
        Console.WriteLine("Presiona algun número:");
        op[i] = int.Parse(Console.ReadLine());
         }
       
       while (op[i] % 2 == 0){
            Console.WriteLine("Caiste en la trampa!");
       }

       if (op[i] % 3 == 0){
        while (op[i] == 1 || op[i] == 3){
            Console.WriteLine("Bien, continua en el juego:");
            op[i] = int.Parse(Console.ReadLine());
        }

            if (op[i] == 5){
                Console.WriteLine("Esquivaste todas las trampas.");
                for (int i = 0; i < 5; i++){}

                Console.WriteLine("GANASTE!");
                Console.WriteLine("Presiona una tecla para salir del juego:");
                Console.ReadKey();
            }
       }
    }
}
using System;

namespace Ejercicio6;

public class Program{
    public static void Main(string[] args){
        string[] gemas = {"Fuego" , "Hielo" , "Rayo" , "Veneno"};
        int[] cargas = {2 , 4 , 1 , 0};

        for (int i = 0; i < gemas.Length; i++){
            Console.WriteLine("¿Que gemas querras recargar?");
            Console.WriteLine(gemas[i]);
            gemas[i] = Console.ReadLine();
        }

        Console.WriteLine("Presiona alguna tecla para ver las siguientes opciones:");
        Console.ReadKey();
        Console.WriteLine("1. Recargar todas (+5 cargas para cada gema)."),
        Console.WriteLine("2. Revisar si hay una gema agotada.");
        int op1 = int.Parse(Console.ReadLine());

        while(op1 != 1 || op1 != 2){
            Console.WriteLine("Por favor, selecciona alguna opcion:");
            op1 = int.Parse(Console.ReadLine());
        }

        switch (op1){
            case 1:
            Console.WriteLine("GEMAS RECARGADAS +5.");
            cargas[i] += 5;
            Console.WriteLine(cargas[i]);
            break;

            case 2:
            if (cargas[i] == 0){
                Console.WriteLine("Uno de los tipos de gemas se encuentra agotada.");
            }

            else {
                Console.WriteLine("Todas las gemas se encuentras disponibles.");
            }
            break;
        }
    }
}
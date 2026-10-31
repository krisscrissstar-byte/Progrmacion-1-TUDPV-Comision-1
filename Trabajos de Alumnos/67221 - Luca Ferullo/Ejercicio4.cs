using System;

namespace Ejercicio4;

public class Program{
    public static void Main(string[] args){
        int[] cartas = {10 , 25 , 50 , 80 , 120};

        for (int i = 0; i < cartas.Length; i++){
            Console.WriteLine("Costos de las gemas en las cartas:");
            Console.WriteLine(cartas[i]);
            Console.WriteLine("Presiona alguna tecla para ver las siguientes opciones:");
            Console.ReadKey();
        }

        Console.WriteLine("---- OPCIONES ----");
        Console.WriteLine("1. Mostrar cartas con las que puedes pagar.");
        Console.WriteLine("2. Mostar la carta mas costosa.");
        Console.WriteLine(new string('=', 30));

        int op = int.Parse(Console.ReadLine());

        while (op != 1 && op != 2){
            Console.WriteLine("Por favor selecciona una opcion:"),
            op = int.Parse(Console.ReadLine());
        }

        switch (op){
            case 1:
            Console.WriteLine("Ingresa tu cantidad de gemas:");
            int gemUser = int.Parse(Console.ReadLine());

            if (gemUser <= cartas[i]){
                Console.WriteLine("Aca se encuentran las opciones economicas:");
                Console.WriteLine(cartas[i]);
                Console.ReadKey();
            }

            else {
                Console.WriteLine("No cuentas con gemas suficientes."),
            }
            break;

            case 2:
            Console.WriteLine("Ingresa tu cantidad de gemas:");
            gemUser = int.Parse(Console.ReadLine());

            if (gemUser >= cartas[i]){
                Console.WriteLine("Aca se encuentran las opciones mas costosas:"),
                Console.WriteLine(cartas[i]);
                Console.ReadKey();
            }

            else {
                Console.WriteLine("No cuentas con gemas suficientes.");
            }
            break;

            default:
            Console.WriteLine("Opcion invalida."),
            break;
        }
    }
}
using System;

namespace Ejercicio9;

public class Program{
    public static void Main(string[] args){
        int[] municion = {30 , 15 , 8};
        string[] armas = {"Rifle" , "Pistola" , "Escopeta"};

        for (int i = 0; i < municion.Length; i++){
            Console.WriteLine("---- PRUEBA DE DISPAROS ----");
            Console.WriteLine("Municiones:");
            Console.WriteLine(municion[i]);
            Console.WriteLine("Presiona alguna tecla para ver las armas:");
            Console.ReadKey();
        }

        for (int i = 0; i < armas.Length; i++){
            Console.WriteLine("Armas:");
            Console.WriteLine(armas[i]);
            Console.WriteLine("Presiona alguna tecla para ver las siguientes opciones:"),
            Console.ReadKey();
        }

        Console.WriteLine("Elije un arma:");
        int op1 = int.Parse(Console.ReadLine());

        switch (op1){
            case 1:
            Console.WriteLine("Seleccionaste " + armas[0]);
            Console.WriteLine("DISPARA!");
            municion[0] = int.Parse(Console.ReadLine());

            while (municion[0] != 0){
                Console.WriteLine("Continua disparando.");
                municion[0] = int.Parse(Console.ReadLine());
            }

            if (municion[0] == 0){
                Console.WriteLine("Se te acabo las municiones.");
            }
            break;

            case 2:
              Console.WriteLine("Seleccionaste " + armas[1]);
            Console.WriteLine("DISPARA!");
            municion[1] = int.Parse(Console.ReadLine());

            while (municion[1] != 0){
                Console.WriteLine("Continua disparando.");
                municion[1] = int.Parse(Console.ReadLine());
            }

            if (municion[1] == 0){
                Console.WriteLine("Se te acabo las municiones.");
            }
            break;

            case 3:
              Console.WriteLine("Seleccionaste " + armas[2]);
            Console.WriteLine("DISPARA!");
            municion[2] = int.Parse(Console.ReadLine());

            while (municion[2] != 0){
                Console.WriteLine("Continua disparando.");
                municion[2] = int.Parse(Console.ReadLine());
            }

            if (municion[2] == 0){
                Console.WriteLine("Se te acabo las municiones.");
            }
            break;

            default:
                Console.WriteLine("Arma no valida.");
            break;
        }
    }
}
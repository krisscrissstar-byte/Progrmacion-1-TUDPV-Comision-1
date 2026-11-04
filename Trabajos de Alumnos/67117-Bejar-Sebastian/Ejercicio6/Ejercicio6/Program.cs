/*Consigna: Declarar un array con 4 tipos de gemas ["Fuego", "Hielo", "Rayo", "Veneno"] y solicitar
las cargas de cada una en un vector paralelo. Con un switch permitir:
1: Recargar todas (+5 cargas con bucle for) o
2: Buscar si hay alguna gema agotada (0 cargas con if).*/
using System;

public class Ejercicio6
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] Carga = new int[4];

        for (int i = 0; i < gemas.Length; i++)
        { 
            Console.WriteLine("Ingrese la carga que tiene la gema: " + gemas[i]);
            Carga[i] = int.Parse(Console.ReadLine());
        
        }
           
        Console.Clear();

        Console.WriteLine("Ingrese 1 para recargar todas las gemas con 5 cargas");
        Console.WriteLine("Ingrese 2 para ver si es que hay alguna gema con 0 cargas");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                for (int i = 0; i < gemas.Length; i++)
                {
                    Console.WriteLine("Gema " + gemas[i] + " cargada con 5 cargas");
                    Carga[i] = Carga[i] + 5;
                    Console.WriteLine("Carga actual de la gema " + gemas[i] + ": " + Carga[i]);
                }

                break;

            case 2:
                for (int i = 0; i<gemas.Length; i++)
                {
                    if (Carga[i] <= 0)
                    {
                        Console.WriteLine("La gema " + gemas[i] + " tiene 0 cargas");
                    }
                } 
                break;
            
            default:
                
                break;
        }


    }
}

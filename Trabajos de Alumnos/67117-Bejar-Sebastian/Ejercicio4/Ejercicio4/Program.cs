/*Consigna: Un mazo de 5 cartas tiene sus costos en gemas en un array: { 10, 25, 50, 80, 120 }.
Pedir las gemas del usuario y ofrecer con un switch:
1: Mostrar cartas que puede pagar (filtrando con for e if),
2: Identificar la carta más cara del catálogo*/
using System;

class Ejercicio4
{
    static void Main()
    {

        int[] gemas = { 10, 25, 50, 80, 120 };
        string[] mazo = {"Corazon", "Diamante", "Pica", "Trebol", "Joker"};
        int GemUsuario = 0;
        int opcion = 0;
        int i = 0;
   

        Console.WriteLine("Cuantas gemas tiene disponibles?");
        GemUsuario = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese 1 si quiere ver las cartas que puede pagar");
        Console.WriteLine("Ingrese 2 si quiere ver la carta mas cara del catalogo");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                    for (i = 0; i< gemas.Length; i++)
                    {
                        if (GemUsuario >= gemas[i])
                        {
                            Console.WriteLine("Con las gemas disponibles puede comprar la carta: " + mazo[i]);
                        }
                        else if(GemUsuario <= 9)
                        {
                            Console.WriteLine("No le alcanza para comprar ninguna Gema");
                            break;
                    }
                        
                    }

                break;
              

            case 2:


                Console.WriteLine("La carta mas cara es: " + mazo[4] + " con un valor de " + gemas[4] + " gemas");

                break;

            default: 
                break;
        }

             


    }
}

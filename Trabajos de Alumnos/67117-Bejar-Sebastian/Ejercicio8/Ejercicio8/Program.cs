/*Consigna: Cargar con un for el daño recibido en las 3 fases de un Jefe en un array de enteros.
Mediante un switch permitir:
1: Calcular promedio de daño entre las 3 fases,
2: Identificar la fase más destructiva mediante comparaciones if.*/

using System;
public class Ejercicio8
{
    static void Main()
    {
        int[] dano = new int[3];
        int opcion = 0;
        int comparacion = 0;
        int puntero = 0;

            for (int i = 1; i < dano.Length+1; i++)
        {
            Console.WriteLine("Ingrese el dano recibido en la fase " +  i + " del jefe");
            dano[i-1]=int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ingrese 1 para calcular el daño promedio de las 3 fases.");
        Console.WriteLine("Ingrese 2 para identificar la fase mas destructiva");
        opcion = int.Parse(Console.ReadLine());
     
          switch (opcion)
            {
                case 1:

                        int promedio = 0;
                        for(int i = 0; i < dano.Length ; i++)
                        {
                            promedio = promedio + dano[i];
                           
                        }
                    promedio = promedio / dano.Length;
                    Console.WriteLine("El daño promedio es entre las 3 fases es de: " + promedio);

                    break;

                case 2: 
                        for(int i = 0; i< dano.Length; i++)
                        {
                            if (dano[i] > comparacion)
                            {
                                 comparacion = dano[i];
                                 puntero = i + 1;
                            }

                        }
                        Console.WriteLine("La fase mas destructiva es la fase: " + puntero);
                        

                    break;

                default:
                    Console.WriteLine("ERROR!!!. Las opciones disponibles son 1 y 2"); 
                    break;
            }
       


    }
}
/*Consigna: Cargar con un bucle for el daño de 6 flechas en un array de enteros. Luego, con un
bucle while pedir un daño de referencia y filtrar con if/else los impactos que superaron ese
número, acumulando y mostrando el total de daño filtrado.*/
using System;

public class Ejercicio5
{
    static void Main()
    {

        int[] dano = new int[6];
        int i = 0;
        int contador = 0;
        int DanoTotal = 0;


        for (i = 0; i < dano.Length; i++) 
        {
            Console.WriteLine("Ingrese el daño de la flecha: " + i);
            dano[i] = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        Console.WriteLine("Ingrese un daño de referencia para analizar");
        int analizar = int.Parse(Console.ReadLine());

        
        i = 0;
        while (i < dano.Length) 
        {
         
            if (analizar <= dano[i])
            {
                DanoTotal = DanoTotal + dano[i];
                contador++;
            }
             i++;
            
            

        }

        Console.WriteLine("La cantidad de Flechas que superaron el daño de referencia fueron: " + contador);
        Console.WriteLine("El total de daño inflingido por las flechas filtradas es: " + DanoTotal);





    }
}
/*Consigna: Un soldado dispone de un array de munición { 30, 15, 8 } correspondiente a Rifle,
Pistola y Escopeta. Con un bucle while permitir realizar disparos sucesivos eligiendo el arma
mediante un switch hasta que el usuario ingrese 0. Con if/else validar si el arma tiene balas
suficientes o se encuentra vacía.*/

using System;
using System.Timers;
public class Ejercicio9
{
    static void Main()
    {
        int[] balas = { 30, 15, 8 };
        string[] armas = { "Rifle", "Pistola", "Escopeta" };
        int opcion = -1;
   
        while (opcion != 0)
        {
            Console.WriteLine("Escoja el arma con la que quiere disparar");
            Console.WriteLine("1 = Rifle / 2 = Pistola / 3 = Escopeta / 0 = Dejar de disparar");
            opcion = int.Parse(Console.ReadLine());

            int indice = -1;
            switch (opcion)
            {
                case 1:
                    indice = 0;
                    break;

                case 2: 
                    indice = 1; 
                    break;

                case 3: 
                    indice = 2; 
                    break;

                case 0: 
                    Console.WriteLine("Fin del programa"); 
                    break;

                default: 
                    Console.WriteLine("Opcion invalida, intente nuevamente"); 
                    break;
            }

            if (indice != -1)
            {
                if (balas[indice] > 0)
                {
                    balas[indice]--;
                    Console.WriteLine("Disparo con el arma: " + armas[indice]);
                    Console.WriteLine("Balas restantes: " + balas[indice]);
                }
                else
                {
                    Console.WriteLine("El arma " + armas[indice] + " no tiene balas");
                }
            }


            
        }


    }
}

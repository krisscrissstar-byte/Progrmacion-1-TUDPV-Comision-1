using System;
class Program
{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] Durabilidad = new int[4];
        int i;

        for (i = 0; i < armas.Length; i++)
        {
            Console.WriteLine("Ingrese la durabilidad del arma: " + armas[i]);
            Durabilidad[i] = int.Parse(Console.ReadLine()); 
        }

        Console.Clear();

        Console.WriteLine("Ingrese 1 si quiere inspeccionar las armas que se encuentran en estado critico");
        Console.WriteLine("Ingrese 2 si quiere ver el arsenal de armas completo junto a su durabilidad");
        int opcion = int.Parse(Console.ReadLine());


        switch (opcion){

            case 1:
                for (i=0; i < armas.Length; i++)
                {

                    if (Durabilidad[i] <= 20)
                    {
                        Console.WriteLine("ALERTA!!!");
                        Console.WriteLine("El arma " + armas[i] + " se encuentra en estado critico, con una durabilidad de: " + Durabilidad[i]);
                    }

                }
                break;


            case 2:
                Console.WriteLine("Listado completo de armas");
                
                for (i=0; i < armas.Length;i++)
                {
                    Console.WriteLine("El arma " + armas[i] + "Tiene una durabilidad de: " + Durabilidad[i]);    
                }

                break;
            
            
            default:
                break;

        }

  
    }
}

using System;

class inventarioyDurabilidad
{
    static void Main()
    {
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[4];

        for (int i = 0; i < 4; i++)
        {

            Console.Write("Ingrese la durabilidad de su " + armas[i] + ":");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        Console.Write();
        Console.WriteLine("_Opciones_");
        Console.WriteLine("1:Inspeccionar armas criticas");
        Console.WriteLine("2:Ver arsenal completo")
        Console.Write("Elija una opcion:");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Armas Criticas con Durabilidad <= 20)");
                Console.WriteLine("-------------------------------------");
                for (int i = 0; i < 4; i++)
                {

                    if (durabilidad[i] <= 20)
                    {
                        Console.WriteLine("!ALERTA¡ El arma " + armas[i] + " esta en estado critico: " + durabilidad[i]);
                    }
                }
                break;

            case 2:

                Console.WriteLine("----------------");
                Console.WriteLine("Arsenal completo");
                Console.WriteLine("----------------");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(armas[i] + " Durabilidad:" + durabilidad[i]);
                }

                break;
        }
        Console.ReadKey();
    }
}

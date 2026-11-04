using System;

class FesesdeBoss
{
    static void Main()
    {
        int[] danioFases = new int[3];

        Console.WriteLine("+++REGISTRO DE DAÑO POR FASES DEL BOSS+++");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingrese el daño recibido en la Fase " + (i + 1) + ": ");
            danioFases[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Menu de estadisticas");
        Console.WriteLine("1: Calcular promedio de daño entre las 3 fases");
        Console.WriteLine("2: Identificar la fase más destructiva");
        Console.Write("Elija una opción:");
       
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int suma = danioFases[0] + danioFases[1] + danioFases[2];
                float promedio = (float)suma / 3f;
                Console.WriteLine();
                Console.WriteLine("El promedio de daño recibido fue: " + promedio + " HP");
                break;

            case 2:
                int mayorDanio = danioFases[0];
                int faseMasDestructiva = 1;

                if (danioFases[1] > mayorDanio)
                {
                    mayorDanio = danioFases[1];
                    faseMasDestructiva = 2;
                }
                if (danioFases[2] > mayorDanio)
                {
                    mayorDanio = danioFases[2];
                    faseMasDestructiva = 3;
                }

                Console.WriteLine();
                Console.WriteLine("La fase más destructiva fue la Fase " + faseMasDestructiva + " con " + mayorDanio + " de daño");
                break;
        }

        Console.ReadKey();
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        float[] tiempos = new float[5];

        Console.WriteLine("=== MARCADOR TOP 5 DE SPEEDRUN ===");
        Console.WriteLine("Carga de tiempos de los 5 corredores (en segundos):");

        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write($"Ingrese el tiempo del corredor {i + 1}: ");
            while (!float.TryParse(Console.ReadLine(), out tiempos[i]) || tiempos[i] <= 0)
            {
                Console.Write("Tiempo no válido. Ingrese un número positivo: ");
            }
        }

        Console.Write("\nIngrese el tiempo objetivo (marca exigida): ");
        if (float.TryParse(Console.ReadLine(), out float tiempoObjetivo))
        {
            int clasificados = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] <= tiempoObjetivo)
                {
                    clasificados++;
                }
            }

            if (clasificados > 0)
            {
                Console.WriteLine($"\nResultados: {clasificados} corredor(es) superaron la prueba (tiempo <= {tiempoObjetivo}s).");
            }
            else
            {
                Console.WriteLine($"\nResultados: Ningún corredor logró un tiempo menor o igual a {tiempoObjetivo}s.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
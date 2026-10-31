string[] Corredores ={"Carlos", "Marlos", "Charcos", "John", "Chimuelo"};
float[] TiemposDeCorredores = { 12.5f, 5, 13.2f, 17.8f, 10.2f };



for (int i = 0; i < Corredores.Length; i++)
{
    Console.WriteLine($"El corredor {Corredores[i]} tiene un tiempo de {TiemposDeCorredores[i]} segundos.");
}

Console.WriteLine("Ingrese el tiempo objetivo");


if(float.TryParse(Console.ReadLine(), out float tiempoObjetivo))
{
    Console.Clear();
    Console.WriteLine($"Tiempo objetivo: {tiempoObjetivo} segundos:");

    for (int i = 0; i < Corredores.Length; i++)
    {
        if (TiemposDeCorredores[i] < tiempoObjetivo)
        {
            Console.WriteLine($"- {Corredores[i]}: {TiemposDeCorredores[i]} segundos (esta debajo del tiempo objetivo)");
        }
        else if (TiemposDeCorredores[i] >= tiempoObjetivo)
        {
            Console.WriteLine($"- {Corredores[i]}: {TiemposDeCorredores[i]} segundos (esta sobre el tiempo objetivo)");
        }
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
}


Console.ReadKey();
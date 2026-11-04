float[] misionExp = new float[5];
string[] misionNombre = { "mision 1", "mision 2", "mision 3", "mision 4", "mision 5" };

float misionExpBoost = 0.20f;

for (int i = 0; i < misionExp.Length; i++)
{
    Console.WriteLine($"Escriba la exp ganada en {misionNombre[i]} (max 200)");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");

    if(float.TryParse(Console.ReadLine(), out misionExp[i]) && misionExp[i] >= 0 && misionExp[i] <= 200)
    {
        if (misionExp[i] > 100)
        {
            Console.Clear();
            misionExp[i] += misionExp[i] * misionExpBoost;

            Console.WriteLine("Su exp recibio un bono del 20%");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine($"La exp que gano en {misionNombre[i]} es: {misionExp[i]}");
            Thread.Sleep(1000);
            Console.Clear();
        }
        else
        {
            Console.Clear();;
            Console.WriteLine($"La exp que gano en {misionNombre[i]} es: {misionExp[i]}");

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("error");
        Console.WriteLine("intente otra vez");

        Thread.Sleep(1000);
        i--;
        Console.Clear();
    }
}

Console.Clear();
for (int i = 0; i < misionExp.Length;i++)
{
    Console.WriteLine($"La exp que gano en {misionNombre[i]} es de: {misionExp[i]} exp");
    Thread.Sleep(500);

    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - |");
}
Console.WriteLine("");
Console.WriteLine("toque una tecla para terminar");

Console.ReadKey();
Console.Clear();
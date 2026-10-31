int[] FlechasNum = new int[6];
string[] FlechasNombre = { "1", "2", "3", "4", "5", "6" };

int JugadorInput;

for (int i = 0; i < FlechasNum.Length; i++)
{
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
    Console.WriteLine($"Escriba el daño de la flecha {FlechasNombre[i]} (max 30)");
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");

    if (int.TryParse(Console.ReadLine(), out JugadorInput) && JugadorInput > 0 && JugadorInput < 31)
    {
        FlechasNum[i] = JugadorInput;
        Console.WriteLine($"el daño de la flecha {FlechasNombre[i]} es {FlechasNum[i]}");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("error");
        Thread.Sleep(1000);
        Console.Clear();
        i--;
    }
}

int JugadorResistencia;

Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("Escriba la resistencia de su personaje (max 30)");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");

do
{
    if (int.TryParse(Console.ReadLine(), out JugadorResistencia) && JugadorResistencia > 0 && JugadorResistencia < 31)
    {
        Console.Clear();

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine($"Usted tiene {JugadorResistencia} de resistencia");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - -");
        Thread.Sleep(1000);
        continue;
    }
    else
    {
        Console.WriteLine("error");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("Escriba la resistencia de su personaje (max 30)");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
    }
}
while (JugadorResistencia < 0 || JugadorResistencia > 30);


int DañoTotal = 0;

Console.WriteLine("Las flechas que atravesaron su armadura son:");
for (int i = 0; i < FlechasNum.Length; i++)
{
    if (FlechasNum[i] >= JugadorResistencia)
    {
        Console.WriteLine($"La flecha {FlechasNombre[i]} atravezo su armadura");
        DañoTotal += FlechasNum[i];
        Thread.Sleep(500);
    }
}

Thread.Sleep(1000);
Console.Clear();

Console.WriteLine($"Daño total acumulado: {DañoTotal}");
Console.ReadKey();



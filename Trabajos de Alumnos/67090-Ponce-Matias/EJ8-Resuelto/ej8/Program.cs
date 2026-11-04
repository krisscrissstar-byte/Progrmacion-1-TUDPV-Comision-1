int[] jefeDaño = new int[3];
string[] jefeFase = { "fase 1", "fase 2", "fase 3" };


for (int i = 0; i < jefeDaño.Length; i++)
{
    Console.WriteLine($"Escriba el daño de la {jefeFase[i]}. (max 30)");
    Console.WriteLine("- - - - - - - - - - - - - - - -");

    if (int.TryParse(Console.ReadLine(), out jefeDaño[i]) && jefeDaño[i] >= 0 && jefeDaño[i] <= 30)
    {
        Console.Clear();
        Console.WriteLine($"El daño de la {jefeFase[i]} es: {jefeDaño[i]}");
        Thread.Sleep(1000);

        Console.Clear();
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


bool continuarPrograma = true;
int jugadorInput;

int maxJefeDaño = jefeDaño.Max(); //busca el numero mas alto en el array//
int maxJefeFase = Array.IndexOf(jefeDaño, maxJefeDaño); //busca el index de maxJefeDaño dentro de jefeDaño//  

int jefeDañoPromedioSuma = jefeDaño[0] + jefeDaño[1] + jefeDaño[2];
double jefeDañoPromedioDivision = jefeDañoPromedioSuma / jefeDaño.Length;
double jefeDañoPromedioResultado = jefeDañoPromedioDivision;


while (continuarPrograma)
{
    Console.WriteLine("Escriba una opcion");
    Console.WriteLine("- - - - - - - - - -");

    Console.WriteLine("1. Calcular daño promedio");
    Console.WriteLine("2. Calcular fase mas destructiva");
    Console.WriteLine("3. Terminar Programa");

    if (int.TryParse(Console.ReadLine(), out jugadorInput) && jugadorInput >= 1 && jugadorInput <= 3)
    {
        switch (jugadorInput)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"El daño promedio es: {jefeDañoPromedioResultado}");

                Thread.Sleep(1000);
                Console.Clear();
                break;

            case 2:
                Console.Clear();
                Console.WriteLine($"La fase mas destructiva es la {jefeFase[maxJefeFase]}.");
                Console.WriteLine($"Con un daño de: {maxJefeDaño}");

                Thread.Sleep(1000);
                Console.Clear();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("terminando programa...");
                Thread.Sleep(1000);

                continuarPrograma = false;
                Console.ReadKey();
                Console.Clear();

                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("error");
        Console.WriteLine("intente otra vez");

        Thread.Sleep(1000);
        Console.Clear();
    }
}
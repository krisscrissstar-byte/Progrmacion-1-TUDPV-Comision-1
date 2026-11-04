// See https://aka.ms/new-console-template for more information

// Trabajo Practico N° 2 – Pre Parcial
// Marcelo Ezequiel Cerri/ 67035 / comision1

static void ejercicio1()
{
    string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
    int[] durabilidad = new int[4];

    for (int i = 0; i< armas.Length; i++)
    {
        Console.Write("ingrese la durabilidad del" + armas[i] + ": ");
        durabilidad[i] = int.Parse(Console.ReadLine());

    }

    Console.WriteLine("ver arsenal completo");
    Console.Write("elije una opcion: ");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("armas criticas:");

            for(int i = 0; i < armas.Length; i++)
            {
                if (durabilidad[i] <= 20)
                {
                    Console.WriteLine("Alerta: " + armas[i] + " tiene " + durabilidad[i] + " de durabilidad ");

                }
            }
            break;
        case 2:
            Console.WriteLine("Arsenal Completo");

            for(int i = 0;i < armas.Length; i++)
            {
                Console.WriteLine(armas[i] + " - durabilidad: " + durabilidad[i]);
            }
            break;

        default:
            Console.WriteLine("Error.");
            break;
      


    }

}

static void ejercicio2()
{
    float[] tiempos = new float[5];


    for(int i = 0; i < tiempos.Length; i++)
    {
        Console.Write("ingrese el tiempo del corredor " + (i + 1) + ": ");
        tiempos[i] = float.Parse(Console.ReadLine());
    }

    string continuar = "si";

    while ( continuar == "si")
    {
        Console.Write("ingrese el tiempo objetivo: ");
        float objetivo = float.Parse(Console.ReadLine());

        int superar = 0;

        for(int i = 0;i < tiempos.Length; i++)
        {
            if (tiempos[i] <= objetivo)
            {
                superar++;
            }
        }
        Console.WriteLine("Corredores que superaron la prueba: " + superar);

        Console.Write("¿Desea ingresar otro tiempo objetivo? (si/no): ");
        continuar = Console.ReadLine();
    }
}

static void ejercicio3()
{
    int[] slimes = { 30, 40, 50, 60 };

    while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
    {
        Console.WriteLine("\nVida de los slimes:");
        Console.WriteLine("Slime 0: " + slimes[0]);
        Console.WriteLine("Slime 1: " + slimes[1]);
        Console.WriteLine("Slime 2: " + slimes[2]);
        Console.WriteLine("Slime 3: " + slimes[3]);

        Console.Write("Elige un slime para atacar (0-3): ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                if (slimes[opcion] <= 0)
                {
                    Console.WriteLine("Ese slime ya fue derrotado.");
                }
                else
                {
                    slimes[opcion] -= 20;
                    Console.WriteLine("¡Atacaste al slime!");
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }

    Console.WriteLine("¡Todos los slimes fueron derrotados!");
}

static void ejercicio4()
{
    int[] costos = { 10, 25, 50, 80, 120 };

    Console.Write("cuantas gemas tienes?: ");
    int gemas = int.Parse(Console.ReadLine());

    Console.WriteLine("\n1. Mostrar cartas que puedo pagar");
    Console.WriteLine("2. Mostrar la carta más cara");
    Console.Write("Elige una opción: ");
    int opcion = int.Parse(Console.ReadLine());


    switch (opcion)
    {

        case 1:
            Console.WriteLine("Cartas que puedes pagar:");

            for (int i = 0; i < costos.Length; i++)
            {
                if (gemas >= costos[i])
                {
                    Console.WriteLine("Carta " + i + " - " + costos[i] + " gemas");
                }
                else
                {
                    Console.WriteLine("Carta " + i + " - No puedes pagarla");
                }
            }
            break;

        case 2:
            int mayor = costos[0];

            for (int i = 1; i < costos.Length; i++)
            {
                if (costos[i] > mayor)
                {
                    mayor = costos[i];
                }
            }

            Console.WriteLine("La carta más cara cuesta " + mayor + " gemas.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;

    }

}

static void ejercicio5()
{
    int[] danos = new int[6];

    for (int i = 0; i < danos.Length; i++)
    {
        Console.Write("Ingrese el daño de la flecha " + i + ": ");
        danos[i] = int.Parse(Console.ReadLine());
    }

    int referencia;
    int total = 0;

    while (true)
    {
        Console.Write("\nIngrese el daño de referencia: ");
        referencia = int.Parse(Console.ReadLine());

        if (referencia >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("El daño de referencia no puede ser negativo.");
        }
    }

    Console.WriteLine("\nImpactos que superaron la referencia:");

    for (int i = 0; i < danos.Length; i++)
    {
        if (danos[i] > referencia)
        {
            Console.WriteLine("Flecha " + i + ": " + danos[i]);
            total += danos[i];
        }
        else
        {
            Console.WriteLine("Flecha " + i + ": no supera la referencia.");
        }
    }

    Console.WriteLine("\nDaño total filtrado: " + total);
}

static void ejercicio6()
{
    string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
    int[] cargas = new int[4];

    for (int i = 0; i < cargas.Length; i++)
    {
        Console.Write("Ingrese las cargas de " + gemas[i] + ": ");
        cargas[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\n1. Recargar todas las gemas");
    Console.WriteLine("2. Buscar gemas agotadas");
    Console.Write("Elige una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            for (int i = 0; i < cargas.Length; i++)
            {
                cargas[i] += 5;
            }

            Console.WriteLine("Todas las gemas fueron recargadas.");
            break;

        case 2:
            for (int i = 0; i < cargas.Length; i++)
            {
                if (cargas[i] == 0)
                {
                    Console.WriteLine(gemas[i] + " está agotada.");
                }
                else
                {
                    Console.WriteLine(gemas[i] + " tiene " + cargas[i] + " cargas.");
                }
            }
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}

static void ejercicio7()
{
    bool[] trampas = { false, true, false, false, true, false };

    int posicion = 0;
    bool perdio = false;

    while (posicion < 5 && !perdio)
    {
        Console.WriteLine("Estás en la baldosa " + posicion);

        if (trampas[posicion])
        {
            Console.WriteLine("¡Pisaste una trampa! Perdiste.");
            perdio = true;
        }
        else
        {
            Console.WriteLine("No hay trampa. Avanzas.");
            posicion++;
        }
    }

    if (!perdio)
    {
        Console.WriteLine("¡Llegaste a la meta!");
    }
    else
    {
        Console.WriteLine("Fin del juego.");
    }
}

static void ejercicio8()
{
    int[] danos = new int[3];

    for (int i = 0; i < danos.Length; i++)
    {
        Console.Write("Ingrese el daño recibido en la fase " + (i + 1) + ": ");
        danos[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\n1. Calcular promedio");
    Console.WriteLine("2. Identificar fase más destructiva");
    Console.Write("Elige una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            int total = 0;

            for (int i = 0; i < danos.Length; i++)
            {
                total += danos[i];
            }

            double promedio = (double)total / danos.Length;

            Console.WriteLine("Promedio de daño: " + promedio);
            break;

        case 2:
            int mayor = danos[0];
            int fase = 1;

            for (int i = 1; i < danos.Length; i++)
            {
                if (danos[i] > mayor)
                {
                    mayor = danos[i];
                    fase = i + 1;
                }
            }

            Console.WriteLine("La fase con mayor daño fue la fase " + fase);
            Console.WriteLine("Daño recibido: " + mayor);
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}

static void ejercicio9()
{
    int[] municion = { 30, 15, 8 };

    int opcion = -1;

    while (opcion != 0)
    {
        Console.WriteLine("\nMunición:");
        Console.WriteLine("Rifle: " + municion[0]);
        Console.WriteLine("Pistola: " + municion[1]);
        Console.WriteLine("Escopeta: " + municion[2]);

        Console.WriteLine("\n1. Rifle");
        Console.WriteLine("2. Pistola");
        Console.WriteLine("3. Escopeta");
        Console.WriteLine("0. Salir");
        Console.Write("Elige un arma: ");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                if (municion[0] > 0)
                {
                    municion[0]--;
                    Console.WriteLine("¡Disparo de rifle!");
                }
                else
                {
                    Console.WriteLine("El rifle está vacío.");
                }
                break;

            case 2:
                if (municion[1] > 0)
                {
                    municion[1]--;
                    Console.WriteLine("¡Disparo de pistola!");
                }
                else
                {
                    Console.WriteLine("La pistola está vacía.");
                }
                break;

            case 3:
                if (municion[2] > 0)
                {
                    municion[2]--;
                    Console.WriteLine("¡Disparo de escopeta!");
                }
                else
                {
                    Console.WriteLine("La escopeta está vacía.");
                }
                break;

            case 0:
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
}

static void ejercicio10()
{
    int[] experiencia = new int[5];

    for (int i = 0; i < experiencia.Length; i++)
    {
        bool valido = false;

        while (!valido)
        {
            Console.Write("Ingrese la EXP de la misión " + (i + 1) + ": ");
            if (int.TryParse(Console.ReadLine(), out experiencia[i]))
            {

                valido = true;

                if (experiencia[i] > 100)
                {
                    experiencia[i] = experiencia[i] + (experiencia[i] * 20 / 100);
                }
                else
                {
                    Console.WriteLine("La misión no recibe bono.");
                }
            }
            else
            {
                Console.WriteLine("ERROR: Debes ingresar un número entero.");
            }

        }

        

    }

    int total = 0;

    Console.WriteLine("\n--- EXP ACTUALIZADA ---");

    for (int i = 0; i < experiencia.Length; i++)
    {
        Console.WriteLine("Misión " + (i + 1) + ": " + experiencia[i] + " EXP");
        total += experiencia[i];
    }

    Console.WriteLine("\nExperiencia total acumulada: " + total);
}





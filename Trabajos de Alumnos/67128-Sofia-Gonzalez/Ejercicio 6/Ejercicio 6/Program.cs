using System;

class ElementosyCargasMagicas
{
    static void Main()
    {
        string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];

        Console.WriteLine("~~Gemas Magicas~~");
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Ingrese la carga inicial para la gema " + gemas[i] + ": ");
            cargas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("¨¨OPCIONES¨¨");
        Console.WriteLine("1: Recargar todas las gemas con +5 de carga");
        Console.WriteLine("2: Buscar si hay alguna gema agotada");
        Console.Write("Elija una opción:");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                Console.WriteLine("--- Recargando todas las gemas (+5) ---");

                for (int i = 0; i < 4; i++)
                {
                    cargas[i] = cargas[i] + 5;
                    Console.WriteLine("La gema " + gemas[i] + " ahora tiene: " + cargas[i] + " cargas");
                }
                break;

            case 2:
                Console.WriteLine("Revisando gemas agotadas...");


                for (int i = 0; i < 4; i++)
                {
                    if (cargas[i] == 0)
                    {
                        Console.WriteLine("¡Alerta! La gema de " + gemas[i] + " está agotada");
                    }
                }
                break;
        }
    }
}
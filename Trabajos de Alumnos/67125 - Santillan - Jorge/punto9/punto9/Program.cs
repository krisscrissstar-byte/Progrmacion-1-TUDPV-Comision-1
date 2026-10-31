int[] municion = {30, 15, 8};
bool salir = false;

while (!salir)
{
    Console.WriteLine("Seleccione un arma:");
    Console.WriteLine("1. Rifle");
    Console.WriteLine("2. Pistola");
    Console.WriteLine("3. Escopeta");
    Console.WriteLine("4. Salir");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            {
                if (municion[0] > 0)
                {
                    Console.WriteLine("Pum");
                    municion[0]--;
                }
                else
                {
                    Console.WriteLine("Sin municion");
                }
                break;
            }
        case 2:
            {
                if (municion[1] > 0)
                {
                    Console.WriteLine("Pum");
                    municion[1]--;
                }
                else
                {
                    Console.WriteLine("Sin municion");
                }
                break;
            }
            case 3:
            {
                if (municion[2] > 0)
                {
                    Console.WriteLine("Pum");
                    municion[2]--;
                }
                else
                {
                    Console.WriteLine("Sin municion");
                }
                break;
            }
            case 0:
            {
                salir = true;
                Console.WriteLine("Saliendo del campo de batalla");
                break;
            }
    }
}

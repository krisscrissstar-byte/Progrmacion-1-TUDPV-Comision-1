/*Ejercicio 9: Sistema de Munición y Disparo por Cargador*/

int[] municion = {30, 15, 8};

bool salir = false;

while (!salir)
{
    Console.WriteLine("1.Rifle");
    Console.WriteLine("2.Pistola");
    Console.WriteLine("3.Escopeta");
    Console.WriteLine("0.Salir");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            if (municion[0] > 0)
            {
                Console.WriteLine("PUM");
                municion[0]--;
            }
            else
            {
                Console.WriteLine("Sin munición");
            }
            break;
        case 2:
            if (municion[1] > 0)
            {
                Console.WriteLine("PUM");
                municion[1]--;
            }
            else
            {
                Console.WriteLine("Sin munición");
            }
            break;
        case 3:
            if (municion[2] > 0)
            {
                Console.WriteLine("PUM");
                municion[2]--;
            }
            else
            {
                Console.WriteLine("Sin munición");
            }
            break;
        case 0:

            salir = true;
            Console.WriteLine("Saliendo. . .");
            break;

    }
}


/*
Un soldado dispone de un array de munición {30, 15, 8} correspondiente a Rifle, 
Pistola y Escopeta. Con un bucle while permitir realizar disparos sucesivos 
eligiendo el arma mediante un switch hasta que el usuario ingrese 0. Con 
if/else validar si el arma tiene balas suficientes o se encuentra vacía 
*/

int[] municion = {30,15,8};
bool dispara = true;
int opcion;

while (dispara)
{
    Console.WriteLine("Vamos a disparar, elegí tu arma:");
    Console.WriteLine($"1. Rifle ({municion[0]} balas)");
    Console.WriteLine($"2. Pistola ({municion[1]} balas)");
    Console.WriteLine($"3. Escopeta ({municion[2]} balas)");
    Console.WriteLine($"0. Dejar de disparar");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            if (municion[0] > 0)
            {
                municion[0]--;
                Console.WriteLine("\n¡PUM! Has disparado el Rifle. Balas restantes: " + municion[0]);
            }
            else
            {
                Console.WriteLine("\n¡El Rifle no tiene balas suficientes! Se encuentra vacío.");
            }
            Console.WriteLine("Toca cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            if (municion[1] > 0)
            {
                municion[1]--; 
                Console.WriteLine("\n¡PUM! Has disparado la Pistola. Balas restantes: " + municion[1]);
            }
            else
            {
                Console.WriteLine("\n¡La Pistola no tiene balas suficientes! Se encuentra vacía.");
            }
            Console.WriteLine("Toca cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            if (municion[2] > 0)
            {
                municion[2]--;
                Console.WriteLine("\n¡BOOM! Has disparado la Escopeta. Balas restantes: " + municion[2]);
            }
            else
            {
                Console.WriteLine("\n¡La Escopeta no tiene balas suficientes! Se encuentra vacía.");
            }
            Console.WriteLine("Toca cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 0:
            dispara = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Presione de nuevo para volver a ver las opciones.");
            Console.ReadKey();
            break;
    }
    
}
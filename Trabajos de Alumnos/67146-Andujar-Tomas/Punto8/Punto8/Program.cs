/*
 
Cargar con un for el daño recibido en las 3 fases de un Jefe en un array de enteros. 
Mediante un switch permitir: 
1: Calcular promedio de daño entre las 3 fases, 
2: Identificar la fase más destructiva mediante comparaciones if
 
*/

int [] dañoRecibido = new int [3];
int promedio;
int opcion;
int auxiliar;

for (int i = 0; i < 3; i++) 
{
    Console.WriteLine($"Ingresa el daño que te hicieron en la fase {i+1}:");
    dañoRecibido [i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("¿Qué quieres hacer?");
Console.WriteLine("1. Calcular el promedio de daño");
Console.WriteLine("2. Fase más destructiva");
Console.WriteLine("Cualquier otro num para salir");

opcion = int.Parse(Console.ReadLine());
auxiliar = dañoRecibido[0];

switch (opcion)
{
    case 1:
        promedio = (dañoRecibido[0] + dañoRecibido[1] + dañoRecibido[2]) / 3;
        Console.WriteLine("El promedio de daño entre las 3 fases es: " + promedio);
        break;
    case 2:
        for (int i = 0; i < dañoRecibido.Length; i++)
        {
            if (auxiliar < dañoRecibido[i])
            {
                auxiliar = dañoRecibido[i];
            }
        }
        Console.WriteLine("La fase más destructiva fue: " + auxiliar);
        break;
    default:
        break;
}
// Ejercicio 1 
string[] armas = { " Espada ", " Hacha ", " Arco ", " Daga " };

int[] durabilidad = new int[4];


for (int i = 0; i < 4; i ++ )
{
    Console.Write(" Ingrese durabilidad de " + armas[i] + ":");

    durabilidad[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("1: Inspeccionar armas criticas");
Console.WriteLine("2: Ver arsenal completo");
Console.Write("Elija una opcion:");
int opcion = int.Parse(Console.ReadLine()); 


switch (opcion);
{ Case 1: 
        Console.WriteLine("Armas criticas:");
    for (int   = 0;   < length;  ++)
    {
        if (durabilidad[i] < = 20) ;
        {
            Console.WriteLine("Alerta :" + armas[i] + " tiene durabilidad critica: " + durabilidad[i]);
        }
        
    }
    break; 
    
    Case 2:
        Console.WriteLine();
    Console.WriteLine("Arsenal completo:");
    for (in= 0<; i < 4; i++)
    {
        Console.WriteLine(armas[i] + ": " + durabilidad[i]); 

    }

    break; 
    default:
        Console.WriteLine("Opcion invalidad.");

    break;
        
    }





}



//Ejercico 8 
{
    int [] fases = new int[3];
for (int = 0; i < fases.Length; i++)

   { 
    Console Write(" Daño recibido en la fase " + (i + 1) + " : ");
    fases[i] = int.Parse(Console.ReadLine());
    }

Console.WriteLine("1 Calcular promedio ");
Console.WriteLine("2: Identificar la fase mas destructiva ");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        int suma = 0;
        for (int i = 0; i < fases.Length; i++)
        {
            suma + = fases[i];
        }
            float promedio = (float)suma / fases.Length;
            Console.WriteLine("Promedio de daño: " + promedio);
            break;
    case 2:
        if (fases[0] >= fases[1] && fases[0] >= fases[2])
            Console.WriteLine("La fase mas destructiva fue la 1");
        else if (fases[1] >= fases[0] && fases[1] >= fases[2])
            Console.WriteLine("La fase mas destructiva fue la 2");
        else
            Console.WriteLine("La fase mas destructiva fue la 3");
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;

        }
     }   
}


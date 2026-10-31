// Ejercicio 1 //

string[] ArmasNombre = new string[4]{ "Espada", "Arco", "Hacha", "Daga" };
int[] ArmasDurabilidad = new int[4];
int i;


for(i = 0; i<ArmasDurabilidad.Length; i++)
{
    Console.WriteLine("Define la durabilidad de " + ArmasNombre[i]);
    

    if (int.TryParse(Console.ReadLine(), out ArmasDurabilidad[i]))
    {
        if(ArmasDurabilidad[i] > 0 && ArmasDurabilidad[i] <= 100)
        {
            Console.WriteLine("La durabilidad de " + ArmasNombre[i] + " es: " + ArmasDurabilidad[i] + "%");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("La durabilidad de " + ArmasNombre[i] + " es invalida, puede ser de 1 a 100");
            Thread.Sleep(1000);
            i--;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, ingresa un número.");
        Thread.Sleep(2000);
        i--;
    }

    Console.Clear();
}

//defino estas variables aqui y no arriba ya que solo se utilizan en el bloque de abajo//

int JugadorOpcionInput;
bool JugadorInputValido = false;

Console.WriteLine("Elige 1 para inspeccionar armas criticas");
Console.WriteLine("o");
Console.WriteLine("Elige 2 para ver arsenal completo");


do //este codigo funciona raro si usan muchas opciones invalidas o asi, igual funciona//
{
    if (int.TryParse(Console.ReadLine(), out JugadorOpcionInput))
    {
        switch (JugadorOpcionInput)
        {
            case 1: //a veces hay que escribir "-1" o " 1" para que funcione, rarisimo//
                Console.Clear();
                for (i = 0; i < ArmasDurabilidad.Length; i++)
                {
                    if (ArmasDurabilidad[i] < 20)
                    {
                        Console.WriteLine("La durabilidad de " + ArmasNombre[i] + " es critica! (durabilidad " + ArmasDurabilidad[i] + "%)");
                    }
                }
                JugadorInputValido = true;
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                for (i = 0; i < ArmasDurabilidad.Length; i++)
                {
                    Console.WriteLine("La durabilidad de " + ArmasNombre[i] + " es: " + ArmasDurabilidad[i] + "%");
                }
                JugadorInputValido = true;
                Console.ReadKey();
                break;
            default: //al escribir un string en vez de un int esta bloque no se ejecuta, sin embargo el codigo igual funciona y se puede ingresar 1 o 2 para continuar//
                Console.Clear();
                Console.WriteLine("Opción no válida");
                Console.WriteLine("Escriba 1 o 2");
                JugadorInputValido = false;
                Console.ReadKey();
                break;
        }
    }
} while (!JugadorInputValido);

//Ejercicio 5

int[] flechas = new int[6];

for (int i = 0; i < flechas.Length; i++)
{
    Console.Write("Dano de la flecha " + (i + 1) + ": ");
    flechas[i] = int.Parse(Console.ReadLine());
}

int seguir = 1;

while (seguir == 1)
{
    Console.Write("Ingrese el dano de referencia: ");

    int referencia = int.Parse(Console.ReadLine());

    int totalFiltrado = 0;

    for (int i = 0; i < flechas.Length; i++)
    {
        if (flechas[i] > referencia)
        {
            totalFiltrado += flechas[i];
        }
    }

    Console.WriteLine("Total de dano filtrado: " + totalFiltrado);
    Console.Write("Desea probar otra referencia? (1 = Si / 2 = No): ");
    seguir = int.Parse(Console.ReadLine());
}
    }
}
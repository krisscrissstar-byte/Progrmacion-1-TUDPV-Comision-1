int[] dañoFlechas = new int[6];
int menu = 1;
int referencia = 0;
int acumulador = 0;
for (int i = 0; i < dañoFlechas.Length; i++)
{
    Console.WriteLine("Ingrese el daño");
    dañoFlechas[i] = int.Parse(Console.ReadLine());
}

while(menu == 1)
{
    Console.WriteLine("Ingrese daño de referencia");
    referencia = int.Parse(Console.ReadLine());

    menu = 0;
}

for (int i = 0; i < dañoFlechas.Length; i++)
{
    if(dañoFlechas[i] > referencia)
    {
        Console.WriteLine("La flehca " + (i+1) + " supera el valor de referencia");
        acumulador += dañoFlechas[i];
    }

}

Console.WriteLine("El daño total es de: " + acumulador);
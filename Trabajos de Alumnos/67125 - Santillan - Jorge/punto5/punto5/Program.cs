int[] danoFlechas = new int[6];
int salir = 1;
int referencia = 0;

for (int i = 0; i < danoFlechas.Length; i++)
{
    Console.WriteLine("Ingrese el daño de la flecha");
    danoFlechas[i] = int.Parse(Console.ReadLine());
}
while (salir == 1)
{
    Console.WriteLine("ingresar daño de referencia");
    referencia = int.Parse(Console.ReadLine());

    int acumulador = 0;

    for (int i = 0; i < danoFlechas.Length; i++)
    {
        if (danoFlechas[i] > referencia)
        {
            Console.WriteLine("Flecha " + (i + 1) + " supera el daño de referencia: ");
            acumulador += danoFlechas[i];
        }
    }
    Console.WriteLine("Total de daño filtrado: " + acumulador);

    Console.WriteLine("¿Quiere probar otra referencia? (1 para sí, 0 para no)");
    salir = int.Parse(Console.ReadLine());
}

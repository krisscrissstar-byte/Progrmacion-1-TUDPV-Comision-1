int [] gemas = { 10, 25, 50, 80, 120 };

Console.WriteLine("Ingrese las gemas disponibles");
int gemasUsuario = int.Parse(Console.ReadLine());


Console.WriteLine("1.Mostrar cartas de tienda");
Console.WriteLine("2.Mostrar carta mas cara");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
    for(int i = 0; i < gemas.Length; i++)
    {
        if(gemas[i] > gemasUsuario)
        {
            Console.Write("Carta " + (i+1) + ", Valor: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(gemas[i] + " GEMAS INSUFICIENTES");
            Console.ResetColor();       
        }
        else
        {
            Console.Write("Carta " + (i+1) + ", Valor: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(gemas[i]);
            Console.ResetColor();  
        }
    
    }
        break;

    case 2:
        
        var ordenadas = gemas.OrderByDescending(x => x);

        foreach (int i in ordenadas)
        {
            Console.WriteLine("Valor: " + i);
        }
    break;   
}


string [] gemas = {"Fuego", "Hielo", "Rayo", "Veneno"};
int [] cargas = new int[4];

for (int i = 0; i < cargas.Length; i++)
{
    Console.WriteLine("Ingrese las cargas");
    cargas [i] = int.Parse(Console.ReadLine());
}

    Console.WriteLine("ELIJA OPCION");
    Console.WriteLine("1: Recargar todas");
    Console.WriteLine("2: Buscar si hay alguna gema agotada");
    int choice = int.Parse(Console.ReadLine());


switch (choice)
{
    case 1:
        for (int i = 0; i < gemas.Length; i++)
        {
            cargas [i] += 5;
            Console.WriteLine("La gema " + gemas[i] + " se recargo y ahora tiene " + cargas[i] + " cargas");
        }
    break;

    case 2:
        for (int i = 0; i < gemas.Length; i++)
        {
            if(cargas[i] <= 0)
            {
                Console.WriteLine("La gema " + (i+1) + " esta agotada");
            }
        }
        break;
}
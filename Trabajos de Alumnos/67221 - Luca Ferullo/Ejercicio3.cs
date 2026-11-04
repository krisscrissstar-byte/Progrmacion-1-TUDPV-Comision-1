using Ssytem;

namespace Ejercicio3;

public class Program{
    public static void Main(string[] args){
        int[] slimes = {30 , 40 ,50 , 60};

        for (int i = 0; i < slimes.Length; i++){
            Console.WriteLine("Cantidad de vida de cada slime:");
            Console.WriteLine(slimes[i]);
            Console.WriteLine("Presiona cualquier tecla para ver las siguientes opciones:");
            Console.ReadKey();
        }

        Console.WriteLine("Elije el slime al que le vas a atacar:");
        int op = int.Parse(Console.ReadLine());

        switch (op){
            case 1:
            slimes[0]++;
            
            Console.WriteLine("Ingresa el daño que vas a infrigir:");
            slimes[0] = int.Parse(Console.ReadLine());

            while (slimes[0] > 0){
                Console.WriteLine("Sigue vivo, intentalo de nuevo:");
                slimes[0] = int.Parse(Console.ReadLine());
            }

            if (slimes[0] == 0){
                Console.WriteLine("Este slime esta muerto.");
                Console.ReadKey();
            }
            break;

            case 2:
            slimes[1]++;
            
            Console.WriteLine("Ingresa el daño que vas a infrigir:");
            slimes[1] = int.Parse(Console.ReadLine());

            while (slimes[1] > 0){
                Console.WriteLine("Sigue vivo, intentalo de nuevo:");
                slimes[1] = int.Parse(Console.ReadLine());
            }

            if (slimes[1] == 0){
                Console.WriteLine("Este slime esta muerto.");
                Console.ReadKey();
            }
            break;

            case 3:
            slimes[2]++;
            
            Console.WriteLine("Ingresa el daño que vas a infrigir:");
            slimes[2] = int.Parse(Console.ReadLine());

            while (slimes[2] > 0){
                Console.WriteLine("Sigue vivo, intentalo de nuevo:");
                slimes[2] = int.Parse(Console.ReadLine());
            }

            if (slimes[2] == 0){
                Console.WriteLine("Este slime esta muerto.");
                Console.ReadKey();
            }
            break;

            case 4:
            slimes[3]++;
            
            Console.WriteLine("Ingresa el daño que vas a infrigir:");
            slimes[3] = int.Parse(Console.ReadLine());

            while (slimes[3] > 0){
                Console.WriteLine("Sigue vivo, intentalo de nuevo:");
                slimes[3] = int.Parse(Console.ReadLine());
            }

            if (slimes[3] == 0){
                Console.WriteLine("Este slime esta muerto.");
                Console.ReadKey();
            }
            break;

            default:
            Console.WriteLine("No ingreso ningun slime en la que se encuentra.");
        }
    }
}
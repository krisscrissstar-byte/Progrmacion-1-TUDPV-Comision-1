float[] tiempos = new float[4];
float[] objetivos = new float [2];
bool menu = true;
for (int i = 0; i < tiempos.Length; i++)
{
    Console.WriteLine("Ingrese tiempo del corredor " + (i+1));
    tiempos[i] = float.Parse(Console.ReadLine());  

}

while (menu)
{
    Console.WriteLine("Definir tiempo obejtivo 1");
    objetivos[0] = float.Parse(Console.ReadLine());  

    Console.WriteLine("Definir tiempo obejtivo 2");
    objetivos[1] = float.Parse(Console.ReadLine());  

    menu = false;

}

for (int i = 0; i < tiempos.Length; i++)
{
    if(tiempos[i] <= objetivos[0])
    {
        Console.WriteLine("El juegador " + (i+1) + " Supero el primer objetivo");
        
    }
    if(tiempos[i] <= objetivos[1])
    {
        Console.WriteLine("El juegador " + (i+1) + " Supero el segundo objetivo");

    }
    else
    {
        Console.WriteLine("El juegador " + (i+1) + " No Supero ningun objetivo");
    }
}
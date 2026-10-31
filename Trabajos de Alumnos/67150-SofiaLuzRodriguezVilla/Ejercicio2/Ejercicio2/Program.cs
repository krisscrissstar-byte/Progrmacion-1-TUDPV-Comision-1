/*Ejercicio 2: Marcador Top 5 de Speedrun
Combina: Array + for + while + if/else*/

float[] tiempos = new float[5];
float[] tiempoObjetivo = new float[1];

for (int i = 0; i < tiempos.Length; i++)
{
   
      Console.WriteLine("Ingrese el tiempo del runner " + (i + 1));
      tiempos[i] = float.Parse(Console.ReadLine());

}

while (tiempoObjetivo[0] <= 0)
{
    Console.WriteLine("Definir tiempo objetivo");

    tiempoObjetivo[0] = float.Parse(Console.ReadLine());

}

for(int i = 0; i < tiempos.Length; i++)
{
    if (tiempos[i] <= tiempoObjetivo[0])
    {
        Console.WriteLine("El runner " + (i + 1) + " llegó al objetivo");
    }
    else
    {
        Console.WriteLine("El runner " + (i + 1) + " no llegó al objetivo");
    }
}

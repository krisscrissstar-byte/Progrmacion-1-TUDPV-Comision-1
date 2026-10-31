/*

Cargar con un for los tiempos de 5 corredores en un array de float. Con un bucle 
while, permitir al usuario ingresar diferentes tiempos objetivo para clasificar y evaluar con 
if/else cuántos corredores del vector superaron la prueba logrando un tiempo menor o igual a 
la marca exigida
 
*/


float[] tiempos = new float[5];
for (int i = 0; i < tiempos.Length; i++)
{
    Console.Write($"Tiempo que superó la prueba el corredor {i + 1} (en segundos): ");
    tiempos[i] = Convert.ToSingle(Console.ReadLine());
}
Console.Clear();

while (true)
{
    Console.Write(" ¿Cual es el tiempo objetivo para clasificar? o ingrese 'x' para salir: ");
    string input = Console.ReadLine();
    Console.Clear();

    if (input == "x")
    {
        break;
    }
    float tiempoObjetivo = float.Parse(input);
    int corredoresSuperados = 0;
    for (int i = 0; i < tiempos.Length; i++)
    {
        if (tiempos[i] <= tiempoObjetivo)
        {
            corredoresSuperados++;
        }
    }
    Console.WriteLine($"Cantidad de corredores que superaron la prueba en {tiempoObjetivo}: {corredoresSuperados}");
}
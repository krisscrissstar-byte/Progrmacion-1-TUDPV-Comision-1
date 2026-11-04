bool[] trampas = { false, true, false, false, true, false };
bool meta = false;
bool cayo = false;
while(!meta && !cayo)
{
    for (int i = 0; i < trampas.Length; i++)
    {
        if(trampas[i] == true)
        {
            Console.WriteLine("Cayo en la trampa");
            cayo = true;
            break;
        }
        
        else
        {
            Console.WriteLine("Baldosa a salvo!");
        }     
    }

        if (!cayo)
    {
        Console.WriteLine("Llegaste a la meta!");
        meta = true;
    }
}
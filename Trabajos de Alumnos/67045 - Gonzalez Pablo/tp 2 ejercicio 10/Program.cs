{
    int[] exp = new int[5];
    for (int i = 0; i < exp.Lengtg; i++)
    {
        Console.Write(exp de la mision " + (i + 1) + " : ");
        exp[i] = int.Parse(Console.ReadLine());
        if (exp[i] > 100)
        {
            exp[i] += (int)(exp[i] * 0.2);
            Console.WriteLine("Bono aplicado! Nuevo valor: " + exp[i]);
        }


    }
    int total = 0;
    Console.WriteLine("--- Tabla final de misiones ---");
    for (int i = 0; i < exp.Length; i++)
    {
        Console.WriteLine("Mision" + (i + 1) + " :" + exp[i] + "EXP");
        total + = exp[i];
    }
    Console.WriteLine(Experiencia total acumulada:" + total); ")
    }
}

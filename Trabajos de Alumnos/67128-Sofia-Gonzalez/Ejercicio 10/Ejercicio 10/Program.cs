using System;

class bonificacionEXP
{
    static void Main()
    {
        int[] misionesEXP = new int[5];

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Puntos de Experiencia de 5 misiones");
        Console.WriteLine("-----------------------------------");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese EXP ganada en la Misión " + (i + 1) + ": ");
            misionesEXP[i] = int.Parse(Console.ReadLine());

            if (misionesEXP[i] > 100)
            {
                int bono = (int)(misionesEXP[i] * 0.20);
                misionesEXP[i] = misionesEXP[i] + bono;
                Console.WriteLine("¡Bono del 20% aplicado a la Misión " + (i + 1) + "! Nueva EXP: " + misionesEXP[i]);
            }
        }

        int expTotal = 0;
        Console.WriteLine();
        Console.WriteLine("Tabla de Experiencia actualizada");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Misión " + (i + 1) + ": " + misionesEXP[i] + " EXP");
            expTotal = expTotal + misionesEXP[i];
        }

        Console.WriteLine("Experiencia total acumulada por el clan: " + expTotal + " EXP");
        Console.ReadKey();
    }
}
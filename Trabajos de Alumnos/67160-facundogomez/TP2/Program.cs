using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== TRABAJO PRÁCTICO N° 2 - PRE PARCIAL ===");

        // EJERCICIO 1
        Console.WriteLine("\n--- EJERCICIO 1: Inventario de Armas ---");
        string[] armas = { "Espada", "Hacha", "Arco", "Daga" };
        int[] durabilidad = new int[4];

        for (int i = 0; i < armas.Length; i++)
        {
            Console.Write($"Ingrese la durabilidad de {armas[i]}: ");
            durabilidad[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("1: Inspeccionar críticas | 2: Ver arsenal completo");
        Console.Write("Opción: ");
        int op1 = int.Parse(Console.ReadLine());

        switch (op1)
        {
            case 1:
                for (int i = 0; i < armas.Length; i++)
                {
                    if (durabilidad[i] <= 20)
                        Console.WriteLine($"⚠️ ALERTA: {armas[i]} está crítica ({durabilidad[i]} durabilidad).");
                }
                break;
            case 2:
                for (int i = 0; i < armas.Length; i++)
                    Console.WriteLine($"- {armas[i]}: {durabilidad[i]}");
                break;
        }

        // EJERCICIO 2
        Console.WriteLine("\n--- EJERCICIO 2: Speedrun Top 5 ---");
        float[] tiempos = new float[5];
        for (int i = 0; i < tiempos.Length; i++)
        {
            Console.Write($"Tiempo del corredor {i + 1} (segs): ");
            tiempos[i] = float.Parse(Console.ReadLine());
        }

        Console.Write("Ingrese tiempo objetivo para clasificar: ");
        float objetivo = float.Parse(Console.ReadLine());
        int superaron = 0;
        for (int i = 0; i < tiempos.Length; i++)
        {
            if (tiempos[i] <= objetivo) superaron++;
        }
        Console.WriteLine($"Corredores que superaron la prueba: {superaron}");

        // EJERCICIO 3
        Console.WriteLine("\n--- EJERCICIO 3: Horda de Slimes ---");
        int[] slimes = { 30, 40, 50, 60 };
        while (slimes[0] > 0 || slimes[1] > 0 || slimes[2] > 0 || slimes[3] > 0)
        {
            Console.Write("Ataque a un slime (0 al 3): ");
            int idx = int.Parse(Console.ReadLine());
            if (idx >= 0 && idx <= 3)
            {
                if (slimes[idx] <= 0)
                    Console.WriteLine("Ese slime ya fue derrotado.");
                else
                {
                    slimes[idx] -= 20;
                    if (slimes[idx] < 0) slimes[idx] = 0;
                    Console.WriteLine($"Slime {idx} atacado. HP restante: {slimes[idx]}");
                }
            }
        }
        Console.WriteLine("¡Todos los slimes derrotados!");

        // EJERCICIO 4
        Console.WriteLine("\n--- EJERCICIO 4: Tienda de Cartas ---");
        int[] costosGemas = { 10, 25, 50, 80, 120 };
        Console.Write("Ingrese sus gemas: ");
        int gemas = int.Parse(Console.ReadLine());
        Console.WriteLine("1: Mostrar cartas pagables | 2: Carta más cara");
        Console.Write("Opción: ");
        int op4 = int.Parse(Console.ReadLine());
        switch (op4)
        {
            case 1:
                for (int i = 0; i < costosGemas.Length; i++)
                {
                    if (gemas >= costosGemas[i])
                        Console.WriteLine($"- Carta {i + 1}: {costosGemas[i]} gemas");
                }
                break;
            case 2:
                int max = costosGemas[0];
                for (int i = 1; i < costosGemas.Length; i++)
                    if (costosGemas[i] > max) max = costosGemas[i];
                Console.WriteLine($"La carta más cara cuesta: {max} gemas");
                break;
        }

        // EJERCICIO 5
        Console.WriteLine("\n--- EJERCICIO 5: Daño por Ráfaga ---");
        int[] danoFlechas = new int[6];
        for (int i = 0; i < danoFlechas.Length; i++)
        {
            Console.Write($"Daño flecha {i + 1}: ");
            danoFlechas[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Ingrese daño de referencia a superar: ");
        int refDano = int.Parse(Console.ReadLine());
        int totalFiltrado = 0;
        for (int i = 0; i < danoFlechas.Length; i++)
        {
            if (danoFlechas[i] > refDano) totalFiltrado += danoFlechas[i];
        }
        Console.WriteLine($"Total de daño filtrado que superó la referencia: {totalFiltrado}");

        // EJERCICIO 6
        Console.WriteLine("\n--- EJERCICIO 6: Cargas Mágicas ---");
        string[] gemasMagicas = { "Fuego", "Hielo", "Rayo", "Veneno" };
        int[] cargas = new int[4];
        for (int i = 0; i < gemasMagicas.Length; i++)
        {
            Console.Write($"Cargas de {gemasMagicas[i]}: ");
            cargas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("1: Recargar todas (+5) | 2: Buscar agotadas");
        Console.Write("Opción: ");
        int op6 = int.Parse(Console.ReadLine());
        if (op6 == 1)
        {
            for (int i = 0; i < cargas.Length; i++)
            {
                cargas[i] += 5;
                Console.WriteLine($"- {gemasMagicas[i]}: {cargas[i]} cargas");
            }
        }
        else if (op6 == 2)
        {
            for (int i = 0; i < cargas.Length; i++)
                if (cargas[i] == 0) Console.WriteLine($"⚠️ Gema agotada: {gemasMagicas[i]}");
        }

        // EJERCICIO 7
        Console.WriteLine("\n--- EJERCICIO 7: Pasillo de Mazmorra ---");
        bool[] trampas = { false, true, false, false, true, false };
        int pos = 0;
        bool vivo = true;
        while (pos < 5 && vivo)
        {
            pos++;
            if (trampas[pos])
            {
                Console.WriteLine($"💥 ¡Trampa en baldosa {pos}! Perdiste.");
                vivo = false;
            }
        }
        if (vivo) Console.WriteLine("🎉 ¡Llegaste a la meta sin activar trampas!");

        // EJERCICIO 8
        Console.WriteLine("\n--- EJERCICIO 8: Fases del Boss ---");
        int[] danoFases = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Daño recibido en Fase {i + 1}: ");
            danoFases[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("1: Promedio de daño | 2: Fase más destructiva");
        Console.Write("Opción: ");
        int op8 = int.Parse(Console.ReadLine());
        if (op8 == 1)
            Console.WriteLine($"Promedio de daño: {(danoFases[0] + danoFases[1] + danoFases[2]) / 3.0:F2}");
        else if (op8 == 2)
        {
            int maxDano = Math.Max(danoFases[0], Math.Max(danoFases[1], danoFases[2]));
            Console.WriteLine($"Mayor daño registrado: {maxDano}");
        }

        // EJERCICIO 9
        Console.WriteLine("\n--- EJERCICIO 9: Sistema de Munición ---");
        int[] municion = { 30, 15, 8 };
        int op9 = -1;
        while (op9 != 0)
        {
            Console.Write("\nElija arma (1: Rifle, 2: Pistola, 3: Escopeta, 0: Salir): ");
            op9 = int.Parse(Console.ReadLine());
            if (op9 >= 1 && op9 <= 3)
            {
                if (municion[op9 - 1] > 0)
                {
                    municion[op9 - 1]--;
                    Console.WriteLine("💥 ¡PUM! Disparo realizado.");
                }
                else
                    Console.WriteLine("⚠️ Sin munición.");
            }
        }

        // EJERCICIO 10
        Console.WriteLine("\n--- EJERCICIO 10: Bonificación de EXP ---");
        double[] exp = new double[5];
        double totalExp = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"EXP Misión {i + 1}: ");
            exp[i] = double.Parse(Console.ReadLine());
            if (exp[i] > 100) exp[i] += exp[i] * 0.20;
            totalExp += exp[i];
        }
        Console.WriteLine($"Experiencia total acumulada: {totalExp} EXP");

        Console.WriteLine("\n=== TRABAJO PRÁCTICO COMPLETADO ===");
        Console.ReadKey();
    }
}
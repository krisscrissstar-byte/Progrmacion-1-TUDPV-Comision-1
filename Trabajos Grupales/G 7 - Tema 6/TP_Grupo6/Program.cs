using System;
using System.Collections.Generic;

namespace TP_Grupo6
{
    class Program
    {
        static void Main()
        {
            var herramientas = new Herramienta[] { new PicoHierro(), new PicoDiamante() };
            var bloques = new List<Bloque>
            {
                new Bloque("Piedra", 50),
                new Bloque("Diamante", 100),
                new Bloque("Obsidiana", 250)
            };

            while (true)
            {
                Console.WriteLine("\n--- Menú Principal ---");
                Console.WriteLine("1) Interactuar con herramientas");
                Console.WriteLine("2) Auditar estado de bloques");
                Console.WriteLine("0) Salir");
                Console.Write("Seleccioná una opción: ");
                var opt = Console.ReadLine();

                if (opt == "0") break;
                if (opt == "1")
                {
                    Console.WriteLine("Seleccioná herramienta:");
                    for (int i = 0; i < herramientas.Length; i++)
                        Console.WriteLine($"{i}) {herramientas[i]}");
                    Console.Write("Índice: ");
                    if (!int.TryParse(Console.ReadLine(), out int idx) || idx < 0 || idx >= herramientas.Length)
                    {
                        Console.WriteLine("Índice inválido.");
                        continue;
                    }

                    Console.WriteLine("Seleccioná bloque a minar:");
                    for (int i = 0; i < bloques.Count; i++)
                        Console.WriteLine($"{i}) {bloques[i].Tipo} (Dureza: {bloques[i].Dureza})");
                    Console.Write("Índice: ");
                    if (!int.TryParse(Console.ReadLine(), out int bIdx) || bIdx < 0 || bIdx >= bloques.Count)
                    {
                        Console.WriteLine("Índice inválido.");
                        continue;
                    }

                    var herramienta = herramientas[idx];
                    var bloque = bloques[bIdx];
                    herramienta.PicarBloque(bloque);
                    if (bloque.EstaRoto) Console.WriteLine($"El bloque {bloque.Tipo} se destruyó.");
                }
                else if (opt == "2")
                {
                    Console.WriteLine("Estado de bloques:");
                    foreach (var b in bloques)
                        Console.WriteLine($"- {b.Tipo}: Dureza restante = {b.Dureza} (Roto: {b.EstaRoto})");
                }
                else
                {
                    Console.WriteLine("Opción no reconocida.");
                }
            }

            Console.WriteLine("Saliendo...");
        }
    }
}

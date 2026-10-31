using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_2_Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Ejercicio 1");
            Console.WriteLine("2) Ejercicio 2");
            Console.WriteLine("3) Ejercicio 3");
            Console.WriteLine("3) Ejercicio 4");
            Console.WriteLine("3) Ejercicio 5");
            Console.WriteLine("3) Ejercicio 6");
            Console.WriteLine("3) Ejercicio 7");
            Console.WriteLine("3) Ejercicio 8");
            Console.WriteLine("3) Ejercicio 9");
            Console.WriteLine("3) Ejercicio 10");
            int opcionEjercico = int.Parse(Console.ReadLine());

            switch (opcionEjercico)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Ejercicio6();
                    break;
                case 7:
                    Ejercicio7();
                    break;
                case 8:
                    Ejercicio8();
                    break;
                case 9:
                    Ejercicio9();
                    break;
                case 10:
                    Ejercicio10();
                    break;
            }
        }
        static void Ejercicio1()
        {
            Console.Clear();
            string[] armas = { "espada", "hacha", "arco", "daga" };
            int[] durabilidad = new int[4];
            for (int i = 0; i < armas.Length; i++)
            {
                Console.WriteLine("ingrese la durabilidad del arma " + armas[i]);
                durabilidad[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=========seleccione que desea==========");
            Console.WriteLine("1) inpeccionar armas criticas");
            Console.WriteLine("2) ver aresenal completo");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=========buscando armas criticas============");
                    Thread.Sleep(1000);
                    Console.WriteLine("estos son las armas con durabilidad critica");

                    for (int i = 0; i < armas.Length; i++)
                    {
                        if (durabilidad[i] <= 30)
                        {
                            Console.WriteLine(" el arma " + armas[i] + " esta en estado critico");
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine("==========Mostrando arsenal completo============");
                    Console.WriteLine("1- " + armas[0] + " durabilidad:" + durabilidad[0]);
                    Console.WriteLine("2- " + armas[1] + " durabilidad:" + durabilidad[1]);
                    Console.WriteLine("3- " + armas[2] + " durabilidad:" + durabilidad[2]);
                    Console.WriteLine("4- " + armas[3] + " durabilidad:" + durabilidad[3]);


                    break;
            }
        }
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("--------------------Ejercicio 2----------------------");
            float[] tiempoCorredores = new float[5];
            for (int i = 0; i < tiempoCorredores.Length; i++)
            {
                Console.WriteLine("escribe el tiempo de cada corredor " + (i + 1) + ":");
                tiempoCorredores[i] = float.Parse(Console.ReadLine());
            }
            string repetir = "si";
            while (repetir == "si")
            {
                Console.WriteLine("ingrese el tiempo del objetivo");
                float tiempoObjetivo = float.Parse(Console.ReadLine());
                int superaron = 0;
                for (int i = 0; i < tiempoCorredores.Length; i++)
                {
                    if (tiempoCorredores[i] <= tiempoObjetivo)
                    {
                        superaron++;
                    }
                }
                Console.WriteLine("Cantidad de jugadores que superaron el objetivo: " + superaron);
                Console.WriteLine("desea hacer otro objetvio? si/no");
                repetir = Console.ReadLine();

            }
        }
        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("-------------EJERCICIO 3--------------------");

            int[] slime = { 30, 40, 50, 60 };
            Console.WriteLine("==== APARECIERON 4 SLIMES ========");
            Console.WriteLine("LA BATALLA A EMPEZADO");
            while (slime[0] > 0 || slime[1] > 0 || slime[2] > 0 || slime[3] > 0)
            {
                Console.WriteLine("eliga a que slime atacar (0 al 3)");
                int ataque = int.Parse(Console.ReadLine());
                switch (ataque)
                {
                    case 0:
                        if (slime[0] > 0)
                        {
                            if (slime[0] < 20)
                            {
                                slime[0] = 0;
                                Console.WriteLine("atacaste al slime 0, ahora tiene: 0 HP, esta muerto");
                            }
                            else
                            {
                                slime[0] = slime[0] - 20;
                                Console.WriteLine("atacaste al slime 0, ahora tiene: " + slime[0] + "HP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("el slime esta muerto");
                        }
                        break;
                    case 1:
                        if (slime[1] > 0)
                        {
                            if (slime[1] < 20)
                            {
                                slime[1] = 0;
                                Console.WriteLine("atacaste al slime 1, ahora tiene: 0 HP, esta muerto");
                            }
                            else
                            {
                                slime[1] = slime[1] - 20;
                                Console.WriteLine("atacaste al slime 1, ahora tiene: " + slime[1] + "HP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("el slime esta muerto");
                        }
                        break;
                    case 2:
                        if (slime[2] > 0)
                        {
                            if (slime[2] < 20)
                            {
                                slime[2] = 0;
                                Console.WriteLine("atacaste al slime 2, ahora tiene: 0 HP, esta muerto");
                            }
                            else
                            {
                                slime[2] = slime[2] - 20;
                                Console.WriteLine("atacaste al slime 2, ahora tiene: " + slime[2] + "HP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("el slime esta muerto");
                        }
                        break;
                    case 3:
                        if (slime[3] > 0)
                        {
                            if (slime[3] < 20)
                            {
                                slime[3] = 0;
                                Console.WriteLine("atacaste al slime 3, ahora tiene: 0 HP, esta muerto");
                            }
                            else
                            {
                                slime[3] = slime[3] - 20;
                                Console.WriteLine("atacaste al slime 3, ahora tiene: " + slime[3] + "HP");
                            }
                        }
                        else
                        {
                            Console.WriteLine("el slime esta muerto");
                        }
                        break;
                }

            }

        }
        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("--------------EJERCICIO 4--------------------");
            int[] cartas = { 10, 25, 50, 80, 120 };
            Console.WriteLine("Vendedor: Bienvenido a la tienda del señor kaner");
            Thread.Sleep(500);
            Console.WriteLine("Jugador: Hola, quisiera comprar algunas cartas");
            Thread.Sleep(500);
            Console.WriteLine("vendedor: claro, aqui tiene 5 cartas que nos acaban de llegar");
            Thread.Sleep(500);
            Console.WriteLine("escribe la cantidad de gemas que tienes");
            int gemas = int.Parse(Console.ReadLine());
            Console.WriteLine("Tienes " + gemas + " gemas");
            Thread.Sleep(500);
            Console.WriteLine("=====ELIGE QUE QUIERES PREGUNTAR=====");
            Console.WriteLine("1- Mostrar cartas que puede pagar");
            Console.WriteLine("2- preguntar por la carta más cara del catálogo");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("jugador: me puedes mostar las cartas que puedo comprar con " + gemas + " gemas?");
                    Thread.Sleep(500);
                    for (int i = 0; i < cartas.Length; i++)
                    {
                        if (cartas[i] <= gemas)
                        {
                            Console.WriteLine("vendedor: Puedes comprar la carta de " + cartas[i]);
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine("jugador: Cual es la carta mas cara de las 5?");
                    Console.WriteLine("vendedor: Claro, la carta mas cara es la de " + cartas[4] + " gemas");
                    break;
            }
        }
        static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("-------------Ejercicio 5-------------------");
            int[] flechas = new int[6];
            Console.WriteLine("Se dispararon 6 flechas");
            Thread.Sleep(500);
            for (int i = 0; i < flechas.Length; i++)
            {
                Console.WriteLine("Ingrese el dano de La flecha " + (i + 1) + ":");
                flechas[i] = int.Parse(Console.ReadLine());
            }
            string bucle = "si";
            while (bucle == "si")
            {
                Console.WriteLine("Ingrese la cantidad de dano de objetivo");
                int danoObjetivo = int.Parse(Console.ReadLine());
                int cumplieron = 0;
                for (int i = 0; i < flechas.Length; i++)
                {
                    if (flechas[i] >= danoObjetivo)
                    {
                        cumplieron++;
                    }
                }
                Console.WriteLine("las flechas que superaron el dano del objetivo fueron: " + cumplieron);
                Thread.Sleep(1000);
                Console.WriteLine("desea escribir otro objetivo? si/no");
                bucle = Console.ReadLine();
            }

        }
        static void Ejercicio6()
        {
            Console.Clear();
            Console.WriteLine("-------------EJERCICIO 6--------------------");
            string[] gemas = { "Fuego", "Hielo", "Rayo", "Veneno" };
            int[] cargas = new int[4];
            for (int i = 0; i < gemas.Length; i++)
            {

                Console.WriteLine("ingrese la cantidad de cargas de cada tipo de gemas");
                Console.WriteLine("tipo " + gemas[i] + ":");
                cargas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("tienes " + cargas[i] + " gemas de tipo " + gemas[i]);
            }
            Console.Clear();
            Console.WriteLine("Que quieres hacer?");
            Console.WriteLine("1- recargar 5 a cada tipo de gemas");
            Console.WriteLine("2- ver si hay gemas agotadas");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        cargas[i] = 5 + cargas[i];
                        Console.WriteLine("se sumara +5 a todoas tus gemas");
                        Console.WriteLine("tipo " + gemas[i] + ": " + cargas[i]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < gemas.Length; i++)
                    {
                        if (cargas[i] <= 0)
                        {
                            Console.WriteLine("las gemas tipo " + gemas[i] + " estan agotadas");
                        }
                    }
                    break;
            }
        }
        static void Ejercicio7()
        {
            Console.Clear();
            Console.WriteLine("-------------EJERCICIO 7--------------------");
            bool[] trampas = { false, true, false, false, true, false };
            int posicion = 0;
            bool sigueVivo = true;
            Console.WriteLine("entraste a un pasillo con trampas");
            Console.WriteLine("comienzas en la casilla 0");
            while (posicion < 5 && sigueVivo)
            {
                Console.WriteLine("estas en la casilla " + posicion);
                Console.WriteLine("ingresa 1 si quieres vanazar una casilla y 2 si quieres avanzar 2");
                int eleccion = int.Parse(Console.ReadLine());
                posicion += eleccion;
                if (posicion >= 5)
                {
                    Console.WriteLine("llegaste a la meta ¡ganasteee!");
                }
                if (trampas[posicion])
                {
                    Console.WriteLine("caiste en una trampa en la casilla " + posicion + " ¡PERDISTE!");
                    sigueVivo = false;
                }
                else
                {
                    Console.WriteLine("Es una cailla segura. sigues vivo");
                }
            }
        }

            static void Ejercicio8()
            {
                Console.Clear();
                Console.WriteLine("-------------EJERCICIO 8--------------------");
                int[] danoFase = new int[3];

                for (int i = 0; i < danoFase.Length; i++)
                {
                    Console.WriteLine("ingrese el dano recibido en la fase " + (i + 1));
                    danoFase[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("El dano recibido en la fase " + (i + 1) + " es de " + danoFase[i]);
                }
                Console.WriteLine("elige una de las opciones");
                Console.WriteLine("1-Calcular promedio de daño entre las 3 fases");
                Console.WriteLine("2-cual fue la fase más destructiva");
                int opicon = int.Parse(Console.ReadLine());
                switch (opicon)
                {
                    case 1:
                        int suma = danoFase[0] + danoFase[1] + danoFase[2];
                        float promedio = suma / 3;
                        Console.WriteLine("el promedio de dano entre las 3 fases es de " + promedio);
                        break;
                    case 2:
                        int mayorDano;
                        if (danoFase[0] > danoFase[1])
                        {
                            mayorDano = 0;
                        }
                        else
                        {
                            mayorDano = 1;
                        }
                        if (danoFase[2] > danoFase[mayorDano])
                        {
                            mayorDano = 2;
                        }
                        Console.WriteLine("La fase con mayor deno fue la fase " + (mayorDano + 1) + " con " + danoFase[mayorDano] + " de dano");
                        break;
                }

            }
        
        
            static void Ejercicio9()
            {
                Console.Clear();
                Console.WriteLine("-------------EJERCICIO 9--------------------");
                int[] muncion = { 30, 15, 8 };
                while (muncion[0] > 0 || muncion[1] > 0 || muncion[2] > 0)
                {
                    Console.WriteLine("elige que arma usar");
                    Console.WriteLine("1- rifle");
                    Console.WriteLine("2- pistola");
                    Console.WriteLine("3- escopeta");
                    Console.WriteLine("0- ver cargador de las armas");

                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            if (muncion[0] > 0)
                            {
                                if (muncion[0] < 20)
                                {
                                    muncion[0] = 0;
                                    Console.WriteLine("Disparaste lo que quedaba de cargador el arma se quedo con municion en 0");
                                }
                                else
                                {
                                    muncion[0] = muncion[0] - 20;
                                    Console.WriteLine("disparaste 20 balas, municion restante de " + muncion[0] + " balas");
                                }
                            }
                            else
                            {
                                Console.WriteLine("no puedes disparar, municion faltante");
                            }
                            break;
                        case 2:
                            if (muncion[1] > 0)
                            {
                                if (muncion[1] < 10)
                                {
                                    muncion[1] = 0;
                                    Console.WriteLine("Disparaste lo que quedaba de cargador el arma se quedo con municion en 0");
                                }
                                else
                                {
                                    muncion[1] = muncion[1] - 10;
                                    Console.WriteLine("disparaste 10 balas, municion restante de " + muncion[1] + " balas");
                                }
                            }
                            else
                            {
                                Console.WriteLine("no puedes disparar, municion faltante");
                            }
                            break;
                        case 3:
                            if (muncion[2] > 0)
                            {
                                if (muncion[2] < 5)
                                {
                                    muncion[2] = 0;
                                    Console.WriteLine("Disparaste lo que quedaba de cargador el arma se quedo con municion en 0");
                                }
                                else
                                {
                                    muncion[2] = muncion[2] - 5;
                                    Console.WriteLine("disparaste 5 balas, municion restante de " + muncion[2] + " balas");
                                }
                            }
                            else
                            {
                                Console.WriteLine("no puedes disparar, municion faltante");
                            }
                            break;
                        case 0:
                            Console.WriteLine("las balas restantes del rifle: " + muncion[0] + " balas");
                            Console.WriteLine("las balas restantes del pistola: " + muncion[1] + " balas");
                            Console.WriteLine("las balas restantes del escopeta: " + muncion[2] + " balas");
                            break;
                    }
                }
            }
            static void Ejercicio10()
            {
                Console.Clear();
                Console.WriteLine("-------------EJERCICIO 10--------------------");
                int[] expMision = new int[5];
                int total = 0;
                for (int i = 0; i < expMision.Length; i++)
                {
                    Console.WriteLine("Cuanta EXP acumulo el aventurero " + (i + 1) + "?");
                    int exp = int.Parse(Console.ReadLine());
                    expMision[i] = exp;
                    if (expMision[i] >= 100)
                    {
                        expMision[i] = expMision[i] + (int)(expMision[i] * 0.20);
                        Console.WriteLine("el aventurero " + (i + 1) + " recibio una bonificacion del 20%. Ahora tiene " + expMision[i] + " de exp");
                    }
                }
                Console.WriteLine("Tabla final de exp ");
                for (int i = 0; i < expMision.Length; i++)
                {
                    total = total + expMision[i];
                    Console.WriteLine("Mision " + (i + 1) + ": " + expMision[i] + " EXP");
                }

                Console.WriteLine("Experiencia total acumulada: " + total);
            }
        }
    }



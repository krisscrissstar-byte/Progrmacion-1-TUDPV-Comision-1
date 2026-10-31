public class Hoguera
    {
        public string Ubicacion { get; set; }

        public Hoguera(string ubicacion)
        {
            Ubicacion = ubicacion;
        }

        public void Descansar(GuerreroHueco guerrero, int saludMax, int staminaMax)
        {
            guerrero.RestablecerAtributos(saludMax, staminaMax);
            Console.WriteLine($"\n {guerrero.Nombre} ha descansado en la hoguera de '{Ubicacion}'. Salud y Stamina al 100%. ¡Los enemigos han reaparecido!\n");
        }
    }
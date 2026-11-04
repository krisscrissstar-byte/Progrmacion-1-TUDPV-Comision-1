namespace TP_Grupo6
{
    public class Bloque
    {
        public string Tipo { get; private set; }
        private int dureza;
        public int Dureza
        {
            get => dureza;
            private set => dureza = value < 0 ? 0 : value;
        }

        public bool EstaRoto => Dureza <= 0;

        public Bloque(string tipo, int dureza)
        {
            Tipo = tipo;
            Dureza = dureza;
        }

        public void Romper(int cantidad)
        {
            if (cantidad <= 0) return;
            Dureza -= cantidad;
            if (Dureza < 0) Dureza = 0;
        }
    }
}

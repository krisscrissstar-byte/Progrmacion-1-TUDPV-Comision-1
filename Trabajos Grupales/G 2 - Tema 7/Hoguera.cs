using System;

namespace DarkSouls.Modelo
{
    /// <summary>Checkpoint: restablece por completo a quien descansa.</summary>
    public class Hoguera
    {
        public string Ubicacion { get; }

        public Hoguera(string ubicacion)
        {
            Ubicacion = ubicacion ?? throw new ArgumentNullException(nameof(ubicacion));
        }

        public void Descansar(GuerreroHueco guerrero)
        {
            if (guerrero == null) throw new ArgumentNullException(nameof(guerrero));
            guerrero.Restablecer();
        }
    }
}

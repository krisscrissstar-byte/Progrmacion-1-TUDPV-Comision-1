namespace DarkSouls.Modelo
{
    /// <summary>Tanque: esquive pesado y costoso.</summary>
    public class CaballeroNegro : GuerreroHueco
    {
        public override int CostoEsquivar => 40;

        public CaballeroNegro(string nombre, int saludMax, int staminaMax)
            : base(nombre, saludMax, staminaMax) { }
    }
}

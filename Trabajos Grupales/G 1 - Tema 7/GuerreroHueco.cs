using System;

namespace DarkSouls.Modelo
{
    /// <summary>
    /// Modelo logico puro de un combatiente. No depende de Console ni de UnityEngine.
    /// El controlador (Program o un MonoBehaviour) decide como mostrar los resultados.
    /// </summary>
    public abstract class GuerreroHueco
    {
        public const int CostoAtaqueBase = 20;

        private int salud;
        private int stamina;

        public string Nombre { get; }
        public int SaludMax { get; }
        public int StaminaMax { get; }

        /// <summary>Siempre se mantiene entre 0 y SaludMax.</summary>
        public int Salud
        {
            get => salud;
            protected set => salud = Math.Clamp(value, 0, SaludMax);
        }

        /// <summary>Siempre se mantiene entre 0 y StaminaMax.</summary>
        public int Stamina
        {
            get => stamina;
            protected set => stamina = Math.Clamp(value, 0, StaminaMax);
        }

        public bool EstaVivo => Salud > 0;

        /// <summary>Mientras sea true, RecibirDanio no hace nada (ventana del rodaje).</summary>
        public bool Invulnerable { get; set; }

        /// <summary>Costo de stamina del esquive. Cada subclase define el suyo.</summary>
        public abstract int CostoEsquivar { get; }

        /// <summary>Costo de stamina del ataque. Las subclases pueden sobrescribirlo.</summary>
        public virtual int CostoAtaque => CostoAtaqueBase;

        protected GuerreroHueco(string nombre, int saludMax, int staminaMax)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede estar vacio.", nameof(nombre));
            if (saludMax <= 0) throw new ArgumentOutOfRangeException(nameof(saludMax));
            if (staminaMax <= 0) throw new ArgumentOutOfRangeException(nameof(staminaMax));

            Nombre = nombre;
            SaludMax = saludMax;
            StaminaMax = staminaMax;
            Salud = saludMax;
            Stamina = staminaMax;
        }

        /// <summary>True si hay stamina suficiente para una accion de ese costo (no consume nada).</summary>
        public bool TieneStamina(int costo) => costo >= 0 && Stamina >= costo;

        /// <summary>Descuenta stamina solo si alcanza. Devuelve si la accion pudo realizarse.</summary>
        public bool ConsumirStamina(int costo)
        {
            if (!TieneStamina(costo)) return false;
            Stamina -= costo;
            return true;
        }

        /// <summary>Devuelve true si el ataque se ejecuto (hubo stamina).</summary>
        public virtual bool Atacar() => ConsumirStamina(CostoAtaque);

        /// <summary>Devuelve true si el esquive se ejecuto (hubo stamina).</summary>
        public virtual bool Esquivar() => ConsumirStamina(CostoEsquivar);

        /// <summary>
        /// Aplica danio. Devuelve el danio realmente recibido (0 si es invulnerable,
        /// esta muerto o el valor es invalido).
        /// </summary>
        public int RecibirDanio(int danio)
        {
            if (danio <= 0 || Invulnerable || !EstaVivo) return 0;
            int antes = Salud;
            Salud -= danio;
            return antes - Salud;
        }

        /// <summary>Recupera stamina (para regeneracion o consumibles), sin pasarse del maximo.</summary>
        public void RecuperarStamina(int cantidad)
        {
            if (cantidad > 0) Stamina += cantidad;
        }

        /// <summary>Restablece salud y stamina a sus maximos reales (los usa la Hoguera).</summary>
        public void Restablecer()
        {
            Salud = SaludMax;
            Stamina = StaminaMax;
            Invulnerable = false;
        }
    }
}

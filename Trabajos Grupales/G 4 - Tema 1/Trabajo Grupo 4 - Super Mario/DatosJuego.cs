using System;

/// <summary>
/// Clase de C# pura (NO hereda de MonoBehaviour).
/// Guarda los datos del juego, como las monedas.
/// </summary>
public class DatosJuego
{
    public int Monedas { get; private set; }

    // Evento opcional para avisar a la UI cuando cambian las monedas
    public event Action<int> OnMonedasCambiadas;

    public void SumarMonedas(int cantidad)
    {
        if (cantidad <= 0) return;

        Monedas += cantidad;
        OnMonedasCambiadas?.Invoke(Monedas);
    }
}

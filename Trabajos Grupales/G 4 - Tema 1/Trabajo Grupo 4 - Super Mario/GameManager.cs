using UnityEngine;

/// <summary>
/// Puente entre Unity y la clase pura DatosJuego.
/// Poner en un GameObject vacío llamado "GameManager".
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instancia { get; private set; }

    // Instancia de la clase de C# pura
    public DatosJuego Datos { get; private set; }

    private void Awake()
    {
        if (Instancia != null && Instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        Instancia = this;
        Datos = new DatosJuego();
        Datos.OnMonedasCambiadas += total => Debug.Log("Monedas: " + total);
    }
}

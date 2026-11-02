using UnityEngine;
using System;
public class Enemigo : MonoBehaviour
{
    [SerializeField] private string nombreEnemigo = "Octorok";
    [SerializeField] private int vidaInicial = 30;

    private int vida;

    public string Nombre => nombreEnemigo;
    public int Vida => vida;
    public bool EstaMuerto => vida <= 0;

    private void Awake()
    {
        if (string.IsNullOrWhiteSpace(nombreEnemigo)) throw new ArgumentException("El enemigo necesita nombre.");
        if (vidaInicial <= 0) throw new ArgumentOutOfRangeException(nameof(vidaInicial), "La vida debe ser mayor que cero.");

        vida = vidaInicial;
    }

    public void RecibirDanio(int cantidad)
    {
        if (cantidad < 0) throw new ArgumentOutOfRangeException(nameof(cantidad), "El daño no puede ser negativo.");

        vida = Mathf.Max(0, vida - cantidad);
        if (EstaMuerto) Destroy(gameObject);
    }
}

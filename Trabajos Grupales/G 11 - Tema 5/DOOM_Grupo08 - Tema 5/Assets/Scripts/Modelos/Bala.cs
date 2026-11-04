using System;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;
    public int daño = 20;
    public float tiempoVida = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = transform.right * velocidad;

        Destroy(gameObject, tiempoVida);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemigoController enemigo =
            collision.GetComponentInParent<EnemigoController>();

        if (enemigo != null)
        {
            enemigo.RecibirDanio(daño);
            Destroy(gameObject);
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

// Ejercicio 11: Zona trigger que reduce la gravedad de los objetos que entran.
public class GravityZone : MonoBehaviour
{
    [SerializeField] private float customGravityScale = 0.2f;

    // Guardamos la gravedad original de CADA objeto que entra,
    // así funciona aunque haya varios cuerpos con distintas escalas.
    private Dictionary<Rigidbody2D, float> originalGravity = new Dictionary<Rigidbody2D, float>();

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.attachedRigidbody;
        if (rb == null || originalGravity.ContainsKey(rb)) return;

        originalGravity[rb] = rb.gravityScale;   // almacenar valor original
        rb.gravityScale = customGravityScale;    // aplicar baja gravedad
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Rigidbody2D rb = other.attachedRigidbody;
        if (rb == null) return;

        if (originalGravity.TryGetValue(rb, out float original))
        {
            rb.gravityScale = original;          // restaurar
            originalGravity.Remove(rb);
        }
    }
}

/*
 * Para que la caída se sienta más "flotante" al entrar (y no solo que acelere menos),
 * se puede también frenar la velocidad de entrada en OnTriggerEnter2D:
 *   rb.linearVelocity *= 0.5f;
 */

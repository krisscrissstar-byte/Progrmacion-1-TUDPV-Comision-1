using UnityEngine;

// Ejercicio 8: Sensor de suelo usando un collider Trigger en un objeto hijo (GroundCheck).
public class GroundSensor : MonoBehaviour
{
    // Propiedad pública de solo lectura: otros scripts pueden consultarla.
    public bool IsGrounded => contactCount > 0;

    // Solo para verlo en el Inspector mientras se prueba.
    [SerializeField] private bool isGrounded;

    // Contamos los contactos: si el pie toca dos plataformas a la vez y sale de una,
    // sigue estando en el suelo.
    private int contactCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsValidGround(other)) return;

        contactCount++;
        isGrounded = IsGrounded;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (!IsValidGround(other)) return;

        contactCount = Mathf.Max(0, contactCount - 1);
        isGrounded = IsGrounded;
    }

    private bool IsValidGround(Collider2D other)
    {
        // Ignoramos otros triggers (monedas, zonas, etc.)
        if (other.isTrigger) return false;

        // Ignoramos el propio collider del Player (el padre).
        if (other.transform == transform.parent) return false;

        return true;
    }
}

/*
 * Uso desde otro script del Player (por ejemplo, para saltar):
 *
 *   [SerializeField] private GroundSensor groundSensor;
 *   ...
 *   if (Input.GetButtonDown("Jump") && groundSensor.IsGrounded) { ... }
 */

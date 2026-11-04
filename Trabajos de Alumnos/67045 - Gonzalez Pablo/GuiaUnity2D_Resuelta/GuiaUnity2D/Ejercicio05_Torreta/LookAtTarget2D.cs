using UnityEngine;

// Ejercicio 5: La torreta rota para apuntar siempre al objetivo.
public class LookAtTarget2D : MonoBehaviour
{
    [SerializeField] private Transform target;

    // Corrección según hacia dónde "mira" el sprite originalmente:
    //   0   -> el sprite apunta a la derecha (eje X+)
    //  -90  -> el sprite apunta hacia arriba (eje Y+), típico de un triángulo
    [SerializeField] private float angleOffset = 0f;

    void Update()
    {
        if (target == null) return;

        // Vector dirección = destino - origen.
        Vector2 direction = target.position - transform.position;

        // Atan2 devuelve el ángulo en radianes (ojo: primero Y, después X).
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // En 2D se rota solo sobre el eje Z.
        transform.rotation = Quaternion.Euler(0f, 0f, angle + angleOffset);
    }
}

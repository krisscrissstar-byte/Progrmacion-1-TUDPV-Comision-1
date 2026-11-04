using UnityEngine;

// Ejercicio 13: Zona que aplica daño periódico mientras el jugador permanece dentro.
public class DamageZone : MonoBehaviour
{
    [SerializeField] private float damageInterval = 1f;  // segundos entre cada daño
    [SerializeField] private int damageAmount = 10;

    private float timer = 0f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        // OnTriggerStay2D se ejecuta en cada paso de física mientras haya contacto.
        // Usamos Time.deltaTime (dentro de callbacks de física equivale a fixedDeltaTime).
        timer += Time.deltaTime;

        if (timer >= damageInterval)
        {
            Debug.Log($"{other.name} recibió {damageAmount} de daño por lava.");

            // Restamos el intervalo (en vez de poner 0) para no acumular error de tiempo.
            timer -= damageInterval;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Al salir, se reinicia el contador para la próxima vez que entre.
        if (other.CompareTag("Player"))
        {
            timer = 0f;
        }
    }
}

/*
 * Importante: Unity "duerme" los Rigidbody2D quietos y, si el Player se queda
 * inmóvil, OnTriggerStay2D puede dejar de llamarse. Para evitarlo:
 * en el Rigidbody2D del Player poner Sleeping Mode = Never Sleep.
 */

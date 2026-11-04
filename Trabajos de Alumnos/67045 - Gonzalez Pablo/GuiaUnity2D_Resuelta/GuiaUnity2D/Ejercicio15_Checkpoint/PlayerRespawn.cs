using UnityEngine;

// Ejercicio 15: Checkpoints y reaparición al caer en una zona de muerte.
public class PlayerRespawn : MonoBehaviour
{
    private Vector2 lastCheckpointPosition;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Punto de reaparición inicial: la posición de arranque del jugador.
        lastCheckpointPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            lastCheckpointPosition = other.transform.position;
            Debug.Log("Checkpoint guardado en " + lastCheckpointPosition);
        }
        else if (other.CompareTag("DeathZone"))
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        transform.position = lastCheckpointPosition;

        // Anulamos la velocidad de caída para que no reaparezca "cayendo rápido".
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero; // (Unity 2022 o anterior: rb.velocity)
        }
    }
}

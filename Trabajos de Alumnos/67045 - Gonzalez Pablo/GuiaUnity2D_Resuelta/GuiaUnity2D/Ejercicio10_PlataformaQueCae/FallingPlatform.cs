using UnityEngine;

// Ejercicio 10: Plataforma que cae un tiempo después de que el jugador la pisa.
[RequireComponent(typeof(Rigidbody2D))]
public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float fallDelay = 1f;
    [SerializeField] private float destroyAfter = 3f; // limpieza: se destruye una vez que cayó

    private Rigidbody2D rb;
    private bool triggered = false; // evita llamar Invoke varias veces

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic; // estado inicial: quieta en el aire
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!triggered && collision.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Invoke(nameof(Fall), fallDelay);
        }
    }

    private void Fall()
    {
        // Al pasar a Dynamic, la gravedad empieza a afectar a la plataforma.
        rb.bodyType = RigidbodyType2D.Dynamic;

        Destroy(gameObject, destroyAfter);
    }
}

using UnityEngine;

// Script AUXILIAR (no lo pide la guía) para mover al Player con físicas
// en los ejercicios de plataformas (7 al 20). Mueve en horizontal con A/D o flechas.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float horizontal;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // La entrada se lee en Update...
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // ...y la física se aplica en FixedUpdate.
        // Se conserva la velocidad vertical para no romper la gravedad ni el salto.
        // (Unity 6: linearVelocity. En Unity 2022 o anterior: rb.velocity)
        rb.linearVelocity = new Vector2(horizontal * moveSpeed, rb.linearVelocity.y);
    }
}

using UnityEngine;

// Ejercicio 7: Salto con física, solo permitido cuando se toca el suelo.
[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private bool isGrounded; // visible en el Inspector para depurar

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // "Jump" está mapeado por defecto a la barra espaciadora.
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Impulse aplica toda la fuerza de golpe (ideal para saltos).
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

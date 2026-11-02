using UnityEngine;

// Ejercicio 9: Trampolín que impulsa hacia arriba a cualquier cuerpo físico que lo toque.
public class Trampoline : MonoBehaviour
{
    [SerializeField] private float bounceForce = 15f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificamos que el objeto que choca tenga Rigidbody2D.
        Rigidbody2D otherRb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (otherRb != null)
        {
            // Reiniciamos la velocidad vertical para que el rebote sea siempre igual,
            // sin importar con qué velocidad venía cayendo.
            // (Unity 6: linearVelocity. En Unity 2022 o anterior: velocity)
            otherRb.linearVelocity = new Vector2(otherRb.linearVelocity.x, 0f);

            // Impulso instantáneo hacia arriba.
            otherRb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}

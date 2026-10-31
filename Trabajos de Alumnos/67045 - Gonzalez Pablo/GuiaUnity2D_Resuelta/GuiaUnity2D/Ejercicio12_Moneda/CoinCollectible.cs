using UnityEngine;

// Ejercicio 12: Moneda que gira y desaparece al ser tocada por el jugador.
public class CoinCollectible : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 180f; // grados por segundo

    void Update()
    {
        // Girar sobre el eje Y da el efecto de "moneda que da vueltas".
        // Para un giro plano tipo rueda, usar Vector3.forward (eje Z).
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

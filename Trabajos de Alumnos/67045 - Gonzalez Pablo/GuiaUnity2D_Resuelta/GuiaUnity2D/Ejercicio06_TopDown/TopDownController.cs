using UnityEngine;

// Ejercicio 6: Movimiento top-down en 8 direcciones con velocidad uniforme.
public class TopDownController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    void Update()
    {
        // GetAxisRaw devuelve -1, 0 o 1 (sin suavizado).
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // .normalized hace que la diagonal (1,1) tenga largo 1 y no 1.41.
        Vector2 movement = new Vector2(h, v).normalized;

        transform.position += (Vector3)(movement * speed * Time.deltaTime);
    }
}

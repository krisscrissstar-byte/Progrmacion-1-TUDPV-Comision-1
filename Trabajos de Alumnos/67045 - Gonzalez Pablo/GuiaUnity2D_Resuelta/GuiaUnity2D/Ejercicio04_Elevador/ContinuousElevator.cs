using UnityEngine;

// Ejercicio 4: Plataforma que sube a velocidad constante y vuelve al inicio.
public class ContinuousElevator : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float maxHeight = 4f; // altura máxima (coordenada Y del mundo)

    private Vector3 startPosition;

    void Start()
    {
        // Guardamos la posición de origen para poder reiniciar.
        startPosition = transform.position;
    }

    void Update()
    {
        // Dirección (Vector2.up) * velocidad * tiempo del frame.
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // Al superar la altura máxima, vuelve al punto de origen.
        if (transform.position.y > maxHeight)
        {
            transform.position = startPosition;
        }
    }
}

/*
 * Nota: maxHeight se interpreta como coordenada Y absoluta.
 * Si se prefiere que sea "cuánto sube desde el piso", cambiar la condición por:
 *   if (transform.position.y > startPosition.y + maxHeight)
 */

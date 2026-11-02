using UnityEngine;

// Ejercicio 2: Patrulla automática de ida y vuelta entre dos puntos.
public class PatrolMovement : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float minDistance = 0.05f; // distancia mínima para considerar "llegó"

    private Transform currentTarget;

    void Start()
    {
        // Empieza yendo hacia el punto B.
        currentTarget = pointB;
    }

    void Update()
    {
        // Mueve el objeto hacia el destino actual sin pasarse.
        Vector2 newPosition = Vector2.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime);

        transform.position = newPosition;

        // Al alcanzar el destino, alterna el objetivo.
        if (Vector2.Distance(transform.position, currentTarget.position) < minDistance)
        {
            currentTarget = (currentTarget == pointA) ? pointB : pointA;
        }
    }
}

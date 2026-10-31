using UnityEngine;

// Auxiliar opcional del Ejercicio 5: mueve el Target en círculo para probar la torreta.
// (Alternativa: arrastrar el Target con el mouse en la vista Scene durante Play,
//  o ponerle el CursorFollower del Ejercicio 1.)
public class TargetMover : MonoBehaviour
{
    [SerializeField] private float radius = 3f;
    [SerializeField] private float angularSpeed = 1.5f;

    private Vector3 center;

    void Start()
    {
        center = transform.position;
    }

    void Update()
    {
        float t = Time.time * angularSpeed;
        transform.position = center + new Vector3(Mathf.Cos(t), Mathf.Sin(t), 0f) * radius;
    }
}

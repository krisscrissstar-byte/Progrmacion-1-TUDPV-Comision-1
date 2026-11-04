using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform objetivo;
    public float suavizado = 5f;
    public Vector3 desfase = new Vector3(0f, 1f, -10f);

    void LateUpdate()
    {
        if (objetivo == null) return;

        Vector3 destino = objetivo.position + desfase;
        transform.position = Vector3.Lerp(transform.position, destino, suavizado * Time.deltaTime);
    }
}
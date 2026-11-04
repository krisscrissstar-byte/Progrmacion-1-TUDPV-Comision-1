using UnityEngine;

public class RecuperarSalud : MonoBehaviour
{
    public int cantidadSalud = 25;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController jugador =
                collision.GetComponentInParent<PlayerController>();

            if (jugador != null)
            {
                jugador.RecuperarSalud(cantidadSalud);
                Destroy(gameObject);
            }
        }
    }
}
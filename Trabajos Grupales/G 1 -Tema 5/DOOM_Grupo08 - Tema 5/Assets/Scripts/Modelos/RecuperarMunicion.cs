using UnityEngine;

public class RecuperarMunicion : MonoBehaviour
{
    public int cantidadMunicion = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController jugador =
                collision.GetComponentInParent<PlayerController>();

            if (jugador != null)
            {
                jugador.RecuperarMunicion(cantidadMunicion);
                Destroy(gameObject);
            }
        }
    }
}
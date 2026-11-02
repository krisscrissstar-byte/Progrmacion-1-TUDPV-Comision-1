using UnityEngine;

public class zombi : MonoBehaviour
{
    public int dañoAAtacar = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SupervivienteControlador controladorJugador = collision.GetComponent<SupervivienteControlador>();

            if (controladorJugador != null)
            {
                controladorJugador.RecibirDano(dañoAAtacar);
            }
        }
    }
}

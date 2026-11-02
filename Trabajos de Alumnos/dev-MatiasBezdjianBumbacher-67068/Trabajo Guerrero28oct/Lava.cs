using UnityEngine;

public class Lava : MonoBehaviour
{
    public int danio = 20;

    // Se ejecuta cuando algo entra en la lava (Is Trigger activado)
    private void OnTriggerStay2D(Collider2D otro)
    {
        // Buscamos si lo que entró es el jugador
        GuerreroController jugador = otro.GetComponent<GuerreroController>();

        if (jugador != null)
        {
            jugador.guerrero.RecibirDanio(danio);
            Debug.Log("Vida: " + jugador.guerrero.VidaActual + " | Escudo: " + jugador.guerrero.Escudo);

            if (jugador.guerrero.EstaVivo == false)
            {
                Debug.Log(jugador.guerrero.Nombre + " murió");
            }
        }
    }
}
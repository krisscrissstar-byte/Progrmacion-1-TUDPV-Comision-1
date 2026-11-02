using UnityEngine;
using trabajo_clase;
using UnityEngine.Video;
public class Pocion : MonoBehaviour
{
    public int curacion = 25;

    // Se ejecuta cuando algo entra en la poción
    private void OnTriggerEnter2D(Collider2D otro)
    {
        // Buscamos si lo que entró es el jugador
        GuerreroController jugador = otro.GetComponent<GuerreroController>();

        if (jugador != null)
        {
            jugador.guerrero.Curar(curacion);
            Debug.Log("Vida: " + jugador.guerrero.VidaActual + " | Escudo: " + jugador.guerrero.Escudo);

            Destroy(gameObject);  // la poción desaparece
        }
    }
}

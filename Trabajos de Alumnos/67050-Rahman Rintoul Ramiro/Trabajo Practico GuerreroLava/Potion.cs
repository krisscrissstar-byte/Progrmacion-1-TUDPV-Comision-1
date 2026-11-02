
using UnityEngine;

public class Potion : MonoBehaviour
{
    [SerializeField] private int curacion = 25;


    private void OnTriggerEnter(Collider other)
    {

        GuerreroController jugador =
            other.GetComponentInParent<GuerreroController>();

        if (jugador == null)
        {
            Debug.LogWarning("No se encontró GuerreroController");
            return;
        }

        jugador.Curar(25);
        Destroy(gameObject);
    }

}

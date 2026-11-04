using UnityEngine;

public class PocionDeCuracion : MonoBehaviour
{
    [SerializeField] private float cantidadCuracion = 50f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        GuerreroLogico guerrero = other.GetComponent<GuerreroLogico>();
        if (guerrero != null && guerrero.Guerrero.EstaVivo)
        {
            if (guerrero.Guerrero.VidaActual < guerrero.Guerrero.VidaMax)
            {
                guerrero.Guerrero.Curar((int)cantidadCuracion);
                Destroy(gameObject);
            }
        }
    }
}

using UnityEngine;

public class PocionSalud : MonoBehaviour{
    [SerializeField] private float cantidadCuracion = 30f;

    private void OnTriggerEnter2D(Collider2D other){
        GuerreroController guerrero = other.GetComponent<GuerreroController>();
        if (guerrero != null && guerrero.Modelo.EstaVivo){
            if (guerrero.Modelo.SaludActual < guerrero.Modelo.SaludMaxima){
                guerrero.Modelo.Curar(cantidadCuracion);
                Destroy(gameObject);
            }
        }
    }
}
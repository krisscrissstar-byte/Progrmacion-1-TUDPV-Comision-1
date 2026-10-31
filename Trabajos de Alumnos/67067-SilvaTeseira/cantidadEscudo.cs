using UnityEngine;

public class PocionEscudo : MonoBehaviour{
    [SerializeField] private float cantidadEscudo = 25f;

    private void OnTriggerEnter2D(Collider2D other){
        GuerreroController guerrero = other.GetComponent<GuerreroController>();
        if (guerrero != null && guerrero.Modelo.EstaVivo){
            if (guerrero.Modelo.EscudoActual < guerrero.Modelo.EscudoMaximo){
                guerrero.Modelo.RecargarEscudo(cantidadEscudo);
                Destroy(gameObject);
            }
        }
    }
}
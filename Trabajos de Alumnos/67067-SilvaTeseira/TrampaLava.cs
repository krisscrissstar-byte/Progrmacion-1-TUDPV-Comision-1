using UnityEngine;

public class TrampaLava : MonoBehaviour{
    [SerializeField] private float danoPorSegundo = 25f;

    private void OnTriggerStay2D(Collider2D other){
        GuerreroController guerrero = other.GetComponent<GuerreroController>();
        if (guerrero != null){
            guerrero.Modelo.RecibirDano(danoPorSegundo * Time.deltaTime);
        }
    }
}
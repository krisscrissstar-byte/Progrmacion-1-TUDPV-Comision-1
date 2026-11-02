using UnityEngine;

public class TrampaDeLava : MonoBehaviour
{
    [SerializeField] private float danioPorSegundo = 15f;
    private void OnTriggerStay2D(Collider2D other)
    {
        GuerreroLogico guerrero = other.GetComponent<GuerreroLogico>();
        if(guerrero != null)
        {
            guerrero.Guerrero.RecibirDanio((int)(danioPorSegundo * Time.deltaTime));
        }
    }
}

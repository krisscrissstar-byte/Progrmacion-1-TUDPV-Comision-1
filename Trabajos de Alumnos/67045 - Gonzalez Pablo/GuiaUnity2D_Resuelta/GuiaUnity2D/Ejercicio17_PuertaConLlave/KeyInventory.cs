using UnityEngine;

// Ejercicio 17 (parte 1): Inventario del jugador. Va en el Player.
public class KeyInventory : MonoBehaviour
{
    [SerializeField] private bool hasKey = false;

    // Propiedad para que la puerta pueda consultar el estado.
    public bool HasKey => hasKey;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(other.gameObject);
            Debug.Log("¡Llave obtenida!");
        }
    }
}

using UnityEngine;

// Ejercicio 17 (parte 2): Puerta que se abre si el jugador que la toca tiene la llave.
public class DoorController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        KeyInventory inventory = collision.gameObject.GetComponent<KeyInventory>();

        if (inventory != null && inventory.HasKey)
        {
            Debug.Log("Puerta abierta.");

            // Opción A: desactivar solo el collider (la puerta se sigue viendo pero se atraviesa).
            // GetComponent<Collider2D>().enabled = false;

            // Opción B: desactivar el GameObject completo (la puerta desaparece).
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("La puerta está cerrada. Necesitás una llave.");
        }
    }
}

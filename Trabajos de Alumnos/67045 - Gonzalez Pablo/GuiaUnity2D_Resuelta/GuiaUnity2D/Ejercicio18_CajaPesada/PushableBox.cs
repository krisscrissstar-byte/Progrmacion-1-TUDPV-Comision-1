using UnityEngine;

// Ejercicio 18: Caja pesada empujable con físicas.
[RequireComponent(typeof(Rigidbody2D))]
public class PushableBox : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // Congelar la rotación Z para que la caja no vuelque al empujarla.
        // (Equivale a tildar Constraints > Freeze Rotation Z en el Inspector.)
        rb.freezeRotation = true;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        // Recorremos los puntos de contacto para saber si el empuje es lateral.
        foreach (ContactPoint2D contact in collision.contacts)
        {
            // La normal apunta desde el Player hacia la caja.
            // Si es casi horizontal, el jugador está empujando por un costado
            // (y no parado encima de la caja).
            if (Mathf.Abs(contact.normal.x) > 0.5f)
            {
                Debug.Log("El jugador está empujando la caja.");
                break;
            }
        }
    }
}

/*
 * El empuje en sí lo resuelve el motor de físicas: la caja tiene Mass = 10 y el
 * Player Mass = 1, por eso se mueve lento y con inercia.
 * El Player necesita moverse con físicas (Rigidbody2D), por ejemplo con
 * Comun/PlayerMovement2D.cs. Si el Player se mueve modificando transform.position,
 * atraviesa la caja en lugar de empujarla.
 */

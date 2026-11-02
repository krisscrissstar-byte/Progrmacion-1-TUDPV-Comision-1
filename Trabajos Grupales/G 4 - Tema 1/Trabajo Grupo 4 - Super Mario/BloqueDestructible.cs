
using UnityEngine;

public class BloqueDestructible : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        foreach (ContactPoint2D contacto in collision.contacts)
        {
            // Detectar golpe desde abajo
            if (contacto.normal.y > 0.5f)
            {
                Destroy(gameObject);
                break;
            }
        }
    }
}

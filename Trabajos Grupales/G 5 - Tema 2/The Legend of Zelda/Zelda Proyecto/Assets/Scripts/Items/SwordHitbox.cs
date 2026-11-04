using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField] private PlayerController player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // REQUISITO: Al entrar en contacto con enemigos, invocar la función de resta de vida
        if (collision.CompareTag("Enemigo"))
        {
            if (collision.TryGetComponent<Enemigo>(out var enemigo))
            {
                // Invoca el método RecibirDanio expuesto en tu clase Enemigo
                enemigo.RecibirDanio(player.DanioEspada);
            }
        }
    }
}

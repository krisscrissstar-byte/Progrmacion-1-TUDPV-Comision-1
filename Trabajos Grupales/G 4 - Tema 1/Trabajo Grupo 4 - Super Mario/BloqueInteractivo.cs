using System.Collections;
using UnityEngine;

/// <summary>
/// Bloque estático que da monedas al ser golpeado desde abajo.
/// Requiere un BoxCollider2D (sin Is Trigger) y NO lleva Rigidbody2D
/// (o uno en modo Static).
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class BloqueInteractivo : MonoBehaviour
{
    [Header("Monedas")]
    [SerializeField] private int monedasPorGolpe = 1;
    [SerializeField] private int usosMaximos = 1;      // cuántas veces da monedas

    [Header("Visual")]
    [SerializeField] private Sprite spriteVacio;        // sprite cuando ya no tiene monedas
    [SerializeField] private float alturaRebote = 0.2f;
    [SerializeField] private float duracionRebote = 0.1f;

    private int usosRestantes;
    private bool animando;
    private SpriteRenderer sr;
    private Vector3 posicionInicial;

    private void Awake()
    {
        usosRestantes = usosMaximos;
        sr = GetComponent<SpriteRenderer>();
        posicionInicial = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Player")) return;

        foreach (ContactPoint2D contacto in collision.contacts)
        {
            // En el callback del BLOQUE, la normal apunta desde el jugador hacia el bloque.
            // Si el jugador viene de abajo, apunta hacia arriba (y > 0.5).
            // Visto desde el jugador es la misma normal invertida: hacia abajo (y < -0.5).
            if (contacto.normal.y > 0.5f)
            {
                Golpear();
                break;
            }
        }
    }

    /// <summary>Método que se ejecuta al golpear el bloque desde abajo.</summary>
    public void Golpear()
    {
        if (usosRestantes <= 0 || animando) return;

        usosRestantes--;
        GameManager.Instancia.Datos.SumarMonedas(monedasPorGolpe);

        StartCoroutine(Rebote());

        if (usosRestantes <= 0 && sr != null && spriteVacio != null)
            sr.sprite = spriteVacio;
    }

    private IEnumerator Rebote()
    {
        animando = true;
        Vector3 arriba = posicionInicial + Vector3.up * alturaRebote;

        for (float t = 0; t < duracionRebote; t += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(posicionInicial, arriba, t / duracionRebote);
            yield return null;
        }
        for (float t = 0; t < duracionRebote; t += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(arriba, posicionInicial, t / duracionRebote);
            yield return null;
        }

        transform.position = posicionInicial;
        animando = false;
    }
}

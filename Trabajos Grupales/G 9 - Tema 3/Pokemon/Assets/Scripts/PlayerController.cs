using Tema3Pokemon;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    [SerializeField] private float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 movimientoInput;

    [Header("Sistema de Encuentros")]
    private bool enPastoAlto = false;
    private float contadorPasos = 0f;
    [SerializeField] private float distanciaParaEncuentro = 2f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true; // Regla de cátedra: Bloquear rotación en Z
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) moveX = 1f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) moveX = -1f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) moveY = 1f;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) moveY = -1f;

        movimientoInput = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimientoInput * velocidad;

        if (enPastoAlto && movimientoInput.sqrMagnitude > 0.01f)
        {
            contadorPasos += rb.linearVelocity.magnitude * Time.fixedDeltaTime;

            if (contadorPasos >= distanciaParaEncuentro)
            {
                contadorPasos = 0f;
                VerificarEncuentroSalvaje();
            }
        }
    }

    private void VerificarEncuentroSalvaje()
    {
        bool combateIniciado = SistemaCombatePuro.CalcularProbabilidadEncuentro();

        if (combateIniciado)
        {
            // Debug.Log funciona perfecto aquí porque estamos en un MonoBehaviour de Unity
            Debug.Log("¡Un Pokémon salvaje ha aparecido en el pasto alto!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PastoAlto"))
        {
            enPastoAlto = true;
            Debug.Log("Entrando a zona de pasto alto...");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PastoAlto"))
        {
            enPastoAlto = false;
            Debug.Log("Saliendo de zona de pasto alto.");
        }
    }
}
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GuerreroController : MonoBehaviour
{
    [Header("Atributos del guerrero")]
    [SerializeField] private string nombre = "Guerrero";
    [SerializeField] private int vidaMax = 100;
    [SerializeField] private int escudoInicial = 50;

    [Header("Movimiento")]
    [SerializeField] private float velocidad = 5f;

    [Header("Efectos de las zonas (triggers)")]
    [SerializeField] private int danioPorZona = 20;
    [SerializeField] private int curacionPorZona = 15;
    [SerializeField] private string Danio = "Danio";
    [SerializeField] private string Curacion = "Curacion";

    private GuerreroLogico guerrero;   // clase pura con la lógica
    private Rigidbody2D rb;
    private Vector2 direccion;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
        rb.freezeRotation = true;

        guerrero = new GuerreroLogico(nombre, vidaMax, escudoInicial);
    }

    private void Update()
    {
        // Lectura de teclado (WASD / flechas)
        if (!guerrero.EstaVivo)
        {
            direccion = Vector2.zero;
            return;
        }

        direccion.x = Input.GetAxisRaw("Horizontal");
        direccion.y = Input.GetAxisRaw("Vertical");
        direccion = direccion.normalized;
    }

    private void FixedUpdate()
    {
        // Movimiento físico
        rb.MovePosition(rb.position + direccion * velocidad * Time.fixedDeltaTime);
    }

    // Detección de daño / curación mediante triggers
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!guerrero.EstaVivo) return;

        if (other.CompareTag(Danio))
        {
            guerrero.RecibirDanio(danioPorZona);
            Debug.Log($"{guerrero.Nombre} recibió {danioPorZona} de daño. " + $"Escudo: {guerrero.Escudo} | Vida: {guerrero.VidaActual}/{guerrero.VidaMax}");

            if (!guerrero.EstaVivo)
            {
                Morir();
            }
        }
        else if (other.CompareTag(Curacion))
        {
            guerrero.Curar(curacionPorZona);
            Debug.Log($"{guerrero.Nombre} se curó {curacionPorZona}. " + $"Vida: {guerrero.VidaActual}/{guerrero.VidaMax}");
        }
    }

    private void Morir()
    {
        Debug.Log($"{guerrero.Nombre} ha muerto.");
        direccion = Vector2.zero;
        rb.linearVelocity = Vector2.zero; 
    }
}
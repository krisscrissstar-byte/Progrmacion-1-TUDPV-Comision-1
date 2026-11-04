using UnityEngine;

public class GuerreroController2D : MonoBehaviour
{
    [Header("Configuración del Personaje")]
    [SerializeField] private string nombreGuerrero = "Tukson";
    [SerializeField] private int vidaMaxima = 100;
    [SerializeField] private int escudoInicial = 50;

    [Header("Movimiento")]
    [SerializeField] private float velocidadMovimiento = 5f;
    [SerializeField] private float fuerzaSalto = 7f;
    [SerializeField] private Transform comprobadorSuelo;
    [SerializeField] private LayerMask capaSuelo;
    [SerializeField] private float radioSuelo = 0.2f;

    // Instancia de nuestra clase de C# puro (Modelo POO)
    private GuerreroLogico guerrero;
    private Rigidbody2D rb;
    private float movimientoHorizontal = 0f;
    private bool enSuelo = false;

    private void Awake()
    {
        // Inicializamos el objeto del modelo POO puro con los parámetros de la cátedra
        guerrero = new GuerreroLogico(nombreGuerrero, vidaMaxima, escudoInicial);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 1. Lectura de teclado para movimiento horizontal (A / D o Flechas)
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadMovimiento;

        // 2. Comprobar si está tocando el suelo para permitir el salto
        if (comprobadorSuelo != null)
        {
            enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, radioSuelo, capaSuelo);
        }

        // 3. Lectura de teclado para el salto (Barra Espaciadora)
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }
    }

    private void FixedUpdate()
    {
        // Aplicar la física de movimiento horizontal manteniendo la velocidad vertical de la gravedad/salto
        rb.linearVelocity = new Vector2(movimientoHorizontal, rb.linearVelocity.y);
    }

    // Detección de colisiones mediante triggers (Lava y Pociones)
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Validar si el guerrero sigue vivo antes de procesar interacciones
        if (!guerrero.EstaVivo) return;

        // Si colisiona con una trampa de lava
        if (other.CompareTag("Lava"))
        {
            int dañoLava = 25; // Podrías leerlo de un script en la lava si prefieres
            guerrero.RecibirDanio(dañoLava);

            Debug.Log($"[{guerrero.Nombre}] ¡Daño por lava! Vida: {guerrero.VidaActual} | Escudo: {guerrero.Escudo}");

            VerificarEstadoVital();
        }
        // Si colisiona con una poción de vida (ejemplo: otorga 30 de curación)
        else if (other.CompareTag("PocionVida"))
        {
            int curacion = 30;
            guerrero.Curar(curacion);

            Debug.Log($"[{guerrero.Nombre}] ¡Poción recogida! Vida actual: {guerrero.VidaActual}");

            Destroy(other.gameObject); // Eliminar la poción del mapa
        }
    }

    private void VerificarEstadoVital()
    {
        if (!guerrero.EstaVivo)
        {
            Debug.Log($"[{guerrero.Nombre}] Ha muerto. Fin de la partida.");
            // Aquí puedes desactivar el script o el movimiento para detener al personaje
            enabled = false;
        }
    }

    // Dibujar el gizmo en la escena para configurar el sensor de suelo cómodamente
    private void OnDrawGizmosSelected()
    {
        if (comprobadorSuelo != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(comprobadorSuelo.position, radioSuelo);
        }
    }
}
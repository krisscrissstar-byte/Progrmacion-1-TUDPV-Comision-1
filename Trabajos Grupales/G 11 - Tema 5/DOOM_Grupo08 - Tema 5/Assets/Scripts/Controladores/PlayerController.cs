using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 3f;

    private Rigidbody2D rb;
    private Vector2 movimiento;
    private DoomSimple.Jugador jugadorLogico;

    public Transform puntoDisparo;
    public Vector2 DireccionApuntado { get; private set; }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jugadorLogico = new DoomSimple.Jugador(1, 1);

        if (rb == null)
        {
            Debug.LogError("Falta Rigidbody2D en el jugador.");
            enabled = false;
        }
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movimiento = new Vector2(x, y).normalized;

        if (Camera.main != null)
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );

            Vector2 direccion = mouse - transform.position;

            if (direccion.sqrMagnitude > 0.01f)
                DireccionApuntado = direccion.normalized;
        }

        if (puntoDisparo != null)
        {
            float angulo = Mathf.Atan2(
                DireccionApuntado.y,
                DireccionApuntado.x
            ) * Mathf.Rad2Deg;

            puntoDisparo.rotation = Quaternion.Euler(0, 0, angulo);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento * velocidad;
    }

    public void RecuperarSalud(int cantidad)
    {
        jugadorLogico.Curar(cantidad);

        Debug.Log("Salud actual: " + jugadorLogico.Vida);
    }

    public void RecuperarMunicion(int cantidad)
    {
        jugadorLogico.Municion += cantidad;

        Debug.Log("Municion actual: " + jugadorLogico.Municion);
    }

    public bool IntentarUsarMunicion(int cantidad)
    {
        if (cantidad <= 0 || jugadorLogico.Municion < cantidad)
        {
            Debug.Log("No hay municion suficiente.");
            return false;
        }

        jugadorLogico.Municion -= cantidad;

        Debug.Log("Municion restante: " + jugadorLogico.Municion);

        return true;
    }
}
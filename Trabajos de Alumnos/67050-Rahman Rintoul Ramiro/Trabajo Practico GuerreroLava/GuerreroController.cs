
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInput))]
public class GuerreroController : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float fuerzaSalto = 5f;

    [Header("Camara")]
    [SerializeField] private Transform camara;
    [SerializeField] private float sensibilidad = 0.1f;

    [Header("Estadisticas")]
    [SerializeField] private int saludInicial = 100;
    [SerializeField] private int escudoInicial = 50;

    private Rigidbody rb;
    private Salud salud;
    private Escudo escudo;

    private Vector2 movimiento;
    private Vector2 mirada;

    private float rotacionVertical;
    private bool enSuelo;
    private bool saltoPendiente;
    private bool mouseLibre;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        salud = new Salud(saludInicial);
        escudo = new Escudo(escudoInicial);

        rb.freezeRotation = true;

        BloquearMouse();
    }


    public void OnMove(InputValue value)
    {
        movimiento = value.Get<Vector2>();
    }

    public void OnLook(InputValue value)
    {
        if (!mouseLibre)
            mirada = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
            saltoPendiente = true;
    }


    public void Curar(int cantidad)
    {
        if (!salud.EstaVivo || cantidad <= 0)
            return;

        salud.Curar(cantidad);

        Debug.Log($"Salud restaurada: {salud.ValorActual}");
    }


    private void MuerteInstantanea()
    {
        if (!salud.EstaVivo) return;

        salud.Vaciar();
        escudo.Vaciar();

        Morir();
    }

    private void Update()
    {
        if (!salud.EstaVivo) return;

        bool altPresionado =
            Keyboard.current != null &&
            Keyboard.current.leftAltKey.isPressed;

        if (altPresionado && !mouseLibre)
            LiberarMouse();
        else if (!altPresionado && mouseLibre)
            BloquearMouse();

        if (mouseLibre)
        {
            mirada = Vector2.zero;
            return;
        }

        transform.Rotate(
            Vector3.up * mirada.x * sensibilidad
        );

        rotacionVertical -= mirada.y * sensibilidad;
        rotacionVertical = Mathf.Clamp(
            rotacionVertical, -89f, 89f
        );

        if (camara != null)
        {
            camara.localRotation = Quaternion.Euler(
                rotacionVertical, 0f, 0f
            );
        }

        mirada = Vector2.zero;
    }


    private void FixedUpdate()
    {
        if (!salud.EstaVivo) return;

        Vector3 direccion =
            transform.right * movimiento.x +
            transform.forward * movimiento.y;

        direccion.Normalize();

        Vector3 velocidadActual = rb.linearVelocity;
        Vector3 velocidadHorizontal = direccion * velocidad;

        rb.linearVelocity = new Vector3(
            velocidadHorizontal.x,
            velocidadActual.y,
            velocidadHorizontal.z
        );

        if (saltoPendiente && enSuelo)
        {
            rb.AddForce(
                Vector3.up * fuerzaSalto,
                ForceMode.Impulse
            );

            enSuelo = false;
        }

        saltoPendiente = false;
    }


    private void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contacto in collision.contacts)
        {
            if (Vector3.Dot(
                contacto.normal, Vector3.up
            ) > 0.5f)
            {
                enSuelo = true;
                break;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        enSuelo = false;
    }

    private void LiberarMouse()
    {
        mouseLibre = true;
        mirada = Vector2.zero;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void BloquearMouse()
    {
        mouseLibre = false;
        mirada = Vector2.zero;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LavaMortal"))
        {
            MuerteInstantanea();
            return;
        }
        if (!salud.EstaVivo) return;

        else if (other.CompareTag("Pocion"))
        {
            salud.Curar(25);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Escudo"))
        {
            escudo.Recargar(25);
            Destroy(other.gameObject);
        }

        Debug.Log(
            $"Salud: {salud.ValorActual} | " +
            $"Escudo: {escudo.ValorActual}"
        );

        if (!salud.EstaVivo)
            Morir();
    }

    private void Morir()
    {
        Debug.Log("GAME OVER");

        movimiento = Vector2.zero;
        rb.linearVelocity = Vector3.zero;

        LiberarMouse();
        enabled = false;
    }


    public void RecibirDanio(int cantidad)
    {
        if (!salud.EstaVivo || cantidad <= 0)
            return;

        int restante = escudo.AbsorberDanio(cantidad);
        salud.RecibirDanio(restante);

        Debug.Log(
            $"Vida: {salud.ValorActual} | Escudo: {escudo.ValorActual}"
        );

        if (!salud.EstaVivo)
            Morir();
    }



    private void OnGUI()
    {
        if (salud == null || escudo == null) return;

        GUIStyle estilo = new GUIStyle(GUI.skin.label);
        estilo.fontSize = 24;
        estilo.normal.textColor = Color.white;

        GUI.Label(new Rect(20, 20, 250, 40),
            $"Salud: {salud.ValorActual}", estilo);

        GUI.Label(new Rect(20, 55, 250, 40),
            $"Escudo: {escudo.ValorActual}", estilo);

        if (!salud.EstaVivo)
        {
            GUIStyle gameOver = new GUIStyle(GUI.skin.label);
            gameOver.fontSize = 60;
            gameOver.fontStyle = FontStyle.Bold;
            gameOver.alignment = TextAnchor.MiddleCenter;
            gameOver.normal.textColor = Color.red;

            GUI.Label(
                new Rect(0, Screen.height / 2f - 60,
                    Screen.width, 120),
                "GAME OVER",
                gameOver
            );
        }
    }


}

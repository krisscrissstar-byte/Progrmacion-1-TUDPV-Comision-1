using UnityEngine;
using trabajo_clase; 

public class GuerreroController : MonoBehaviour
{
    // Datos que se pueden cambiar desde el Inspector de Unity
    public string nombre = "Guerrero";
    public int vidaMax = 100;
    public int escudoInicial = 50;
    public float velocidad = 5f;

    
    public GuerreroLogico guerrero;

    private Rigidbody2D rb;
    private float movX;   

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
        guerrero = new GuerreroLogico(nombre, vidaMax, escudoInicial);
    }

    void Update()
    {
        
        if (guerrero.EstaVivo)
        {
            movX = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            movX = 0;
        }
    }

    void FixedUpdate()
    {
        // Mover con física
        rb.linearVelocity = new Vector2(movX * velocidad, rb.linearVelocity.y);
    }
}
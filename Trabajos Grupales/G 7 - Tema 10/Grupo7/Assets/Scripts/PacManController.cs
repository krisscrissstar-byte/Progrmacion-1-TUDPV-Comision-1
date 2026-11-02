using UnityEngine;
using Pac_Man_Main;
using UnityEngine.SceneManagement;

public class PacManController : MonoBehaviour
{
    private Pac_Man_Main.PacMan modeloLogico;

    //Colocamos variable de velocidad y la variable de vida privada, pero con el "SerializeField" se puede ver desde el inspector
    [SerializeField] private float velocidad = 100f;
    [SerializeField] private int vida = 3;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private float rayDistance = 0.5f;

    //Al tocar WASD el player cambia a esa direccion
    private Vector2 currentDirection = Vector2.zero;
    private Vector2 nextDirection = Vector2.zero;
    private Rigidbody2D rb;

    void Start()
    {
        //Con esto agarramos el componente "Rigidbody2D"
        rb = GetComponent<Rigidbody2D>();
        modeloLogico = new Pac_Man_Main.PacMan("Pac-Man");
    }

    //En el void update se encuntra todos los comandos que vinculan una tecla específica del teclado a la direccion del player
    //Importante tener configurado el Input Manager a "Both"
    void Update()
    {
        Vector2 inputDir = Vector2.zero;

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            inputDir = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            inputDir = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            inputDir = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            inputDir = Vector2.right;
        }

        // Si presionamos una tecla, guardamos la intención en nextDirection
        if (inputDir != Vector2.zero)
        {
            nextDirection = inputDir;
        }

        // Si hay una dirección deseada, chequeamos con Raycast si el camino está libre antes de doblar
        if (nextDirection != Vector2.zero)
        {
            RaycastHit2D hitNext = Physics2D.Raycast(transform.position, nextDirection, rayDistance, wallLayer);
            if (hitNext.collider == null)
            {
                currentDirection = nextDirection; // ¡Camino libre para doblar!
            }
        }

        // Verificamos si la dirección actual se choca con una pared de frente para detenerlo
        if (currentDirection != Vector2.zero)
        {
            RaycastHit2D hitFront = Physics2D.Raycast(transform.position, currentDirection, rayDistance, wallLayer);
            if (hitFront.collider != null)
            {
                currentDirection = Vector2.zero; // Se frena si choca de frente contra la pared
            }
        }
    }

    //Mueve al player a la velocidad fija y en la direccion que esta mirando
    //El Time.deltaTime evita que la velocidad cambie de acuerdo al rendimiento de otros disposistivos
    private void FixedUpdate()
    {
        rb.linearVelocity = currentDirection * velocidad * Time.deltaTime;
    }

    void ReiniciarEscena()
    {
        // Recarga la escena actual desde cero
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        // Si choca contra un punto / pellet
        if (otro.CompareTag("Punto"))
        {
            // Llamamos al método de tu clase lógica de C# (le sumamos 10 puntos por ejemplo)
            modeloLogico.ComerPunto(10);
            Debug.Log("Pac-Man comió un punto. Puntuación actual: " + modeloLogico.Puntuacion);
            // Destruimos el objeto visual en Unity
            Destroy(otro.gameObject);
        }

        // Si choca contra un fantasma
        else if (otro.CompareTag("Fantasma"))
        {
            // Llamamos a la lógica de perder vida
            modeloLogico.PerderVida();
            Debug.Log("Has perdido una vida");

            if (modeloLogico.Vidas <= 0)
            {
                Debug.Log("¡Game Over!");
                // 1. Detenemos por completo el movimiento de Pac-Man
                currentDirection = Vector2.zero;
                if (rb != null)
                {
                    rb.linearVelocity = Vector2.zero;
                }

                // 2. Desactivamos este script para que no pueda seguir moviéndose
                this.enabled = false;

                Invoke("ReiniciarEscena", 2f);
            }
        }
    }
}


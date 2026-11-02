using UnityEngine;
using System.Collections.Generic;
using Pac_Man_Main;

public class FantasmaController : MonoBehaviour
{
    [Header("Configuración de IA")]
    public string tipoFantasma = "Blinky"; // Puede ser "Blinky" o "Inky"
    public float speed = 4f;
    public LayerMask wallLayer;
    public float rayDistance = 0.6f;

    private Vector2 currentDir = Vector2.right;
    private Vector2[] possibleDirections = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
    private Rigidbody2D rb;

    // Instancia de tu clase lógica de C# heredada
    private Fantasma modeloFantasma;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Inicializamos la clase lógica correspondiente según el tipo de fantasma
        if (tipoFantasma == "Blinky")
        {
            modeloFantasma = new Blinky("Blinky", "Rojo", speed);
        }
        else
        {
            modeloFantasma = new Inky("Inky", "Azul");
        }
    }

    void Update()
    {
        // Opcional: puedes invocar el método lógico si quieres verlo reflejado
        // modeloFantasma.Moverse();
    }

    // Las físicas y movimientos se hacen en FixedUpdate (Regla 3 de la cátedra)
    void FixedUpdate()
    {
        // Si hay una pared enfrente, elegimos otra dirección
        if (Physics2D.Raycast(transform.position, currentDir, rayDistance, wallLayer))
        {
            ChooseNewDirection();
        }

        // REGLA DE ORO: Movimiento físico con Rigidbody2D (Nada de transform.Translate)
        rb.linearVelocity = currentDir * speed;
    }

    void ChooseNewDirection()
    {
        List<Vector2> validDirections = new List<Vector2>();

        foreach (Vector2 dir in possibleDirections)
        {
            if (dir != -currentDir && !Physics2D.Raycast(transform.position, dir, rayDistance, wallLayer))
            {
                validDirections.Add(dir);
            }
        }

        if (validDirections.Count > 0)
        {
            currentDir = validDirections[Random.Range(0, validDirections.Count)];
        }
        else
        {
            currentDir = -currentDir;
        }
    }

    // Detección si toca a Pac-Man
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player") || otro.name.Contains("PacMan"))
        {
            // Invocamos el método lógico que heredaste (ejecuta si está vulnerable o no)
            modeloFantasma.SerDevorado();
            Debug.Log("¡Un fantasma interactuó con Pac-Man!");
        }
    }
}
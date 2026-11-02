using UnityEngine;

public class GuerreroLogico : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 inputMovimiento;
    [SerializeField] private float velocidad = 5f;
    public Personaje Guerrero;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Personaje Guerrero = new Personaje("Guerrero", 100, 30);
        Guerrero.EstaVivo = true;

    }
    
    void Update()
    {
        if (Guerrero.EstaVivo == true)
        {
            inputMovimiento.x = Input.GetAxisRaw("Horizontal");
            inputMovimiento.y = Input.GetAxisRaw("Vertical");
            inputMovimiento = inputMovimiento.normalized;
        }
    }

    private void FixedUpdate()
    {
        if (!Guerrero.EstaVivo)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }
    }
}

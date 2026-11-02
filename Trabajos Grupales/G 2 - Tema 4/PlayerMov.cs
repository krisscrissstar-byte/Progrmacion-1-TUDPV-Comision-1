using UnityEngine;

public class PlayerMov : MonoBehaviour
{   
    [Header("ATRIBUTOS")] 
    [SerializeField] private string nombre = "Chunli";
    [SerializeField] private int barraSalud = 100;
    [SerializeField] private int barraKi = 100;
    [SerializeField] private string Danio2 = "Danio2";
    
    

    [Header("MOV")]
    public float speed = 6f;
    public float jumpForce = 8f;
    public float rayLength = 0.1f;

    [Header("ATAQUE")]
    
    public GameObject projectilePrefab;
    public Transform firePoint;          // objeto hijo delante del jugador
    public float fireCooldown = 0.4f;
    public float facingDirection = 1f;

    private float nextFireTime;
    

    [Header("REFS")]
    private ChunLi chunli;
    private Luchador luchador;
    private Rigidbody2D rb;
    public Transform groundCheck;      // objeto hijo ubicado en los pies
    public LayerMask groundLayer;
    private float input;
    private bool salto;
    private bool isGrounded;
    private ChunLi CostoKikoken;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
        rb.freezeRotation = true;

        luchador = GetComponent<Luchador>();
    }


    void Update()
    {

        input = 0f;
        if (Input.GetKey(KeyCode.A)) input = -1f;
        if (Input.GetKey(KeyCode.D)) input = 1f;
        if (Input.GetKey(KeyCode.W)) salto = true;

        //PELEA

        if (Input.GetKeyDown(KeyCode.J) && Time.time >= nextFireTime && barraKi > 0)
        {
            Disparar();

            nextFireTime = Time.time + fireCooldown;
            barraKi -= 25;
        }

        if(barraSalud <= 0)
        {
            Destroy(gameObject);
        }
        
        
    }


    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, rayLength, groundLayer);
        isGrounded = hit.collider != null;

        rb.linearVelocity = new Vector2(input * speed, rb.linearVelocity.y);

       

        if (salto && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // salto consistente
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        salto = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger con: " + other.name + " | tag: " + other.tag);
        if (other.CompareTag(Danio2))
        {
           
            barraSalud -= 25;
        }
    }


    private void Disparar()
    {
        GameObject proj = Instantiate (projectilePrefab, firePoint.position, Quaternion.identity);
        proj.GetComponent<Projectile>().Launch(Vector2.right * facingDirection);
    }

}

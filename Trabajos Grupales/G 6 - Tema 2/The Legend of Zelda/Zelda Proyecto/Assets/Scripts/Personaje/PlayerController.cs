using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject swordHitbox; 
    [SerializeField] private float swordDistance = 0.8f;
    [SerializeField] private float swordDuration = 0.2f;

    public Link Modelo { get; private set; }

    public int DanioEspada
    {
        get
        {
            var espada = Modelo.ObtenerItem(0) as EspadaMaestra;
            return espada != null ? espada.DanioSagrado : 0;
        }
    }

    private Rigidbody2D rb;
    private Vector2 input;
    private Vector2 facing = Vector2.down;
    private bool attacking;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;

        Modelo = new Link("Link", 10);
        Modelo.Equipar(new EspadaMaestra("Espada Maestra", 100, 30), 0);
        Modelo.Equipar(new ArcoFuerza("Arco de Fuerza", 50, 3), 1);

        if (swordHitbox != null) swordHitbox.SetActive(false);
    }

    void Update()
    {
        if (attacking)
        {
            input = Vector2.zero;
            return;
        }

        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        if (input.magnitude > 0)
        {
            input.Normalize();
            facing = input;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !attacking)
        {
            StartCoroutine(Attack());
        }
    }

    void FixedUpdate()
    {
        // CORRECCIÓN DE COMPATIBILIDAD UNIVERSAL: rb.velocity en lugar de linearVelocity
        rb.linearVelocity = input * speed;
    }

    private IEnumerator Attack()
    {
        attacking = true;
        Modelo.AccionarItem(0); 

        if (swordHitbox != null)
        {
            swordHitbox.transform.localPosition = facing * swordDistance;
            swordHitbox.SetActive(true);
        }

        yield return new WaitForSeconds(swordDuration);

        if (swordHitbox != null) swordHitbox.SetActive(false);
        attacking = false;
    }
}
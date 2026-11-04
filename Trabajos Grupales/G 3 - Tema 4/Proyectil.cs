using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 12f;
    public float lifeTime = 3f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Lo llama el jugador al instanciarlo
    public void Launch(Vector2 direction)
    {
        rb.gravityScale = 0f;
        rb.linearVelocity = direction.normalized * speed;

        // Voltea el sprite según la dirección
        Vector3 scale = transform.localScale;
        scale.x = Mathf.Abs(scale.x) * Mathf.Sign(direction.x);
        transform.localScale = scale;

        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Aquí luego puedes aplicar daño al otro jugador
        Destroy(gameObject);
    }

    internal void Launch(Vector2 vector2, GameObject gameObject)
    {
        throw new NotImplementedException();
    }
}
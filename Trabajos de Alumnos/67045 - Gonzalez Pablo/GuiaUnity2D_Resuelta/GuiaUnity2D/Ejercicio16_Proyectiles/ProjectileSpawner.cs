using UnityEngine;

// Ejercicio 16: Dispara proyectiles Kinematic desde un punto y los destruye tras un tiempo.
public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private float lifetime = 2f;

    void Update()
    {
        // "Fire1" = clic izquierdo o Ctrl izquierdo por defecto.
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        // Crear la bala en la posición y rotación del firePoint.
        GameObject bulletInstance = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Un Rigidbody2D Kinematic no responde a fuerzas, pero sí a la velocidad asignada.
        Rigidbody2D bulletRb = bulletInstance.GetComponent<Rigidbody2D>();
        if (bulletRb != null)
        {
            // firePoint.right = la dirección hacia donde "mira" el arma (eje X local).
            bulletRb.linearVelocity = firePoint.right * bulletSpeed; // (Unity 2022-: velocity)
        }

        // Destrucción diferida: la bala desaparece sola tras 'lifetime' segundos.
        Destroy(bulletInstance, lifetime);
    }
}

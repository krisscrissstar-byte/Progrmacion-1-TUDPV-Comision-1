using UnityEngine;

public class EnemigoController : MonoBehaviour
{
    private DoomSimple.Zombie zombie;

    void Awake()
    {
        zombie = new DoomSimple.Zombie(0, 0);
    }

    public void RecibirDanio(int cantidad)
    {
        zombie.RecibirDanio(cantidad);

        Debug.Log("Vida del zombie: " + zombie.Vida);

        if (!zombie.EstaVivo())
        {
            Debug.Log("Zombie eliminado");
            Destroy(gameObject);
        }
    }
}
using UnityEngine;

// Ejercicio 14: Contador de puntos al recolectar monedas (va en el Player).
public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log("Puntaje actual: " + score);
        }
    }
}

/*
 * Ojo: si se usan estas monedas con Tag "Coin", NO ponerles también el script
 * del Ejercicio 12 (que se autodestruye), o se podría contar mal.
 */

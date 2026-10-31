using UnityEngine;

// Ejercicio 3: Si el objeto sale por un borde, reaparece por el borde opuesto.
public class ScreenWrap : MonoBehaviour
{
    // Con una cámara ortográfica de Size = 5 y relación 16:9,
    // la pantalla va aprox. de -8.9 a 8.9 en X y de -5 a 5 en Y.
    [SerializeField] private float limitX = 9f;
    [SerializeField] private float limitY = 5f;

    void Update()
    {
        Vector3 pos = transform.position;

        // Eje X
        if (pos.x > limitX)
            pos.x = -limitX;
        else if (pos.x < -limitX)
            pos.x = limitX;

        // Eje Y
        if (pos.y > limitY)
            pos.y = -limitY;
        else if (pos.y < -limitY)
            pos.y = limitY;

        transform.position = pos;
    }
}

/*
 * Para probarlo, el objeto tiene que moverse. Se puede agregar un movimiento simple
 * en el mismo Update, por ejemplo:
 *
 *   transform.Translate(Vector2.right * 5f * Time.deltaTime);
 *
 * o usar el TopDownController del Ejercicio 6 en el mismo GameObject.
 */

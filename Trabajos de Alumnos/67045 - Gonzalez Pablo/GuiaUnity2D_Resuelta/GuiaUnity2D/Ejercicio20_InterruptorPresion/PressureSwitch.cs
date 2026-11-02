using UnityEngine;

// Ejercicio 20: Placa de presión que activa un puente mientras haya algo encima.
public class PressureSwitch : MonoBehaviour
{
    [SerializeField] private GameObject bridge;

    // Contamos cuántos cuerpos hay sobre la placa: si están el jugador y la caja
    // y se baja uno, el puente debe seguir activo.
    private int objectsOnPlate = 0;

    void Start()
    {
        bridge.SetActive(false); // el puente empieza desactivado
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Solo cuentan cuerpos dinámicos (jugador, cajas).
        if (other.attachedRigidbody == null || other.attachedRigidbody.bodyType != RigidbodyType2D.Dynamic)
            return;

        objectsOnPlate++;
        bridge.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.attachedRigidbody == null || other.attachedRigidbody.bodyType != RigidbodyType2D.Dynamic)
            return;

        objectsOnPlate = Mathf.Max(0, objectsOnPlate - 1);

        if (objectsOnPlate == 0)
        {
            bridge.SetActive(false);
        }
    }
}

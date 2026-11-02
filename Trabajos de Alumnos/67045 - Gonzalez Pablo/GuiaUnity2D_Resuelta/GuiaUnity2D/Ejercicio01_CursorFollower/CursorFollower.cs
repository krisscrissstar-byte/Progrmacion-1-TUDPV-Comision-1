using UnityEngine;

// Ejercicio 1: El objeto sigue al cursor del ratón.
public class CursorFollower : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        // Guardamos la referencia una sola vez (Camera.main busca por Tag "MainCamera").
        cam = Camera.main;
    }

    void Update()
    {
        // Posición del mouse en píxeles de pantalla.
        Vector3 mouseScreen = Input.mousePosition;

        // Conversión de coordenadas de pantalla a coordenadas del mundo.
        Vector3 mouseWorld = cam.ScreenToWorldPoint(mouseScreen);

        // Fijamos Z en 0 para que el objeto no quede detrás de la cámara.
        mouseWorld.z = 0f;

        transform.position = mouseWorld;
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class AbrirCofre : MonoBehaviour
{
    private SupervivienteControlador supervivienteEnRango;
    private bool abierto;

    private void Update()
    {
        if (abierto || supervivienteEnRango == null || Keyboard.current == null)
            return;

        if (Keyboard.current.eKey.wasPressedThisFrame &&
            supervivienteEnRango.AgregarRecompensaAleatoria())
        {
            abierto = true;
            Debug.Log("Abriste el cofre.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SupervivienteControlador superviviente =
            other.GetComponentInParent<SupervivienteControlador>();

        if (superviviente == null)
            return;

        supervivienteEnRango = superviviente;
        Debug.Log("Presiona E para abrir el cofre.");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        SupervivienteControlador superviviente =
            other.GetComponentInParent<SupervivienteControlador>();

        if (superviviente == supervivienteEnRango)
            supervivienteEnRango = null;
    }
}

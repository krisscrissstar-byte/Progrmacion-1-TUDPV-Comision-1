using UnityEngine;

public class Cofre : MonoBehaviour
{
    [SerializeField] private string itemName = "Llave pequeña";
    private PlayerController playerInRange;
    private Animator animator;
    private bool opened;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null) Debug.LogWarning("No se encontró un Animator en el cofre.");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<PlayerController>(out var p)) playerInRange = p;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() == playerInRange) playerInRange = null;
    }

    void Update()
    {
        if (opened || playerInRange == null || !Input.GetKeyDown(KeyCode.E)) return;

        if (playerInRange.Modelo.AgregarItem(new Llave(itemName)))
        {
            opened = true;
            Debug.Log($"Cofre abierto: {itemName}");
            animator.SetTrigger("Abrir");
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

namespace SuperMartin
{
    public sealed class LevelGoal : MonoBehaviour
    {
        [SerializeField] private Text message;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<MartinController>() == null) return;
            message.text = "¡BIEN HECHO, MARTÍN!\nLlegaste al final del primer recorrido.";
        }
    }
}

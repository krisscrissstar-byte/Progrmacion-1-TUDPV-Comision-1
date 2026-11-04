using UnityEngine;
using UnityEngine.SceneManagement;

namespace SuperMartin
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class MartinFallRestart : MonoBehaviour
    {
        [SerializeField] private float fallLimit = -7f;

        private Rigidbody2D body;
        private bool restarting;

        private void Awake() => body = GetComponent<Rigidbody2D>();

        private void FixedUpdate()
        {
            if (restarting || body.position.y >= fallLimit) return;
            restarting = true;
            SceneManager.LoadSceneAsync(gameObject.scene.path, LoadSceneMode.Single);
        }
    }
}

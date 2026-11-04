using UnityEngine;
using UnityEngine.InputSystem;

namespace SuperMartin
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public sealed class MartinController : MonoBehaviour
    {
        [Header("Controles y movimiento")]
        [SerializeField] private InputActionAsset controls;
        [SerializeField, Min(0.1f)] private float speed = 6f;
        [SerializeField, Min(0.1f)] private float acceleration = 45f;
        [SerializeField, Min(0.1f)] private float jumpSpeed = 12f;
        [Header("Presentación")]
        [SerializeField] private Transform artwork;

        private Rigidbody2D body;
        private BoxCollider2D bodyCollider;
        private InputActionAsset instance;
        private InputAction move;
        private InputAction jump;
        private readonly ContactPoint2D[] contacts = new ContactPoint2D[12];
        private float direction;
        private float jumpUntil = float.NegativeInfinity;

        public bool IsGrounded { get; private set; }

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
            bodyCollider = GetComponent<BoxCollider2D>();
            if (controls == null)
            {
                Debug.LogError("Asigná Martin.inputactions en los controles del personaje.", this);
                enabled = false;
                return;
            }
            instance = Instantiate(controls);
            move = instance.FindAction("Martin/Move", true);
            jump = instance.FindAction("Martin/Jump", true);
        }

        private void OnEnable() => instance?.Enable();
        private void OnDisable()
        {
            instance?.Disable();
            direction = 0;
            jumpUntil = float.NegativeInfinity;
        }

        private void OnDestroy() => Destroy(instance);

        private void Update()
        {
            direction = move.ReadValue<float>();
            // Remember the press until the next physics step, including just before landing.
            if (jump.WasPressedThisFrame()) jumpUntil = Time.time + 0.1f;
            if (artwork != null && Mathf.Abs(direction) > 0.01f)
                artwork.localScale = new Vector3(Mathf.Sign(direction), 1, 1);
        }

        private void FixedUpdate()
        {
            IsGrounded = false;
            int count = bodyCollider.GetContacts(contacts);
            for (int i = 0; i < count; i++)
                if (contacts[i].normal.y > 0.65f) { IsGrounded = true; break; }

            Vector2 velocity = body.linearVelocity;
            velocity.x = Mathf.MoveTowards(velocity.x, direction * speed, acceleration * Time.fixedDeltaTime);
            if (IsGrounded && velocity.y <= 0.1f && Time.time <= jumpUntil)
            {
                velocity.y = jumpSpeed;
                jumpUntil = float.NegativeInfinity;
                IsGrounded = false;
            }
            body.linearVelocity = velocity;
        }
    }
}

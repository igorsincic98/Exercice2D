using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 _movement;
        private Rigidbody2D _rb;
        [SerializeField] public static float MoveSpeed;

        void Awake()
        {
            MoveSpeed = 5f;
            _rb = GetComponent<Rigidbody2D>();

        }

        void Update()
        {
            _movement.Set(InputManager.Movement.x, InputManager.Movement.y);

            _rb.linearVelocity = _movement * MoveSpeed;
        }
    }
}

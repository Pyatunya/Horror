using UnityEngine;

namespace Game.Model.Character
{
    public sealed class CharacterMovement : MonoBehaviour
    {
        [SerializeField] private CharacterMovementView _view;
    
        private readonly float _speed = 5f;
        private Rigidbody2D _characterRb;

        private void Awake()
        {
            _characterRb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            Vector2 direction = new Vector2(horizontal * _speed * Time.deltaTime, 0f);
            _characterRb.MovePosition((Vector2)transform.localPosition + direction);
            _view.Move(direction);
        }
    }
}
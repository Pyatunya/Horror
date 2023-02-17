using UnityEngine;

namespace Game.Model.Character
{
    public sealed class CharacterMovementView : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private SpriteRenderer _spriteRenderer;

        private readonly int _move = Animator.StringToHash("Move");

        public void Move(Vector2 direction)
        {
            if(direction.x != 0f)
            _spriteRenderer.flipX = direction.x < 0f;

            if (direction == Vector2.zero)
            {
                _animator.SetBool(_move, false);
                return;
            }

            _animator.SetBool(_move, true);
        }
    }
}
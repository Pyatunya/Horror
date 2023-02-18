using UnityEngine;

namespace Game.Model.Character
{
    public sealed class CharacterInteractInput : MonoBehaviour
    {
        public bool IsUsing => Input.GetKeyDown(KeyCode.E);

        private Interactable _currentInteractable;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _currentInteractable != null)
            {
                if (_currentInteractable.CheckState())
                {
                    _currentInteractable.Close();
                }
                else
                {
                    _currentInteractable.Open();
                }
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Interactable>(out Interactable interact))
            {
                _currentInteractable = interact;
            }
        }

    }
}
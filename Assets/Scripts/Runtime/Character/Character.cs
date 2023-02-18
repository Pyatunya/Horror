using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        private Interactable _currentInteract;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Interactable>(out Interactable interactable))
            {
                _currentInteract = interactable;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Interactable>(out Interactable interactable))
            {
                _currentInteract = null;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _currentInteract != null)
            {
                if (_currentInteract.CheckCurrentState())
                {
                    _currentInteract.Close();
                }
                else
                {
                    _currentInteract.Open();
                }
            }         
        }
    }
}
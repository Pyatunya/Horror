using Game.Model.Items;
using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField] private CharacterInteractInput _interactInput;
        [SerializeField] private Inventory.Inventory _inventory;

        private Interactable _currentInteract;
        
        private void OnTriggerStay2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out IItem item))
            {
                if (_interactInput.IsUsing && item.HasInteracted == false && _inventory.Contains(item) == false)
                { 
                    _inventory.Add(item);
                    item.Interact();
                }
            }
        }

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
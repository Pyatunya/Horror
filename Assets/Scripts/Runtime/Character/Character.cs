using Game.Model.Interactables;
using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField] private CharacterInteractInput _interactInput;
        
        private void OnTriggerStay2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out IInteractable interactable))
            {
                if (_interactInput.IsUsing && interactable.HasInteracted == false)
                { 
                    interactable.Interact();
                }
            }
        }
    }
}
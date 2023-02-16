using Game.Model.Items;
using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        [SerializeField] private CharacterInteractInput _interactInput;
        [SerializeField] private Inventory.Inventory _inventory;
        
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
    }
}
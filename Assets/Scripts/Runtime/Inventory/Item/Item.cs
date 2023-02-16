using UnityEngine;

namespace Game.Model.Items
{
    public sealed class Item : MonoBehaviour, IItem
    {
        public bool HasInteracted { get; private set; }
        
        [field: SerializeField] public ItemData Data { get; private set; }

        public void Interact()
        {
            HasInteracted = !HasInteracted;
        }
    }
}
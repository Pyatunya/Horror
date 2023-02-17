using UnityEngine;

namespace Game.Model.Items
{
    public sealed class Item : MonoBehaviour, IItem
    {
        [SerializeField] private bool _needDisableOnTook;
        
        public bool HasInteracted { get; private set; }
        
        [field: SerializeField] public ItemData Data { get; private set; }

        public void Interact()
        {
            HasInteracted = !HasInteracted;
            
            if(_needDisableOnTook)
                gameObject.SetActive(!HasInteracted);
        }
    }
}
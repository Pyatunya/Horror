using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class Interactable : MonoBehaviour, IInteractable
    {
        public bool HasInteracted { get; private set; }

        public void Interact()
        {
            HasInteracted = !HasInteracted;
        }
    }
}
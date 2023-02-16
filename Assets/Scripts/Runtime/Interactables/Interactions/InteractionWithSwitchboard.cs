using UnityEngine;

namespace Game.Model.Interactables
{
    public abstract class InteractionWithSwitchboard : MonoBehaviour, IInteractionWithSwitchboard
    {
        public abstract void Play();
    }
}
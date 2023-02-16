using UnityEngine;

namespace Game.Model.Items
{
    public abstract class InteractionWithSwitchboard : MonoBehaviour, IInteractionWithSwitchboard
    {
        public abstract void Play();
    }
}
using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class KeyWithSwitchboardInteraction : InteractionWithSwitchboard
    {
        [SerializeField] private SwitchboardView _view;

        public override void Play()
        {
            _view.Open();
        }
    }
}
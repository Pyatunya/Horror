using UnityEngine;

namespace Game.Model.Items
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
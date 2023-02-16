using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class DryGlovesWithSwitchboardInteraction : InteractionWithSwitchboard
    {
        [SerializeField] private SwitchboardView _switchboardView;
        [SerializeField] private EndGameView _endGameView;

        public override void Play()
        {
            if (_switchboardView.IsOpen)
                _endGameView.Visualize();

        }
    }
}
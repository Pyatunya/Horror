using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class WetGlovesWithSwitchboardInteraction : InteractionWithSwitchboard
    {
        [SerializeField] private EnergyKnockView _energyKnockView;

        public override void Play()
        {
            _energyKnockView.Visualize();
        }
    }
}
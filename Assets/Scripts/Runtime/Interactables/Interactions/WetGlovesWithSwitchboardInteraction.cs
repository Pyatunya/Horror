using UnityEngine;

namespace Game.Model.Items
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
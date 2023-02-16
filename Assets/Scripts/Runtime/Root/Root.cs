using System.Collections.Generic;
using Game.Model.Interactables;
using UnityEngine;

namespace Game.Root
{
    public sealed class Root : MonoBehaviour
    {
        [SerializeField] private UnityDictionary<Interactable, InteractionWithSwitchboard> _interactions;
        [SerializeField] private Switchboard _switchboard;

        private void Awake()
        {
            IReadOnlyDictionary<Interactable,InteractionWithSwitchboard> interactions = _interactions.ToDictionary();
            _switchboard.Init(interactions);
        }
    }
}
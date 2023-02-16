using System.Collections.Generic;
using Game.Model.Items;
using UnityEngine;

namespace Game.Root
{
    public sealed class Root : MonoBehaviour
    {
        [SerializeField] private UnityDictionary<Item, InteractionWithSwitchboard> _interactions;
        [SerializeField] private Switchboard _switchboard;

        private void Awake()
        {
            IReadOnlyDictionary<Item,InteractionWithSwitchboard> interactions = _interactions.ToDictionary();
            _switchboard.Init(interactions);
        }
    }
}
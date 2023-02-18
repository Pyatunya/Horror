using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Model.Items
{
    public sealed class Switchboard : MonoBehaviour, IItem
    {
        [SerializeField] private TextTable _textTable;
        private IReadOnlyDictionary<Item, InteractionWithSwitchboard> _interactions;

        public bool HasInteracted { get; private set; }

        [field: SerializeField] public ItemData Data { get; private set; }

        public void Init(IReadOnlyDictionary<Item, InteractionWithSwitchboard> interactions)
        {
            if (interactions.Count == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(interactions));

            _interactions = interactions ?? throw new ArgumentNullException(nameof(interactions));
        }

        public void Interact()
        {
            HasInteracted = true;

            var interaction = _interactions.ToList().Find(interactable => interactable.Key.HasInteracted).Value;

            if (interaction is null)
            {
                _textTable.Activate();
            }

            else
            {
                interaction.Play();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Model.Interactables
{
    public sealed class Switchboard : MonoBehaviour, IInteractable
    {
        [SerializeField] private TextTable _textTable;

        public bool HasInteracted { get; private set; }

        private IReadOnlyDictionary<Interactable, InteractionWithSwitchboard> _interactions;

        public void Init(IReadOnlyDictionary<Interactable, InteractionWithSwitchboard> interactions)
        {
            if (interactions.Count == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(interactions));
            
            _interactions = interactions ?? throw new ArgumentNullException(nameof(interactions));
        }

        public void Interact()
        {
            HasInteracted = !HasInteracted;

            if (HasInteracted)
            {
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
}
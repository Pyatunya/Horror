using Game.Model.Character;
using UnityEngine;

namespace Game.Model
{
    public class Transformer : Interactable
    {
        [SerializeField] private Character.Character character;

        public override void Open()
        {
            if(character.HasKey)
            base.Open();
        }
    }
}

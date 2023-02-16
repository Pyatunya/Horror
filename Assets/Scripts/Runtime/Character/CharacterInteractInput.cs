using UnityEngine;

namespace Game.Model.Character
{
    public sealed class CharacterInteractInput : MonoBehaviour
    {
        public bool IsUsing => Input.GetKeyDown(KeyCode.E);
 
    }
}
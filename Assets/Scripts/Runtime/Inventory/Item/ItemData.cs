using UnityEngine;

namespace Game.Model.Items
{
    [CreateAssetMenu(menuName = "Create/Item", fileName = "ItemData", order = 0)]
    public sealed class ItemData : ScriptableObject
    {
        [field: SerializeField] public Sprite Sprite { get; private set; }
        
        [field: SerializeField] public string Name { get; private set; }

    }
}
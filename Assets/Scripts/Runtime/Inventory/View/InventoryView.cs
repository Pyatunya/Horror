using Game.Model.Items;
using UnityEngine;

namespace Game.Model.Inventory
{
    public sealed class InventoryView : MonoBehaviour
    {
        [SerializeField] private ItemView _prefab;
        [SerializeField] private Transform _content;
        
        public void Add(ItemData itemData)
        {
            ItemView itemView = Instantiate(_prefab, _content);
            itemView.Visualize(itemData);
        }
    }
}
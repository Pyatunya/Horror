using System;
using System.Collections.Generic;
using Game.Model.Items;
using UnityEngine;

namespace Game.Model.Inventory
{
    public sealed class Inventory : MonoBehaviour, IInventory
    {
        [SerializeField] private InventoryView _view;
        private readonly List<IItem> _items = new List<IItem>();

        public IReadOnlyList<IItem> Items => _items;
        
        public void Add(IItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            
            _items.Add(item);
            _view.Add(item.Data);
        }

        public bool Contains(IItem item) => _items.Contains(item);
        
    }
}
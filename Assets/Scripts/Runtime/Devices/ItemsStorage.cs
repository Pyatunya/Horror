using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class ItemsStorage : MonoBehaviour
    {
        private List<Item> _items = new List<Item>();

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out Item item))
            {
                _items.Add(item);
            }
        }

        public bool HasKeys()
        {
            return _items.Contains(new Key());
        }

        public bool HasGlowes()
        {
            return _items.Contains(new Glowes());
        }
    }
}

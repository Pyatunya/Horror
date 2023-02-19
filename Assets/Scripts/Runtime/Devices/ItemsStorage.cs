using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class ItemsStorage : MonoBehaviour
    {
        [SerializeField] private KeyPanelInventory _keyView;

        private readonly Key key;
        private readonly Glowes glowes;
        private List<Item> _items = new List<Item>();

        public bool HasKey { get; private set; }

        private Item _currentItem;

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.TryGetComponent(out Item item))
            {
                _currentItem = item;
                
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _currentItem != null)
            {
                _items.Add(_currentItem);
                _currentItem.gameObject.SetActive(false);

                
            }
            if (_items.Contains(key))
            {
                Debug.Log("Хуй знает");
                HasKey = true;
            }
        }

        public bool HasKeys()
        {
            return _items.Contains(key);
        }

        public bool HasGlowes()
        {
            return _items.Contains(glowes);
        }
    }
}

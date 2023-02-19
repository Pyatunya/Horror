using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public  class KeyPanelInventory : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private bool _haskey;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void ViewKey()
        {
            Debug.Log("��� �����");
            _spriteRenderer.sprite = _sprite;
        }
        
    }
}

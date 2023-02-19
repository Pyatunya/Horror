using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class GlovesPanelInventory : MonoBehaviour
    {
        
        [SerializeField] private Sprite _sprite;

        private bool _haskey;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }


        public void ViewGloves()
        {
            Debug.Log("Хуй знает");
            _spriteRenderer.sprite = _sprite;
        }
    }
}

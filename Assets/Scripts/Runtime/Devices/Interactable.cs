using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private Sprite _closeState;
        [SerializeField] private Sprite _openState;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        public virtual void Open()
        {
            _spriteRenderer.sprite = _openState;
        }

        public void Close()
        {
            _spriteRenderer.sprite = _closeState;
        }

        public bool CheckCurrentState()
        {
            return _spriteRenderer.sprite == _openState;
        }

        internal void LightningHit()
        {
            Debug.Log("≈бать теб€ уебало");
        }
    }
}

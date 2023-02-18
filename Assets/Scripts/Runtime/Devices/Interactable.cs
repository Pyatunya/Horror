using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class Interactable : MonoBehaviour
    {
        [SerializeField] private Sprite _closeState;
        [SerializeField] private Sprite _openState;

        private SpriteRenderer _sriteRenderer;

        private void Start()
        {
            _sriteRenderer = GetComponent<SpriteRenderer>();
        }

        public void Close()
        {
            _sriteRenderer.sprite = _closeState;
        }

        public void Open()
        {
            _sriteRenderer.sprite = _openState;
        }

        public bool CheckState()
        {
            return _sriteRenderer.sprite == _openState;
        }
    }
}

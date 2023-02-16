using UnityEngine;

namespace Game.Model.Items
{
    public sealed class SwitchboardView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spriteRenderer;
        [SerializeField] private Sprite _closeSprite;
        [SerializeField] private Sprite _openSprite;
        
        public bool IsOpen { get; private set; }

        public void Open()
        {
            IsOpen = true;
            Visualize(_openSprite);
        }

        public void Close()
        {
            IsOpen = false;
            Visualize(_closeSprite);
        }

        private void Visualize(Sprite sprite) => _spriteRenderer.sprite = sprite;
        
    }
}
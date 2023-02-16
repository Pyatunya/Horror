using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game.Model.Items
{
    public sealed class TextTable : MonoBehaviour
    {
        [SerializeField, Min(0.01f)] private float _activeSeconds = 1.3f;

        public async void Activate()
        {
            gameObject.SetActive(true);
            await UniTask.Delay(TimeSpan.FromSeconds(_activeSeconds));
            gameObject.SetActive(false);
        }
    }
}
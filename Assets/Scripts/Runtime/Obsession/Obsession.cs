using System;
using Game.View;
using UnityEngine;

namespace Game.Model.Obsession
{
    public sealed class Obsession : MonoBehaviour
    {
        [SerializeField] private ObsessionView _view;
        
        [field: SerializeField, Range(0, 100)] public int Value { get; private set; }

        public void Increase(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            
            Value += amount;
            _view.Visualize(Value);
        }
        
        public void Decrease(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            Value -= value;
            _view.Visualize(Value);
        }
    }
}

using System;
using Game.View;
using UnityEngine;

namespace Game.Model.Obsession
{
    public sealed class Obsession : MonoBehaviour
    {
        [SerializeField] private ObsessionView _view;
        public readonly int MaxValue = 100;
        
        public float Value { get; private set; }

        private void Start() => _view.Visualize(Value);

        public bool CanIncrease(float value) => Value + value <= MaxValue && value > 0;
        
        public void Increase(float value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            if (CanIncrease(value) == false)
                throw new InvalidOperationException(nameof(Increase));

            Value += value;
            _view.Visualize(Value);
        }
        
        public void Decrease(float value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            
            Value -= value;
            _view.Visualize(Value);
        }
    }
}

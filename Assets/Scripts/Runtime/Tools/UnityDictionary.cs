using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Root
{
    [Serializable]
    public sealed class UnityDictionary<TKey, TValue>
    {
        [SerializeField] private List<TKey> _keys;
        [SerializeField] private List<TValue> _values;

        public Dictionary<TKey, TValue> ToDictionary()
        {
            if (_keys.Count != _values.Count)
                throw new ArgumentOutOfRangeException($"Key's count differs from values count");

            var dictionary = new Dictionary<TKey, TValue>();

            for (var i = 0; i < _keys.Count; i++)
            {
                dictionary.Add(_keys[i], _values[i]);
            }

            return dictionary;
        }
    }
}
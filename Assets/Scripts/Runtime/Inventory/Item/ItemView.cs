using System;
using Game.Model.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Model.Inventory
{
    public sealed class ItemView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private Image _image;

        public void Visualize(ItemData data)
        {
            if (data == null) 
                throw new ArgumentNullException(nameof(data));
            
            _image.sprite = data.Sprite;
            _name.text = data.Name;
        }
    }
}
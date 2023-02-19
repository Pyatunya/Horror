using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class Kitchen : Interactable
    {
        [SerializeField] AudioClip _knife;

        private AudioSource _audiosource;

        private void Start()
        {
            _audiosource = GetComponent<AudioSource>();
        }

        
    }
}

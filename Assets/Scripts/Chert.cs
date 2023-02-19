using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Chert : MonoBehaviour
    {
        [SerializeField] private AudioClip _screamer;


        private Animator _animator;
        private AudioSource _audio;
        private bool _isScreamed;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            
        }

        void Start()
        {
            _animator = GetComponent<Animator>();
            _audio = GetComponent<AudioSource>();
            StartCoroutine(RunToScare());
        }

        void Update()
        {
            _animator.Play("Chert");
            if (_isScreamed)
            {
                _audio.PlayOneShot(_screamer);
            }
        }

        public IEnumerator RunToScare()
        {
            while (true)
            {
                yield return null;

                transform.Translate(25f * Time.deltaTime, 0, 0, 0);
            }

        }
    }


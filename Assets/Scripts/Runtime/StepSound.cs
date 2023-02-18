using UnityEngine;

namespace Game.Model
{
    public class StepSound : MonoBehaviour
    {
        [SerializeField] private AudioClip[] _audioClips;

        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlayOnStep()
        {
            int randomSoundIndex = Random.Range(0, _audioClips.Length);
            _audioSource.PlayOneShot(_audioClips[randomSoundIndex]);
        }
    }
}

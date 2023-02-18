using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        private Interactable _currentInteract;
        private Transformer _transformer;
        public bool HasKey { get; private set; }
        public bool HasGloves { get; private set; }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            SetLinkToDevice(collision);

            if (collision.gameObject.TryGetComponent(out Key key))
            {
                HasKey = true;
            }
            else if (collision.gameObject.TryGetComponent(out Glowes gloves))
            {
                HasGloves = true;
            }
        }

        private void SetLinkToDevice(Collider2D collision)
        {
            if (collision.TryGetComponent(out Interactable interactable))
                _currentInteract = interactable;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Interactable _))
                _currentInteract = null;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _currentInteract != null)
            {
                SwitchDeviceState();
            }
            else if(Input.GetKeyDown(KeyCode.F) && _currentInteract == _transformer)
            {
                if (HasGloves)
                {
                    GameState.EndGame();
                }
                else
                {
                    Debug.Log("Ты еблан? Без перчаток");
                }
            }
        }

        private void SwitchDeviceState()
        {
            if (_currentInteract.CheckCurrentState())
                _currentInteract.Close();
            else
                _currentInteract.Open();         
        }
    }
}
using UnityEngine;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        private Interactable _currentInteract;
        readonly private ItemsStorage _itemStorage;
        private Transformer tempTransformer;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            SetLinkToDevice(collision);
        }

        private void SetLinkToDevice(Collider2D collision)
        {
            if (collision.TryGetComponent(out Interactable interactable))
                _currentInteract = interactable;
            else if (TryGetComponent(out Transformer transformer))
                _currentInteract = transformer;
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
            else if(Input.GetKeyDown(KeyCode.F) && _currentInteract == tempTransformer)
            {
                if (_itemStorage.HasGlowes())
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
            if (_currentInteract == tempTransformer && _itemStorage.HasKeys())
                _currentInteract.Open();

            if (_currentInteract.CheckCurrentState())
                _currentInteract.Close();
            else
                _currentInteract.Open();
        }
    }
}
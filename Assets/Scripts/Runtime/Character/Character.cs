using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game.Model.Character
{
    public sealed class Character : MonoBehaviour
    {
        private Interactable _currentInteract;
        [SerializeField] private Transformer _transformer;

        [SerializeField] Slider _obsessiveBar;

        [SerializeField] LeftWall1 _leftWall;
        [SerializeField] LeftWall2 leftWall2;

        [SerializeField] private KeyPanelInventory _keyPanel;
        [SerializeField] private GlovesPanelInventory _glovesPanel;


        public bool HasKey { get; private set; }
        public bool HasGloves { get; private set ; }

        private GameState1 _gameState;

        private StairsMovement _floorState;

        private bool _isOnLeftWall;

        

        private void Start()
        {
            _gameState = GetComponent<GameState1>();
            _floorState = GetComponent<StairsMovement>();
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(collision.TryGetComponent<LeftWall1>(out LeftWall1 leftWall1))
            {
                _isOnLeftWall = true;
            }
            if(collision.TryGetComponent<LeftWall2>(out LeftWall2 leftwall2))
            {
                _isOnLeftWall = true;
            }
        }

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
            if (collision.gameObject.TryGetComponent(out Transformer transformer))
            {
                _currentInteract = transformer;
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

            if (Input.GetKeyDown(KeyCode.F) && _currentInteract == _transformer && HasKey)
            {
                
                if (HasGloves)
                {
                    Debug.Log("Победа");
                    SceneManager.LoadScene(3);
                }
                else
                {
                    Debug.Log("Ты еблан? Без перчаток");
                    _gameState.BadEndGame("Electricity");
                }
            }

            if (_obsessiveBar.value > 0.95)
            {
                StartCoroutine(Suicide());
                Debug.Log("Пизда");
            }

            if (HasKey && Input.GetKeyDown(KeyCode.E))
            {
                _keyPanel.ViewKey();
            }

            if (HasGloves && Input.GetKeyDown(KeyCode.E))
            {
                _glovesPanel.ViewGloves();
            }
        }

        private void SwitchDeviceState()
        {
            if (_currentInteract.CheckCurrentState())
                _currentInteract.Close();
            else
                _currentInteract.Open();  
        }

       IEnumerator Suicide()
        {
            transform.Translate(-15 * Time.deltaTime, 0, 0);
            yield return null;
            if (_floorState.IsOnFirstFloor)
            {
                
                if (_isOnLeftWall)
                {
                    SceneManager.LoadScene(4);
                   
                }
            }
            else if (_floorState.IsOnSecondFloor)
            {
                if (_isOnLeftWall)
                {
                    SceneManager.LoadScene(5);
                }
            }
        }
    }
}
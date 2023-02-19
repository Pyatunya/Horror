using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Model
{
    public class StairsMovement : MonoBehaviour
    {
        [SerializeField] private StairPoint _firstFloor;
        [SerializeField] private StairPoint _secondFloor;

        private bool isOnFirstFloor;
        private StairPoint _currentStairPoint;

        public bool IsOnFirstFloor { get; private set; }
        public bool IsOnSecondFloor { get; private set; }

        private void Awake()
        {
            IsOnFirstFloor = true;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<StairPoint>(out StairPoint stairPoint))
            {                
                if(stairPoint == _firstFloor)
                {
                    _currentStairPoint = stairPoint;
                    isOnFirstFloor = true;
                }
                else
                {
                    _currentStairPoint = _secondFloor;
                    isOnFirstFloor = false;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.TryGetComponent<StairPoint>(out StairPoint stairPoint))
            {
                _currentStairPoint = null;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E) && _currentStairPoint != null)
            {
                if (isOnFirstFloor)
                {
                    transform.position = _secondFloor.transform.position;
                    IsOnFirstFloor = false;
                    IsOnSecondFloor = true;
                }
                else
                {
                    transform.position = _firstFloor.transform.position;
                    IsOnFirstFloor = true;
                    IsOnSecondFloor = false;
                }
            }
        }
    }
}

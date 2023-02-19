using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Model
{
    public class GameState1 : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public static void EndGame()
        {
            SceneManager.LoadScene(3);
        }

        public void BadEndGame(string name)
        {
            switch (name)
            {
                case "Electricity":
                    KillByElecticity();
                    break;
                case "Knife":
                    //KillByKnife();
                    break;
                case "Window":
                    //DoSuicideAroundWindow();
                    break;


            }
        }

        public void KillByElecticity()
        {
            SceneManager.LoadScene(2);
        }


    }
}

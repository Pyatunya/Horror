using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherToEndGame : MonoBehaviour
{
    public void LoadBadEndgameElectricity()
    { 
        SceneManager.LoadScene(2);
    }
}

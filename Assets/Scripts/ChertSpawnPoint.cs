using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChertSpawnPoint : MonoBehaviour
{
    [SerializeField] private Chert _chert;
    
    void Start()
    {
        StartCoroutine(SpawnChert());
    }

    public IEnumerator SpawnChert()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(7);
            Instantiate(_chert);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject pumpkin;
    [SerializeField] private int numToSpawn; //number of pumpkins to spawn

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i  < numToSpawn; i++)
        {
            
        Instantiate(pumpkin, new Vector3(Random.Range(-5.0f,5.0f),0,0)
                ,Quaternion.identity);

        }
    }

    
}

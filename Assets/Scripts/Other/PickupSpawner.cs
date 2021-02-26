using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public Transform[] spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Spawn");
        Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnPoint[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] objects;
    int randomSpawnPoint, randomObject;
    public static bool spawnAllowed;


    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnObject", 0f, 1f);
        
    }

    void SpawnObject ()

    {
        if(spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, SpawnPoints.Length);
            randomObject = Random.Range(0, objects.Length);
            Instantiate(objects[randomObject], SpawnPoints[randomSpawnPoint].position, Quaternion.identity);

        }
    }
}

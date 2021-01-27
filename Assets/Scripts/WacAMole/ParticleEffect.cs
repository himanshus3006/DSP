using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
     public float destroyTime = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy particle effect after it plays
        Destroy(gameObject, destroyTime);
    }

   
}

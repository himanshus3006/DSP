using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "ball")
        {
            ScoreChecked.AddScore(100);
            SceneManager.LoadScene(2);
        }
    }
}

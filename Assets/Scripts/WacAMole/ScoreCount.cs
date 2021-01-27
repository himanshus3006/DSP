using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreCount : MonoBehaviour
{
    //Config
    public static int score;

    // adds score and updates it
    public static void AddScore (int value)
    {
        score += value;
        Debug.Log("Current Score " + score);
        UI_M.UIinstance.UpdateUI();
    }

    public static int ReadScore()
    {
        return score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

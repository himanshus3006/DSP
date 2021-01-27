using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    //Config
    public static int score;

    // adds score and updates it
    public static void AddScore(int value)
    {
        score += value;
        Debug.Log("Current Score " + score);
        UIManager.UIinstance.UpdateUI();
    }

    public static int ReadScore()
    {
        return score;
    }

}

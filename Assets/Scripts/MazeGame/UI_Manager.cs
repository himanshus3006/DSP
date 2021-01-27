using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Manager : MonoBehaviour
{
    public static UI_Manager UIinstance;
    public Text scoreText;
    public Text timerText;


    // Start is called before the first frame update
    void Awake()
    {
        UIinstance = this;
        UpdateUI();
        UpdateTimer(1, 0);
    }

    // Display timer 
    public void UpdateTimer(int minutes, int seconds)
    {
        timerText.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
    }

    // Display score
    public void UpdateUI()
    {
        scoreText.text = "Score :" + ScoreCount.ReadScore();
    }

}

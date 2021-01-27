using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class MUIManager : MonoBehaviour
{

     public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score :" + ScoreHolder.score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore (int score)
    {
        scoreText.text = score.ToString();
    }
}

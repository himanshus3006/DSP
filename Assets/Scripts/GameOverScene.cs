using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "The Score is :" + ScoreHolder.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

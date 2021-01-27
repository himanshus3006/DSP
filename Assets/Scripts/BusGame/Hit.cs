using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int score = ScoreHolder.score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "drone")
        {
            ScoreCount.AddScore(score);
            Destroy(gameObject);
        }
    }
}

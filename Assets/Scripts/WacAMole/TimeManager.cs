using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    //Config
    public int playTime = 60;
    int seconds; 
    int minutes;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("PlayTimer");
    }

    // Update play time every second and game end condition
    IEnumerator PlayTimer()
    {
        while(playTime >0)
        {
            yield return new WaitForSeconds(1);
            playTime--;
            seconds = playTime % 60; // cap seconds to not execede play time
            minutes = playTime / 60 % 60;//cap minutes to not execede play time
            UIManager.UIinstance.UpdateTimer(minutes,seconds);

        }
        Debug.Log("Timer Has Ended");
       SceneManager.LoadScene(2);
    }
 
}

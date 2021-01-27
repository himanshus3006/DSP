using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void LoadWalk()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadBus()
    {
        SceneManager.LoadScene(5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
 
  public void LoadCanvasScene()
    {
        StartCoroutine("SceneLoad");
    }

   IEnumerator SceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}

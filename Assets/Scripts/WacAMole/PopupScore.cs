using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScore : MonoBehaviour
{
    //Config
    public Text popupScore;
    Animator myAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponentInChildren<Animator>();
        AnimatorClipInfo[] info = myAnimator.GetCurrentAnimatorClipInfo(0); // stores the first animation clip information from the animator
        Destroy(gameObject,info[0].clip.length); // destroy text after the clip has played
    }

 // To display Score value
public void ShowText(int  value )
    {
    popupScore.text = (value > 0 ) ? " + " +  value : value.ToString(); 
    }
}

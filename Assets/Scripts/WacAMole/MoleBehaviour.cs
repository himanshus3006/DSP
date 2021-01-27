using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    //Config
    Collider myCollider;
    [HideInInspector] public Animator myAnimation;
    [HideInInspector] public GameObject hole;
    public GameObject popupScore;

    public int hitPoints = 1;
    public int score = 1;

    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GetComponent<Animator>();
        myCollider = GetComponent<Collider>();
        myCollider.enabled = false; // To let the mole come up a bit before allowing a hit on it 
    }

    // Switches on collider after a few frames of animation
   public void ColliderStatus(int status)
    {
        if (status == 0)
        {
            myCollider.enabled = false;
        }
        else
        {
            myCollider.enabled = true;
        }
    }

    //Destroy Mole
    public void Destroy()
    {
        hole.GetComponent<MoleSpawner>().moleExist = false;
        Destroy(gameObject);
    }

    // Keeps track if the mole can be hit again or not
    public void WhenHit()
    {
        hitPoints--;

        if (hitPoints > 0)
        {
            myCollider.enabled = true;
        }
        else
        {
            // add score when hit
            hole.GetComponent<MoleSpawner>().moleExist = false;
            ScoreCount.AddScore(score);
            
            // generate popup score and display it
            GameObject popupText = Instantiate(popupScore) as GameObject; 
            popupText.transform.SetParent(UIManager.UIinstance.transform,false); // set parent as UI canvas
            popupText.transform.position = Camera.main.WorldToScreenPoint(transform.position);

     
            PopupScore popText = popupText.GetComponent<PopupScore>();
            popText.ShowText(score);

            Destroy(gameObject);
        }
    }
}

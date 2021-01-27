using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Player : MonoBehaviour
{
    public GameObject fx_particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Touch input from user 
        if (Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began) 
        {
            // Cast ray from point of contact on screen 
           Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            // Check if ray hit game object mole
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Mole")
                {
                    Instantiate(fx_particle, hit.point,Quaternion.identity); // instantiate particle effect on hit

                    //play animation if hit is success
                    MoleBehaviour mole = hit.collider.gameObject.GetComponent<MoleBehaviour>(); 
                    mole.ColliderStatus(0);
                    mole.myAnimation.SetTrigger("Hit");
                }
            }
            
        }

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    // Config
    public GameObject[] moles;
    public bool moleExist;


    // Start is called before the first frame update
    void Start()
    {
        if (!moleExist)
        {
            Invoke("Spawn", Random.Range(3f, 7f)); // Calls Spawn() 
        }
    }

    // Spawn Mole with type 
    public void Spawn()
    {
        if (!moleExist)
        {
            int rarity = CalclulateRarity(); // get which mole to spawn
            GameObject mole = Instantiate(moles[rarity], transform.position, Quaternion.identity) as GameObject; // Creates the chosen mole as a game object
            mole.GetComponent<MoleBehaviour>().hole = this.gameObject; // Assigning hole through code 
            moleExist = true;
        }
        Invoke("Spawn", Random.Range(3f, 7f)); // Calls Spawn() again 
    }

    // calculate chance to spawn different moles
    int CalclulateRarity()
    {
        int randomMoleSpawn = Random.Range(0, 101);

        // 1% chance
        if (randomMoleSpawn <= 1)
        {
            return 4;
        }
        //5% chance
        else if (randomMoleSpawn <= 5)
        {
            return 3;
        }

        //20% chance
        else if (randomMoleSpawn <= 20)
        {
            return 2;
        }

        //50% chance
        else if (randomMoleSpawn <= 50)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionAttack : MonoBehaviour
{
    public Transform spawnPoint;


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name=="Player")
        {

            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            col.transform.position = spawnPoint.position;
           
        }

       
        
    }
}

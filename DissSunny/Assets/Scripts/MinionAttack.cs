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
            
            col.transform.position = spawnPoint.position;
            //Destroy(col.gameObject);
        }

       
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >=2 )
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }

    
}

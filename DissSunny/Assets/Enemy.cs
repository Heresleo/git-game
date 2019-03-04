using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject poof;

    public void Die()
    {
        Instantiate(poof, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public int LevelToLoad;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}

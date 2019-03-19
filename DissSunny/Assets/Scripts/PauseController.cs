using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PauseMenu;
    
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
    }
}

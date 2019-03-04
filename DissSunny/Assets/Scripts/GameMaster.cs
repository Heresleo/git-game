using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public int points;

    public Text pointText;

    void Update()
    {
        pointText.text = ("Points: " + points);
    }
}

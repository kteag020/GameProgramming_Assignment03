using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    string playerName = NameTransfer.theName;
    int playerScore = Score.PinCount;
    public GameObject displayText;
   


    public void Start()
    {
        displayText.GetComponent<Text>().text = "Final Score: " + playerScore;
        
    }
}

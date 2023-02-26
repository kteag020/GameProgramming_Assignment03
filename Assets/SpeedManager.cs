using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedManager : MonoBehaviour
{
    public static float Speed;
    public Slider ChangeSpeed;
    public Text ShowSpeed;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void AdjustSpeed()
    {
        Speed = ChangeSpeed.value;
        ShowSpeed.text = "Pin Speed: " + Speed.ToString();
    }
}

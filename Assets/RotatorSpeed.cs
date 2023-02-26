using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorSpeed : MonoBehaviour
{
    public static float RotateSpeed;
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
        RotateSpeed = ChangeSpeed.value;
        ShowSpeed.text = "Rotator Speed: " + RotateSpeed.ToString();
    }
}

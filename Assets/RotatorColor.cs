using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColor : MonoBehaviour
{
    public static Dropdown RotateColor;

    public Text ColorText;
    public GameObject Rotator;

    
    void Start()
    {
        Rotator.GetComponent<Renderer>().material.color = Color.black;
    }

    
    void Update()
    {

    }
    public void ChooseColor() 
    {
        switch (RotateColor.value)
        {

            default:
                ColorText.text = RotateColor.options[0].text;
                Rotator.GetComponent<Renderer>().material.color = Color.black;
                break;
            case 1:
                ColorText.text = RotateColor.options[1].text;
                Rotator.GetComponent<Renderer>().material.color = Color.blue;
                break;
           case 2:
                ColorText.text = RotateColor.options[2].text;
                Rotator.GetComponent<Renderer>().material.color = Color.red;
                break;

        }
    }
}

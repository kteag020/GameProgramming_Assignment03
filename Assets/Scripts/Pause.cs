using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pause : MonoBehaviour
{
    public Text timeText;
    public Button resumeButton;
    private bool isPaused = false;


   
    void Start() 
    {
       
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        if (!isPaused) 
        {
            
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        
        
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1;
        isPaused = false;
        
       
    }
}

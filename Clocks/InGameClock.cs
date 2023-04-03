using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InGameClock : MonoBehaviour
{
    public Text clockText;

    private float timer = 0.0f;
    private bool isTimer = false;


    void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }
     
    }

    void DisplayTime()
    {
        isTimer = true;
        int minutes = Mathf.FloorToInt(timer / 60.0f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        clockText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void startTimer()
    {
        isTimer = true;
    }

    public void stopTimer()
    {
        isTimer = false;
    }

    public void ResetTimer()
    {
        timer = 0.0f;
    }
}

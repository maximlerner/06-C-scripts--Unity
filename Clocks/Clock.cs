using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour
{
    public Text clockText;

    private void Awake()
    {
        clockText = GetComponent<Text>();
    }

    private void Update()
    {
        DateTime time = DateTime.Now;
        string hours = LeadingZero(time.Hour);
        string minutes = LeadingZero(time.Minute);
        string seconds = LeadingZero(time.Second);

        clockText.text = hours + ":" + minutes + ":" + seconds;
    }

    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }

}

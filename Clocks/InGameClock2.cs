using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InGameClock2 : MonoBehaviour
{
    public Text clockText;
    public GameObject sun;
    private float speed = 60f;
    public int day = 0;

    //private float timer = 35400f;
    public float timer = 0.0f;


    void Update()
    {
        if (timer > 86400)
        {
            timer -= 86400f;
            day += 1;
        }
        timer += Time.deltaTime * speed;
        DisplayTime();
    }

    void DisplayTime()
    {
        int hours = Mathf.FloorToInt(timer / (60.0f * 60.0f));
        int minutes = Mathf.FloorToInt(timer / 60.0f -hours * 60);
        int seconds = Mathf.FloorToInt(timer - minutes * 60 -hours * 60.0f * 60.0f);
        clockText.text = string.Format("{0:00}:{1:00}:{2:00}",hours, minutes, seconds);

        sun.transform.localEulerAngles = new Vector3(hours, 0, 0 / 24.0f * -360.0f);
    }

}

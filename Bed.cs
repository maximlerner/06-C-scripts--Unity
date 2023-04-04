using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour
{
    public float theDistance;
    public GameObject actionText;
    public GameObject sleepBar;

    void Update()
    {
        theDistance = PlayerCasting.DistanceFromTarget;
        
    }

    [System.Obsolete]
    void OnMouseOver()
    {
        if (theDistance <= 3f)
        {
            Screen.lockCursor = false;
            Cursor.visible = false;
            actionText.SetActive(true);
            actionText.GetComponent<Text>().text = "Sleep";
            if (Input.GetButtonDown("Fire1"))
            {
               Cursor.visible = true;
               actionText.SetActive(false);
               sleepBar.SetActive(true);
            }
        }     
    }

    [System.Obsolete]
    void OnMouseExit()
    {
        Screen.lockCursor = false;
        Cursor.visible = false;
        actionText.SetActive(false);
        sleepBar.SetActive(false);

    }
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandonNum : MonoBehaviour
{
    public GameObject TextBox;
    public int TheNumber;
    void Start()
    {
        
    }

    public void RandomGenerate ()
    {
        TheNumber = Random.Range(1, 100);
        TextBox.GetComponent<Text>().text = "" + TheNumber;
    }
}

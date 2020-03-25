using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainScriptForUE : MonoBehaviour
{
    public UnityEvent boxChange;
    public Text text;

    private int counter = 3;
    
    void FixedUpdate()
    {
        if (counter - (int)Time.fixedTime > 0)
        {
            text.text = (counter - (int)Time.fixedTime).ToString();
        }
        else
        {
            text.text = "GO!";
            boxChange.Invoke();
        }
    }
}

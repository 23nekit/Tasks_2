using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainScriptForUE : MonoBehaviour
{
    public UnityEvent BoxChange;
    public Text TextBox;

    private int Counter = 3;
    
    void Update()
    {
        if (Counter - (int)Time.fixedTime > 0)
        {
            TextBox.text = (Counter - (int)Time.fixedTime).ToString();
        }
        else
        {
            TextBox.text = "GO!";
            BoxChange.Invoke();
        }
    }
}

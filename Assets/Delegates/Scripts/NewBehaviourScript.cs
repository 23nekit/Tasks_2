using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    delegate void MyDelegate();
    // Start is called before the first frame update
    void Start()
    {
        MyDelegate OneToConsole = DebugOne;
        OneToConsole();
        Action TwoToConsole = DebugTwo;
        TwoToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DebugOne()
    {
        Debug.Log("1");
    }
    void DebugTwo()
    {
        Debug.Log("2");
    }
}

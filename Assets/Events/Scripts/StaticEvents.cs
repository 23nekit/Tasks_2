using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEvents : MonoBehaviour
{
    public static event Action StaticEvent = delegate { };
    public void PressButton()
    {
        StaticEvent += WriteToConsoleHi;//подписаться на событие
        StaticEvent.Invoke();
        StaticEvent -= WriteToConsoleHi;//отписаться от события
    }
    public void PressButton2()
    {
        StaticEvent += WriteToConsoleHi;
        StaticEvent.Invoke();
        StaticEvent += WriteToConsoleHi;
        StaticEvent.Invoke();
    }
    void WriteToConsoleHi()
    {
        Debug.Log("Hi");
    }
}

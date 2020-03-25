using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartEvents : MonoBehaviour
{
    public event Action StandartEvent = delegate { };
    public void PressButton()
    {
        StandartEvent += WriteToConsoleHello;//подписаться на событие
        StandartEvent.Invoke();
        StandartEvent -= WriteToConsoleHello;//отписаться от события
    }
    public void PressButton2()
    {
        StandartEvent += WriteToConsoleHello;
        StandartEvent.Invoke();
        StandartEvent += WriteToConsoleHello;
        StandartEvent.Invoke();
    }
    void WriteToConsoleHello()
    {
        Debug.Log("Hello");
    }
}

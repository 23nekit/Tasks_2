using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEvents : MonoBehaviour
{
    public void PressButtonAdd()
    {
        EventsCreate.StaticEvent += WriteToConsoleHi;//подписаться на событие
    }

    public void PressButtonRemove()
    {
        EventsCreate.StaticEvent -= WriteToConsoleHi;//отписаться от события
    }

    private void WriteToConsoleHi()
    {
        Debug.Log("Hi");
    }
}

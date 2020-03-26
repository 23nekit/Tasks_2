using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsCreate : MonoBehaviour
{
    public event Action StandartEvent = delegate { };
    public static event Action StaticEvent = delegate { };

    public void InvokeOnButton()
    {
        StaticEvent.Invoke();
        StandartEvent = StandartEvents.ForStandartEvent.StandartEvent;
        StandartEvent.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartEvents : MonoBehaviour
{
    public static EventsCreate ForStandartEvent = new EventsCreate();

    public void PlusOnButton()
    {
        ForStandartEvent.StandartEvent += WriteHello;
    }

    public void MinusOnButton()
    {
        ForStandartEvent.StandartEvent -= WriteHello;
    }

    public void WriteHello()
    {
        Debug.Log("Hello");
    }
}

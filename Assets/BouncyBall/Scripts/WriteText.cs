using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteText : MonoBehaviour
{
    public Text TextObject;

    private void Update()
    {
        TextObject.text = "CounterOfBounce: " + ContactWithFloor.CounterOfBounce + " CounterOfTochingPlane: " + ContactWithPlane.CounterOfCollisionWithPlane + " DistanceToFloor: " + Distance.DistanceToFloor;
    }
}

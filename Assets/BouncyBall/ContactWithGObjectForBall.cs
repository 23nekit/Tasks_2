using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactWithGObjectForBall : MonoBehaviour
{
    public GameObject floor;
    public GameObject StaticObject;
    public Text TextObject;

    private int CounterOfBounce;
    private int CounterOfCollisionWithPlane;
    private float DistanceToFloor;

    private void OnCollisionEnter(Collision collision)
    {
        AddOneToBounceCounter();
    }
    private void AddOneToBounceCounter()
    {
        CounterOfBounce += 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        AddOneToPlaneCounter();
    }
    private void AddOneToPlaneCounter()
    {
        CounterOfCollisionWithPlane += 1;
    }
    
    void FixedUpdate()
    {
        DistanceToFloor = transform.position.y - floor.transform.position.y;
        EditTextInTextObject();
    }
    private void EditTextInTextObject()
    {
        TextObject.text = "CounterOfBounce: " + CounterOfBounce + " CounterOfTochingPlane: " + CounterOfCollisionWithPlane + " DistanceToFloor: "+ DistanceToFloor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ContactWithPlane : MonoBehaviour
{
    public static int CounterOfCollisionWithPlane;
    private void OnTriggerEnter(Collider other)
    {
        CounterOfCollisionWithPlane += 1;
    }
}

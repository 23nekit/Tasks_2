using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactWithFloor : MonoBehaviour
{
    public static int CounterOfBounce;

    private void OnCollisionEnter(Collision collision)
    {
        CounterOfBounce += 1;
    }
}

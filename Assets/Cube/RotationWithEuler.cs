using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationWithEuler : MonoBehaviour
{
    public float RPM = 0;
    private int CounterForFixedUpdates = 0;
    private static float FullRotateAngle = 360;
    private static float FixedUpdatesPerSecond = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, FullRotateAngle / FixedUpdatesPerSecond);
        Debug.Log(RPM);
        CounterForFixedUpdates += 1;
        if (CounterForFixedUpdates == FixedUpdatesPerSecond)
        {
            RPM += 1;
            CounterForFixedUpdates = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Floor;
    public static float DistanceToFloor;
    private void Update()
    {
        DistanceToFloor = Ball.transform.position.y - Floor.transform.position.y;
    }
}

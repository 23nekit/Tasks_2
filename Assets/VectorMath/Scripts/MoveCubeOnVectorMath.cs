using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeOnVectorMath : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position+=Vector3.Normalize(new Vector3(1, 2, 3));
    }
}

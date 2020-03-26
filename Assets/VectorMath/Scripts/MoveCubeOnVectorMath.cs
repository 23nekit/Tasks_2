using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeOnVectorMath : MonoBehaviour
{
    void Update()
    {
        transform.position+=Vector3.Normalize(new Vector3(1, 2, 3));
    }
}

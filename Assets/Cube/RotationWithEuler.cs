using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationWithEuler : MonoBehaviour
{
    public Text TextForSeconds;
    public Vector3 RotationAxis = Vector3.up;

    private static float FullRotateAngle = 360;
    
    private void Update()
    {
        transform.Rotate(RotationAxis, FullRotateAngle*Time.deltaTime);
        TextForSeconds.text = "Time from start: " + (int)Time.time;
    }
}

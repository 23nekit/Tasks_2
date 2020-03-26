using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text TextForSeconds;
    public Vector3 RotationAxis = Vector3.up;
    public float RotationAngle = FullRotateAngle / FixedUpdatesPerSecond;

    private static float FullRotateAngle = 360;
    private static float FixedUpdatesPerSecond = 50;
    private Quaternion qt;

    private void Start()
    {
        qt = Quaternion.AngleAxis(RotationAngle, RotationAxis);
    }

    private void FixedUpdate()
    {
        transform.rotation *= qt;
        TextUpdate();
    }

    private void TextUpdate()
    {
        TextForSeconds.text = "Time from start: " + (int)Time.time;
    }
}

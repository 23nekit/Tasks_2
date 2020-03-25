using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public Text textForSeconds;

    private float RotationAngle = FullRotateAngle / FixedUpdatesPerSecond;
    private static float FullRotateAngle = 360;
    private static float FixedUpdatesPerSecond = 50;
    private Quaternion qt;

    void Start()
    {
        qt = Quaternion.AngleAxis(RotationAngle, Vector3.up);
    }

    void FixedUpdate()
    {
        transform.rotation *= qt;
        TextUpdate();
    }
    private void TextUpdate()
    {
        textForSeconds.text = "Time from start: " + (int)Time.time;
    }
}

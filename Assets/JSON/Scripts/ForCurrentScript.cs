using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ForCurrentScript : MonoBehaviour
{
    public Text current;

    public void WriteCurrentInTextFromJson()
    {
        try
        {
            string json = File.ReadAllText(Application.dataPath + "Number.json");
            NumberForJson number=JsonUtility.FromJson<NumberForJson>(json);
            current.text = "Current Number:" + number.Current;
        }
        catch(System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}

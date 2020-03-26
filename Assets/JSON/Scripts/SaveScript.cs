using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class SaveScript : MonoBehaviour
{
    public InputField InputBox;

    public void SaveScriptInJSON()
    {
        NumberForJson number = new NumberForJson();
        number.Current = int.Parse(InputBox.text);
        string json = JsonUtility.ToJson(number);
        File.WriteAllText(Application.dataPath + "Number.json", json);
        
    }
}

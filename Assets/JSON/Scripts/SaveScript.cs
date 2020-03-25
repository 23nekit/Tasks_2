using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class SaveScript : MonoBehaviour
{
    public Text Current;
    public InputField input;

    public void SaveScriptInJSON()
    {
        NumberForJson pl = new NumberForJson();
        pl.Curent = int.Parse(input.text);
        string json = JsonUtility.ToJson(pl);
        File.WriteAllText(Application.dataPath + "Number.json", json);
        
    }
}

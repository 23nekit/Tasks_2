﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ForCurrentScript : MonoBehaviour
{
    public int Number;
    public Text current;
    void Update()
    {
        try
        {
            string json = File.ReadAllText(Application.dataPath + "Number.json");
            NumberForJson number=JsonUtility.FromJson<NumberForJson>(json);
            current.text = "Current Number:" + number.Curent;
        }
        catch(System.Exception e)
        {

        }
    }
}

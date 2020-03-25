using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ShowButtonScript : MonoBehaviour
{
    public void ShowNickname()
    {
        if (PlayerPrefs.HasKey("Nickname"))
        {
            EditorUtility.DisplayDialog("Nickname", "You nickname: " + PlayerPrefs.GetString("Nickname"),"OK");
        }
        else
        {
            EditorUtility.DisplayDialog("Error", "You don`t have nickname", "OK");
        }
    }
}

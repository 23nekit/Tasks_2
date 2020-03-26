using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeleteButtonScript : MonoBehaviour
{
    public void DeleteNickname()
    {
        if (PlayerPrefs.HasKey("Nickname"))
        {
            AnswerForDeleteAndDoItWhenSure();
        }
        else
        {
            EditorUtility.DisplayDialog("Error", "You don`t have nickname", "OK");
        }
    }

    private void AnswerForDeleteAndDoItWhenSure()
    {
        if(EditorUtility.DisplayDialog("Question", "Are You Sure", "Yes", "No"))
        {
            PlayerPrefs.DeleteKey("Nickname");
        }
    }
}

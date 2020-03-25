using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class SaveButtonScript : MonoBehaviour
{
    public InputField input;

    public void SaveNicknameInPlayerPrefs()
    {
        if (PlayerPrefs.HasKey("Nickname"))
        {
            if (isReplaceNickname())
            {
                SetNickname();
            }
        }
        else
        {
            SetNickname();
        }
    }
    private bool isReplaceNickname()
    {
        return EditorUtility.DisplayDialog("Question", "Replace Nickname ?", "Yes", "No");
    }
    private void SetNickname()
    {
        PlayerPrefs.SetString("Nickname", input.text);
    }
}

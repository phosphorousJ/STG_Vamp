using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_StorySelectBase : MonoBehaviour
{
    private bool stageSelectPush = false;


    public void PushStageSelect()
    {
        if (!stageSelectPush)
        {
            stageSelectPush = true;

            SceneManager.LoadScene("MenuScene");
        }
    }
}

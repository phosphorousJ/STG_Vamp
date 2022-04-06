using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_AvoidanceTurn : MonoBehaviour
{
    private bool returnPush = false;
    private bool tutorialPush = false;


    public void PushReturn()
    {
        if (!returnPush)
        {
            returnPush = true;

            SceneManager.LoadScene("HowToPlayScene");
        }
    }


    public void PushTutorial()
    {
        if (!tutorialPush)
        {
            tutorialPush = true;

            SceneManager.LoadScene("GameSubSceneT");
        }
    }
}

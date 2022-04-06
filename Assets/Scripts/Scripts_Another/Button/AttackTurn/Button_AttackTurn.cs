using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_AttackTurn : MonoBehaviour
{
    private bool lamiaPush = false;
    private bool returnPush = false;
    private bool tutorialPush = false;


    public void PushLamia()
    {
        if (!lamiaPush)
        {
            lamiaPush = true;

            SceneManager.LoadScene("CharacterPScene");
        }
    }


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

            SceneManager.LoadScene("GameSceneT");
        }
    }
}

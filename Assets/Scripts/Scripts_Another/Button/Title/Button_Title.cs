using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Title : MonoBehaviour
{
    private bool playStartPush = false;
    private bool howToPlayPush = false;


    public void PushPlayStart()
    {
        if (!playStartPush)
        {
            playStartPush = true;

            SceneManager.LoadScene("LevelSelectScene");
        }
    }


    public void PushHowToPlay()
    {
        if (!howToPlayPush)
        {
            howToPlayPush = true;

            SceneManager.LoadScene("HowToPlayScene");
        }
    }
}

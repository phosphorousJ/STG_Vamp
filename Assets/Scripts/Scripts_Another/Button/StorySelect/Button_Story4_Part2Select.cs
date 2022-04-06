using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Story4_Part2Select : Button_StorySelectBase
{
    private bool story5Push = false;
    private bool story6Push = false;
    private bool returnPush = false;


    public void PushStory5()
    {
        if (!story5Push)
        {
            story5Push = true;

            SceneManager.LoadScene("TalkScene4_7");
        }
    }


    public void PushStory6()
    {
        if (!story6Push)
        {
            story6Push = true;

            SceneManager.LoadScene("TalkScene4_10");
        }
    }


    public void PushReturn()
    {
        if (!returnPush)
        {
            returnPush = true;

            SceneManager.LoadScene("Story4_0Scene");
        }
    }
}

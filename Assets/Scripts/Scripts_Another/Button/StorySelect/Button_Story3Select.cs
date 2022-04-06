using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Story3Select : Button_StorySelectBase
{
    private bool story1Push = false;
    private bool story2Push = false;
    private bool story3Push = false;


    public void PushStory1()
    {
        if (!story1Push)
        {
            story1Push = true;

            SceneManager.LoadScene("TalkScene3_0");
        }
    }


    public void PushStory2()
    {
        if (!story2Push)
        {
            story2Push = true;

            SceneManager.LoadScene("GameStartScene3");
        }
    }


    public void PushStory3()
    {
        if (!story3Push)
        {
            story3Push = true;

            SceneManager.LoadScene("TalkScene3_11");
        }
    }
}

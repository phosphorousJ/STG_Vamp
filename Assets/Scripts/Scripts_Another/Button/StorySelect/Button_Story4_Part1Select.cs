using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Story4_Part1Select : Button_StorySelectBase
{
    private bool story1Push = false;
    private bool story2Push = false;
    private bool story3Push = false;
    private bool story4Push = false;
    private bool story4_Part2Push = false;


    public void PushStory1()
    {
        if (!story1Push)
        {
            story1Push = true;

            SceneManager.LoadScene("TalkScene4_0");
        }
    }


    public void PushStory2()
    {
        if (!story2Push)
        {
            story2Push = true;

            SceneManager.LoadScene("GameStartScene4");
        }
    }


    public void PushStory3()
    {
        if (!story3Push)
        {
            story3Push = true;

            SceneManager.LoadScene("TalkScene4_4");
        }
    }


    public void PushStory4()
    {
        if (!story4Push)
        {
            story4Push = true;

            SceneManager.LoadScene("TalkScene4_6");
        }
    }


    public void PushStory4_Part2()
    {
        if (!story4_Part2Push)
        {
            story4_Part2Push = true;

            SceneManager.LoadScene("Story4_1Scene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story0_3 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameStartScene0_1_1");
        }
    }
}

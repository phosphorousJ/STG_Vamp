using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story0_1 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameScene0_0");
        }
    }
}

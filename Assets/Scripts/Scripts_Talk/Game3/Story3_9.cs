using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story3_9 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameScene3_4");
        }
    }
}

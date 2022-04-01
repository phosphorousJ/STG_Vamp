using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_4 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("GameStartScene3_3", 1.0f);
        }
    }
}

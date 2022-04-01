using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_6 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("GameStartScene3_4", 1.0f);
        }
    }
}

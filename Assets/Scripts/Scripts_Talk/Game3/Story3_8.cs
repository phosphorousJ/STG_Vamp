using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_8 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("TalkScene3_9", 1.0f);
        }
    }
}

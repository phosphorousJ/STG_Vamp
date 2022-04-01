using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story2_6 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story2Scene", 2.0f);
        }
    }
}

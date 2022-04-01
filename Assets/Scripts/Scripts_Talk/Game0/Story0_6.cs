using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story0_6 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story0Scene", 2.0f);
        }
    }
}

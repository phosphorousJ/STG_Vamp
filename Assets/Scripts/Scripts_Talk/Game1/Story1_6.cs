using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1_6 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage1;


    public override void Update()
    {
        base.Update();

        if (15 <= talkCount)
        {
            //PersonImage1の向きを変える
            personImage1.transform.localScale = new Vector3(-1, 1, 1);
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story1Scene", 2.0f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_11 : StoryBase
{
    //BackGround1を入れる
    public GameObject backGround1;


    public override void Start()
    {
        base.Start();

        //BackGround1を非表示にする
        backGround1.SetActive(false);
    }


    public override void Update()
    {
        base.Update();

        if (5 <= talkCount)
        {
            //BackGround1を表示
            backGround1.SetActive(true);
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story3Scene", 2.0f);
        }
    }
}

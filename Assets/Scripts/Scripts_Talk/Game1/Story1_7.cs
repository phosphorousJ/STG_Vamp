using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1_7 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;


    public override void Start()
    {
        base.Start();

        //personImage0を非表示にする
        personImage0.GetComponent<Image>().enabled = false;

        //personImage1を非表示にする
        personImage1.GetComponent<Image>().enabled = false;
    }


    public override void Update()
    {
        base.Update();

        if (2 <= talkCount)
        {
            //personImage0を表示
            personImage0.GetComponent<Image>().enabled = true;

            //personImage1を表示
            personImage1.GetComponent<Image>().enabled = true;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_7 : StoryBase
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

        switch (talkCount)
        {
            case 2:
                //personImage0を表示
                personImage0.GetComponent<Image>().enabled = true;
                break;

            case 3:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;

            case 5:
                //personImage0の位置を変える
                RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
                person0Pos.localPosition = new Vector3(-100, -20, 0);
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("TalkScene4_8", 2.0f);
        }
    }
}

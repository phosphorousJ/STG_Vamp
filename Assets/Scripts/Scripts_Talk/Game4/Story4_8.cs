using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_8 : StoryBase
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
            case 8:
                //personImage0を表示
                personImage0.GetComponent<Image>().enabled = true;
                break;

            case 9:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;

            case 12:
                //personImage1を非表示にする
                personImage1.GetComponent<Image>().enabled = false;
                break;

            case 13:
                //personImage0の向きを変える
                personImage0.transform.localScale = new Vector3(-1, 1, 1);
                break;

            case 24:
                //personImage0を非表示にする
                personImage0.GetComponent<Image>().enabled = false;
                break;

            case 26:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("TalkScene4_9", 2.0f);
        }
    }
}

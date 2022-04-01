using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_10 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;
    public GameObject personImage2;

    //PersonSpriteを入れる
    public Sprite personSpriteGC;
    public Sprite personSpriteMC;


    public override void Start()
    {
        base.Start();

        //personImage0を非表示にする
        personImage0.GetComponent<Image>().enabled = false;

        //personImage1を非表示にする
        personImage1.GetComponent<Image>().enabled = false;

        //personImage2を非表示にする
        personImage2.GetComponent<Image>().enabled = false;
    }


    public override void Update()
    {
        base.Update();

        switch (talkCount)
        {
            case 2:
                //personImage0を表示
                personImage0.GetComponent<Image>().enabled = true;

                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;

                //personImage2を表示
                personImage2.GetComponent<Image>().enabled = true;
                break;

            case 30:
                //personImage1のSpriteを変更する
                personImage1.GetComponent<Image>().sprite = personSpriteMC;
                break;

            case 31:
                //personImage1のSpriteを変更する
                personImage1.GetComponent<Image>().sprite = personSpriteGC;
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("TalkScene4_11", 2.0f);
        }
    }
}

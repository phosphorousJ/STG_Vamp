using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_9 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;
    public GameObject personImage2;

    //PersonSpriteを入れる
    public Sprite personSpriteTT;
    public Sprite personSpriteGC;


    //BackGroundを入れる
    public GameObject backGround0;
    public GameObject backGround1;


    public override void Start()
    {
        base.Start();

        //personImage1を非表示にする
        personImage1.GetComponent<Image>().enabled = false;

        //personImage2を非表示にする
        personImage2.GetComponent<Image>().enabled = false;

        //BackGround0を非表示にする
        backGround0.SetActive(false);

        //BackGround1を非表示にする
        backGround1.SetActive(false);
    }

    public override void Update()
    {
        base.Update();

        switch (talkCount)
        {
            case 4:
                //personImage0を非表示にする
                personImage0.GetComponent<Image>().enabled = false;

                //BackGround0を表示
                backGround0.SetActive(true);
                break;

            case 5:
                //personImage0を表示
                personImage0.GetComponent<Image>().enabled = true;
                break;

            case 11:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;

            case 12:
                //personImage2を表示
                personImage2.GetComponent<Image>().enabled = true;
                break;

            case 27:
                //personImage0のSpriteを変更する
                personImage0.GetComponent<Image>().sprite = personSpriteTT;

                //personImage1のSpriteを変更する
                personImage1.GetComponent<Image>().sprite = personSpriteGC;

                //personImage2のSpriteを変更する
                personImage2.GetComponent<Image>().sprite = personSpriteGC;

                //BackGround1を表示
                backGround1.SetActive(true);
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story4_1Scene", 2.0f);
        }
    }
}

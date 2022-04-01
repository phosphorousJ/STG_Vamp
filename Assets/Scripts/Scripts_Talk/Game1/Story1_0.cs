using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1_0 : StoryBase
{
    //PersonImage0を入れる
    public GameObject personImage0;
    public GameObject personImage1;
    public GameObject personImage2;

    //FlashGroundを入れる
    public GameObject flashGround;


    public override void Start()
    {
        base.Start();

        //personImage0を非表示にする
        personImage0.GetComponent<Image>().enabled = false;

        //personImage1を非表示にする
        personImage1.GetComponent<Image>().enabled = false;

        //personImage2を非表示にする
        personImage2.GetComponent<Image>().enabled = false;

        //flashGroundの色を非表示にする
        flashGround.GetComponent<Image>().color = Color.clear;
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

            case 5:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;

            case 28:
                //personImage2を表示
                personImage2.GetComponent<Image>().enabled = true;
                break;

            case 29:
                //personImage1の向きを変える
                personImage1.transform.localScale = new Vector3(1, 1, 1);
                break;
        }

        if (24 <= talkCount && talkCount <= 33)
        {
            //personImage0の向きを変える
            personImage0.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            //personImage0の向きを変える
            personImage0.transform.localScale = new Vector3(1, 1, 1);
        }

        //画面をフラッシュさせる
        if (talkCount == 35 && Input.GetMouseButtonDown(0))
        {
            flashGround.GetComponent<Image>().color = Color.red;
        }
        else
        {
            flashGround.GetComponent<Image>().color = Color.Lerp(flashGround.GetComponent<Image>().color, Color.clear, Time.deltaTime);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story2_1 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;


    //BackGroundを入れる
    public GameObject backGround;


    public override void Start()
    {
        base.Start();

        //personImage0の初期位置
        RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
        person0Pos.localPosition = new Vector3(0, -20, 0);

        //personImage1を非表示にする
        personImage1.GetComponent<Image>().enabled = false;
    }


    public override void Update()
    {
        base.Update();

        switch (talkCount)
        {
            case 4:
                //BackGroundを非表示にする
                backGround.SetActive(false);

                //personImage0を非表示にする
                personImage0.GetComponent<Image>().enabled = false;
                break;

            case 5:
                //personImage0を表示
                personImage0.GetComponent<Image>().enabled = true;
                break;

            case 8:
                //personImage0の位置を変える
                RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
                person0Pos.localPosition = new Vector3(235, -20, 0);

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
           SceneManager.LoadScene("GameScene2_0");
        }
    }
}

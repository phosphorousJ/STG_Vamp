using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story4_0 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;
    public GameObject personImage2;


    public override void Start()
    {
        base.Start();

        //personImage0の初期位置
        RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
        person0Pos.localPosition = new Vector3(0, -20, 0);

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
                break;

            case 4:
                //personImage1を表示
                personImage1.GetComponent<Image>().enabled = true;
                break;

            case 6:
                //personImage2を表示
                personImage2.GetComponent<Image>().enabled = true;
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameScene4_0");
        }
    }
}

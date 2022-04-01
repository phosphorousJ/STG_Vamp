using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story2_3 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage1;


    public override void Update()
    {
        base.Update();

        if (8 <= talkCount)
        {
            //personImage1を非表示にする
            personImage1.GetComponent<Image>().enabled = false;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameStartScene2_1");
        }
    }
}

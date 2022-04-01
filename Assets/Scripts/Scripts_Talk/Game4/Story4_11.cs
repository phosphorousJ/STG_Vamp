using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_11 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage;


    public override void Start()
    {
        base.Start();

        //personImageを非表示にする
        personImage.GetComponent<Image>().enabled = false;
    }


    public override void Update()
    {
        base.Update();

        if (2 <= talkCount)
        {
            //personImageを表示
            personImage.GetComponent<Image>().enabled = true;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("GameEndScene", 2.0f);
        }
    }
}

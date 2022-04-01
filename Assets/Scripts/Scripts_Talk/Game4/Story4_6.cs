using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_6 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage2;

    //BackGroundを入れる
    public GameObject backGround;

    //BackGroundSpriteCRUを入れる
    public Sprite backGroundSpriteCRU;


    // Update is called once per frame
    public override void Update()
    {
        base.Update();

        switch (talkCount)
        {
            case 53:
                //personImage2の位置を変更
                RectTransform person2Pos = personImage2.GetComponent<RectTransform>();
                person2Pos.localPosition = new Vector3(0, -20, 0);
                break;

            case 57:
                //personImage0のSpriteを変更する
                backGround.GetComponent<Image>().sprite = backGroundSpriteCRU;
                break;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story4_0Scene", 2.0f);
        }
    }
}

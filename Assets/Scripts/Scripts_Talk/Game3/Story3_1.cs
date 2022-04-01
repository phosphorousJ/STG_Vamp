using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story3_1 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage1;


    public override void Update()
    {
        base.Update();

        if (8 <= talkCount && talkCount <= 9)
        {
            //personImage0の位置を変える
            RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
            person0Pos.localPosition = new Vector3(0, -20, 0);
        }
        else
        {
            //personImage0の位置を変える
            RectTransform person0Pos = personImage0.GetComponent<RectTransform>();
            person0Pos.localPosition = new Vector3(235, -20, 0);
        }

        if (33 <= talkCount)
        {
            //personImage1の位置を変える
            RectTransform person1Pos = personImage1.GetComponent<RectTransform>();
            person1Pos.localPosition = new Vector3(0, -20, 0);
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameScene3_0");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story2_5 : StoryBase
{
    //PersonImageを入れる
    public GameObject personImage0;


    public override void Update()
    {
        base.Update();

        if (17 <= talkCount)
        {
            //personImage0を非表示にする
            personImage0.GetComponent<Image>().enabled = false;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            //BKの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            GSubManager.instance.eAttackSub0Count = 0;
            GSubManager.instance.eAttackSub1Count = 0;

            //大技、己心の発動判定をリセット
            GManager.instance.BK_Skill0 = false;
            GManager.instance.BK_Skill0 = false;

            FadeManager.Instance.LoadScene("Story2Scene", 2.0f);
        }
    }
}

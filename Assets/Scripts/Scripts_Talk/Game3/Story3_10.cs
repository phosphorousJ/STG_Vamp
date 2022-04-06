using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_10 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            //SJの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            GSubManager.instance.eAttackSub0Count = 0;
            GSubManager.instance.eAttackSub1Count = 0;
            GSubManager.instance.eAttackSub2Count = 0;

            //大技、己心の発動判定をリセット
            GManager.instance.SJ_Skill0 = false;
            GManager.instance.SJ_Skill1 = false;
            GManager.instance.SJ_Skill2 = false;

            FadeManager.Instance.LoadScene("Story3Scene", 2.0f);
        }
    }
}

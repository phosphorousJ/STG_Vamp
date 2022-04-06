using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story0_5 : StoryBase
{
    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            //FLMの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            GSubManager.instance.eAttackSub0Count = 0;
            GSubManager.instance.eAttackSub1Count = 0;

            //大技、己心の発動判定をリセット
            GManager.instance.FLM_Skill0 = false;
            GManager.instance.FLM_Skill1 = false;

            FadeManager.Instance.LoadScene("Story0Scene", 2.0f);
        }
    }
}

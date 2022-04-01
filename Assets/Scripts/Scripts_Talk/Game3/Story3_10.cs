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

            FadeManager.Instance.LoadScene("Story3Scene", 2.0f);
        }
    }
}

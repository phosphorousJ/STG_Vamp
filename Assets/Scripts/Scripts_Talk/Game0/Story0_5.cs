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

            FadeManager.Instance.LoadScene("Story0Scene", 2.0f);
        }
    }
}

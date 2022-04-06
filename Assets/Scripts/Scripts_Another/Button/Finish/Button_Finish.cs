using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Finish : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            GSubManager.instance.eAttackSub0Count = 0;
            GSubManager.instance.eAttackSub1Count = 0;
            GSubManager.instance.eAttackSub2Count = 0;

            //大技、己心の発動判定をリセット
            GManager.instance.FLM_Skill0 = false;
            GManager.instance.FLM_Skill1 = false;
            GManager.instance.TT_Skill0 = false;
            GManager.instance.TT_Skill0 = false;
            GManager.instance.BK_Skill0 = false;
            GManager.instance.BK_Skill0 = false;
            GManager.instance.SJ_Skill0 = false;
            GManager.instance.SJ_Skill1 = false;
            GManager.instance.SJ_Skill2 = false;

            FadeManager.Instance.LoadScene("MenuScene", 1.0f);
        }
    }
}

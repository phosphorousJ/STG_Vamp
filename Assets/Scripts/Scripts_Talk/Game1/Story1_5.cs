using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story1_5 : StoryBase
{
    //FlashGroundを入れる
    public GameObject flashGround;


    public override void Start()
    {
        base.Start();

        //flashGroundの色を非表示にする
        flashGround.GetComponent<Image>().color = Color.clear;
    }


    public override void Update()
    {
        base.Update();

        //画面をフラッシュさせる
        if (talkCount == 6 && Input.GetMouseButtonDown(0))
        {
            flashGround.GetComponent<Image>().color = Color.red;
        }
        else
        {
            flashGround.GetComponent<Image>().color = Color.Lerp(flashGround.GetComponent<Image>().color, Color.clear, Time.deltaTime);
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            //TTの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            GSubManager.instance.eAttackSub0Count = 0;
            GSubManager.instance.eAttackSub1Count = 1;

            //大技、己心の発動判定をリセット
            GManager.instance.TT_Skill0 = false;
            GManager.instance.TT_Skill1 = false;

            FadeManager.Instance.LoadScene("Story1Scene", 2.0f);
        }
    }
}

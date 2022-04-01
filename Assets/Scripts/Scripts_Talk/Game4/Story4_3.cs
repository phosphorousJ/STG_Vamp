using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Story4_3 : StoryBase
{
    //E_MCAttackSwordを入れる
    public GameObject e_MCAttackSword_1;
    public GameObject e_MCAttackSword_2;

    //FlashGroundを入れる
    public GameObject flashGround;


    public override void Start()
    {
        base.Start();

        //e_MCAttackSword_1を非表示にする
        e_MCAttackSword_1.GetComponent<Image>().enabled = false;

        //e_MCAttackSword_2を非表示にする
        e_MCAttackSword_2.GetComponent<Image>().enabled = false;

        //flashGroundの色を非表示にする
        flashGround.GetComponent<Image>().color = Color.clear;
    }


    public override void Update()
    {
        base.Update();

        //画面をフラッシュさせる
        if (talkCount == 10 && Input.GetMouseButtonDown(0))
        {
            flashGround.GetComponent<Image>().color = Color.red;
        }
        else
        {
            flashGround.GetComponent<Image>().color = Color.Lerp(flashGround.GetComponent<Image>().color, Color.clear, Time.deltaTime);
        }

        if (11 <= talkCount)
        {
            //e_MCAttackSword_1を表示
            e_MCAttackSword_1.GetComponent<Image>().enabled = true;

            //e_MCAttackSword_2を表示
            e_MCAttackSword_2.GetComponent<Image>().enabled = true;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            //MCの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;

            FadeManager.Instance.LoadScene("Story4_0Scene", 2.0f);
        }
    }
}

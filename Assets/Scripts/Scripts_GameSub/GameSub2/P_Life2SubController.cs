﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_Life2SubController : P_LifeSubControllerBase
{
    //Enemyの攻撃の被弾処理
    void OnTriggerEnter(Collider other)
    {
        //BK（大技0）の場合
        if (other.gameObject.tag == "E_BK_SkillAttack0Tag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub0Count += 1;

            decreaseLifeSubImages0();

            if (GSubManager.instance.eAttackSub0Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubScene2_0");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub0Count = 0;
            }
        }


        //BK（己心）の場合
        if (other.gameObject.tag == "E_BK_SkillAttack1Tag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub1Count += 1;

            decreaseLifeSubImages1();

            if (GSubManager.instance.eAttackSub1Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubScene2_1");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub1Count = 0;
            }
        }
    }
}

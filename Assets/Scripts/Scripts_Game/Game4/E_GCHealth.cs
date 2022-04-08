using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_GCHealth : EnemyHealthBase
{
    protected override void Start()
    {
        base.Start();

        //一定時間毎に被ダメ軽減割合を減少させる
        InvokeRepeating("DecreaseDamageRateAdd", 10, 5);

        //現在のHPを最大値に設定
        currentHP = enemyHP - GManager.instance.sumDamage;
    }


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        ////Enemyの現在HPによって推移するTalkSceneを変える
        //Enemyの体力が0になった場合
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("TalkScene4_1");
        }
    }


    //被ダメ軽減割合を増加させる関数
    void DecreaseDamageRateAdd()
    {
        //被ダメ軽減割合を負の数にしない（Enemyの被ダメ増加を防止）
        if (decreaseDamageRate < 1.0f)
        {
            decreaseDamageRate += 0.2f;

            //デバッグ用
            GManager.instance.decreaseDamageRateDebug = decreaseDamageRate + 0.2f;
        }
    }
}

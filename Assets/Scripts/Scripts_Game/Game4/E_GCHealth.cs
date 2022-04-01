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

        //Enemyの現在HPによってシーン推移を変える
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("TalkScene4_1");
        }
    }


    //被ダメ軽減割合を増加させる関数
    void DecreaseDamageRateAdd()
    {
        if (decreaseDamageRate < 1.0f)
        {
            //計算用
            GManager.instance.decreaseDamageRate0 = decreaseDamageRate + 0.2f;

            decreaseDamageRate += 0.2f;
        }
    }
}

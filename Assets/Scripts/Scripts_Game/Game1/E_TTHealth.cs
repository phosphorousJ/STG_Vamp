using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_TTHealth : EnemyHealthBase
{
    protected override void Start()
    {
        base.Start();

        InvokeRepeating("GetRandomDecreaseDamageRate", 0.0f, 1.0f);

        //現在のHPを最大値に設定
        currentHP = enemyHP - GManager.instance.sumDamage;
    }


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        ////Enemyの現在HPによって推移するTalkSceneを変える
        //大技が発動していない場合
        if (8000 < currentHP && currentHP <= 10000 && GManager.instance.TT_Skill0 == false)
        {
            if (!GManager.instance.TT_Skill0)
            {
                SceneManager.LoadScene("TalkScene1_2");
            }
        }
        //己心が発動していない場合
        else if (0 < currentHP && currentHP <= 1500 && GManager.instance.TT_Skill1 == false)
        {
            if (!GManager.instance.TT_Skill1)
            {
                SceneManager.LoadScene("TalkScene1_3");
            }
        }
        //Enemyの体力が0になった場合
        else if (currentHP <= 0)
        {
            SceneManager.LoadScene("TalkScene1_5");
        }
    }


    //ランダムに被ダメ軽減割合を決定する関数
    void GetRandomDecreaseDamageRate()
    {
        float[] decreaseDamageRates = { 0.5f, 0.0f };

        float randomDecreaseDamgeRate = decreaseDamageRates[Random.Range(0, decreaseDamageRates.Length)];

        decreaseDamageRate = randomDecreaseDamgeRate;

        //デバッグ用
        GManager.instance.decreaseDamageRateDebug = decreaseDamageRate;
    }
}

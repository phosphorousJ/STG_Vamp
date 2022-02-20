using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_TTHealth0 : EnemyHealthBase
{
    //大技が発動したのかを判定
    private bool enemySkill_0 = false;


    protected override void Start()
    {
        base.Start();

        InvokeRepeating("GetRandomDecreaseDamageRate", 0.0f, 1.0f);

        //現在のHPを最大値に設定
        currentHP = enemyHP;
    }


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (8000 < currentHP && currentHP <= 10000)
        {
            if (!enemySkill_0)
            {
                enemySkill_0 = true;

                
                Debug.Log("TTが大技0を発動!!");
            }
        }
    }


    //ランダムに被ダメ軽減割合を決定する関数
    void GetRandomDecreaseDamageRate()
    {
        float[] decreaseDamageRates = { 0.5f, 0.0f };

        float randomDecreaseDamgeRate = decreaseDamageRates[Random.Range(0, decreaseDamageRates.Length)];

        decreaseDamageRate = randomDecreaseDamgeRate;
    }
}

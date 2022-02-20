using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_FLMHealth1 : EnemyHealthBase
{
    //大技が発動したのかを判定
    private bool enemySkill_1 = false;


    protected override void Start()
    {
        base.Start();

        //現在のHPを最大値に設定
        currentHP = enemyHP - GManager.instance.sumDamage;
    }


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (0 < currentHP && currentHP <= 20000)
        {
            if (!enemySkill_1)
            {
                enemySkill_1 = true;

                SceneManager.LoadScene("TalkScene0_3");
                Debug.Log("FLMが大技1を発動!!");
            }
        }
        else if (currentHP <= 0)
        {
            Debug.Log("FLMの体力は0になった");
        }
    }
}

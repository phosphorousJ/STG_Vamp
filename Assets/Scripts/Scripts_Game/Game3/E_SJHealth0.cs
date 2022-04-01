using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJHealth0 : EnemyHealthBase
{
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

        if (35000 < currentHP && currentHP <= 50000 && GManager.instance.SJ_Skill0 == false)
        {
            if (!GManager.instance.SJ_Skill0)
            {
                SceneManager.LoadScene("TalkScene3_2");
            }
        }
    }
}

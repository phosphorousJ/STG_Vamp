using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJHealth2 : EnemyHealthBase
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

        ////Enemyの現在HPによって推移するTalkSceneを変える
        //己心2が発動していない場合
        if (5000 < currentHP && currentHP <= 20000 && GManager.instance.SJ_Skill2 == false)
        {
            if (!GManager.instance.SJ_Skill2)
            {
                SceneManager.LoadScene("TalkScene3_6");
            }
        }
    }
}

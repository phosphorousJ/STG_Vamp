using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_BKHealth0 : EnemyHealthBase
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
        //大技が発動していない場合
        if (30000 < currentHP && currentHP <= 55000 && GManager.instance.BK_Skill0 == false)
        {
            if (!GManager.instance.BK_Skill0)
            {
                SceneManager.LoadScene("TalkScene2_2");
            }
        }
        //己心が発動していない場合
        else if (0 < currentHP && currentHP <= 30000 && GManager.instance.BK_Skill1 == false)
        {
            if (!GManager.instance.BK_Skill1)
            {
                SceneManager.LoadScene("TalkScene2_3");
            }
        }
    }
}

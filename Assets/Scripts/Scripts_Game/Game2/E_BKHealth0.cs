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

        //Enemyの現在HPによってシーン推移を変える
        if (30000 < currentHP && currentHP <= 55000 && GManager.instance.BK_Skill0 == false)
        {
            if (!GManager.instance.TT_Skill0)
            {
                SceneManager.LoadScene("TalkScene2_2");
            }
        }
        else if (0 < currentHP && currentHP <= 30000 && GManager.instance.BK_Skill1 == false)
        {
            if (!GManager.instance.TT_Skill1)
            {
                SceneManager.LoadScene("TalkScene2_3");
            }
        }
    }
}

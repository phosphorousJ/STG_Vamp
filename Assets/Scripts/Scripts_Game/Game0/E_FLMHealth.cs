using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_FLMHealth : EnemyHealthBase
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

        if (20000 < currentHP && currentHP <= 40000 && GManager.instance.FLM_Skill0 == false)
        {
            if (!GManager.instance.FLM_Skill0)
            {
                SceneManager.LoadScene("TalkScene0_2");
            }
        }
        else if (0 < currentHP && currentHP <= 20000 && GManager.instance.FLM_Skill1 == false)
        {
            if (!GManager.instance.FLM_Skill1)
            {
                SceneManager.LoadScene("TalkScene0_3");
            }
        }
        else if (currentHP <= 0)
        {
            SceneManager.LoadScene("TalkScene0_5");
        }
    }
}

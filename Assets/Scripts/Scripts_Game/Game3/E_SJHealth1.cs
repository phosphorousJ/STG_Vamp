﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJHealth1 : EnemyHealthBase
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

        if (20000 < currentHP && currentHP <= 35000 && GManager.instance.SJ_Skill1 == false)
        {
            if (!GManager.instance.SJ_Skill1)
            {
                SceneManager.LoadScene("TalkScene3_4");
            }
        }
    }
}

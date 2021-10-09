﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLMHealth2 : EnemyHealthBase
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

        if (currentHP <= 0)
        {
            Debug.Log("FLMの体力は0になった");
        }
    }
}

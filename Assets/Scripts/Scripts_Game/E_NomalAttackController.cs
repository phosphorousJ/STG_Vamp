﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_NomalAttackController : E_NomalAttackBaseController
{
    //通常攻撃の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //通常攻撃の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

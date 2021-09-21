using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_NomalAttackController : P_AttackBaseController
{
    //コウモリ攻撃の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //コウモリ攻撃の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

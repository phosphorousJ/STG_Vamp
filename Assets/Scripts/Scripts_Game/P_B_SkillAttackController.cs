using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_B_SkillAttackController : P_AttackBaseController
{
    //B攻撃の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //B攻撃の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

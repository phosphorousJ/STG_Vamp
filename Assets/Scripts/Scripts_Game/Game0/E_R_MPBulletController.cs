using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_R_MPBulletController : MPBulletBaseController
{
    //赤弾の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //赤弾の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

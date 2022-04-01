using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_B_MPBulletController : MPBulletBaseController
{
    //青弾の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //青弾の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

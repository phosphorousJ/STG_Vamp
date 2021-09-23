using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_G_MPBulletController : MPBulletBaseController
{
    //緑弾の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    //緑弾の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

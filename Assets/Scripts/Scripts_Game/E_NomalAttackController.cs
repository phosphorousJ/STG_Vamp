using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_NomalAttackController : P_AttackBaseController
{
    //オブジェクトの消滅位置
    private float deadLine = -9.0f;


    //通常攻撃の移動処理
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        //消滅位置まで移動したら破棄する
        if (transform.position.z < -9.0f)
        {
            Destroy(this.gameObject);
            Debug.Log("通常攻撃破棄");
        }
    }


    //通常攻撃の衝突処理
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}

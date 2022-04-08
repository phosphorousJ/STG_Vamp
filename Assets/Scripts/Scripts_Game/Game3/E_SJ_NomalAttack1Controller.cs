using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_NomalAttack1Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("武器名称")] new string name;
    [SerializeField] [Header("移動速度")] float speed;
    #endregion

    #region//プライベート変数
    //オブジェクトの消滅位置
    private float deadLine = -9.0f;
    #endregion


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, speed * Time.deltaTime, 0);

        //消滅位置まで移動したら破棄する
        if (transform.position.z < deadLine)
        {
            Destroy(this.gameObject);
        }
    }


    //攻撃の衝突処理
    protected virtual void OnTriggerEnter(Collider other)
    {
        //Playerの場合
        if (other.gameObject.tag == "PlayerTag")
        {
            Destroy(this.gameObject);
        }
    }
}

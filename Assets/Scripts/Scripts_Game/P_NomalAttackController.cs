using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_NomalAttackController : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("武器名称")] new string name;
    [SerializeField] [Header("移動速度")] float speed;
    [SerializeField] [Header("攻撃威力")] int power;
    #endregion


    //コウモリ攻撃の移動処理
    void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //コウモリ攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //BackWallの場合
        if (other.gameObject.tag == "BackWallTag")
        {
            //ダメージ計算
            int damage = power;

            //EnemyHealthBaseスクリプトのSetDamage関数にダメージ値を渡す
            other.gameObject.GetComponent<EnemyHealthBase>().SetDamage(damage);

            Destroy(this.gameObject);
            Debug.Log("Enemyに" + name + "を攻撃!!" + damage + "ダメージ!!");
        }
    }
}

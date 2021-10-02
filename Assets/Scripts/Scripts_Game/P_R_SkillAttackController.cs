using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_R_SkillAttackController : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("武器名称")] new string name;
    [SerializeField] [Header("移動速度")] float speed;
    [SerializeField] [Header("攻撃威力")] int power;
    #endregion

    #region//プライベート変数
    //相殺したE_NomalAttackの初期個数
    private int eNomalAttackNum = 0;
    #endregion


    //R攻撃の移動処理
    void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //R攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //通常攻撃（Enemy）の場合
        if (other.gameObject.tag == "E_NomalAttackTag")
        {
            //E_NomalAttackを相殺
            Destroy(other.gameObject);
            Debug.Log("Enemyの攻撃を相殺");

            //相殺したE_NomalAttackの数を更新
            eNomalAttackNum++;
        }

        //BackWallの場合
        if (other.gameObject.tag == "BackWallTag")
        {
            //ダメージ計算
            int damage = power - 50 * eNomalAttackNum;

            //BackWallが青色の場合
            if (other.gameObject.GetComponent<Renderer>().material.color == Color.red)
            {
                int timesDamage = 2 * damage;

                //EnemyHealthBaseスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<EnemyHealthBase>().SetDamage(timesDamage);

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + timesDamage + "ダメージ!!");
            }
            else
            {
                //EnemyHealthBaseスクリプトのSetDamage関数にダメージ値を渡す
                other.gameObject.GetComponent<EnemyHealthBase>().SetDamage(damage);

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + damage + "ダメージ!!");
            }
        }
    }
}

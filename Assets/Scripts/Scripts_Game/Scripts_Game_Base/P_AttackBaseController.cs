using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_AttackBaseController : MonoBehaviour
{
    #region//インスペクター設定
    [Header("武器名称")] public new string name;
    [Header("移動速度")] public float speed;
    [Header("攻撃威力")] public float power;
    #endregion

    #region//プライベート変数
    //相殺したE_NomalAttackの初期個数
    private int eNomalAttackNum = 0;
    #endregion


    // Start is called before the first frame update
    public void Start()
    {

    }


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //攻撃の衝突処理
    protected virtual void OnTriggerEnter(Collider other)
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

        //Enemyの場合
        if (other.gameObject.tag == "Enemy_FLMTag")
        {
            //ダメージ計算
            float damage = power - 50 * eNomalAttackNum;

            Destroy(this.gameObject);
            Debug.Log("Enemyに" + name + "を攻撃!!"+ damage +"ダメージ!!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_G_SkillAttackController : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField][Header("武器名称")] new string name;
    [SerializeField][Header("移動速度")] float speed;
    [SerializeField][Header("攻撃威力")] int power;
    #endregion

    #region//プライベート変数
    //相殺したE_NomalAttackの初期個数
    private int eNomalAttackNum = 0;
    #endregion

    #region//インスペクター設定
    //E_R_ParticleSystemPrefabを入れる
    public GameObject E_G_ParticleSystemPrefab;

    //P_N_ParticleSystemPrefabを入れる
    public GameObject P_N_ParticleSystemPrefab;
    #endregion


    void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //G攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //通常攻撃（Enemy）の場合
        if (other.gameObject.tag == "E_NomalAttackTag")
        {
            //衝突位置を取得
            Vector3 hitPos = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleN = Instantiate(P_N_ParticleSystemPrefab, hitPos, Quaternion.identity);
            var particleSystemN = particleN.GetComponent<ParticleSystem>();
            particleSystemN.Play();

            Destroy(other.gameObject);

            //相殺したE_NomalAttackの数を更新
            eNomalAttackNum++;

            //G攻撃の限界相殺数
            int P_G_SkillAttackDelNum = power / 50;

            //限界相殺数に達した場合、攻撃を破棄（ダメージ値が0または負の数になるのを防ぐ）
            if (eNomalAttackNum == P_G_SkillAttackDelNum)
            {
                Destroy(this.gameObject);
            }
        }

        //通常攻撃（Enemy_BKとEnemy_MC）の場合
        if (other.gameObject.tag == "E_BK_NomalAttackTag" || other.gameObject.tag == "E_MC_NomalAttackTag")
        {
            Destroy(this.gameObject);
        }

        //BackWallの場合
        if (other.gameObject.tag == "BackWallTag")
        {
            //最終ダメージ計算
            int damage = power - 50 * eNomalAttackNum;

            //BackWallが緑色の場合
            if (other.gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                //ダメージ値を2倍にする
                int timesDamage = 2 * damage;

                GManager.instance.damage = timesDamage;

                //デバッグ用
                GManager.instance.damageDebug = timesDamage;

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + timesDamage + "ダメージ!!");
            }
            else
            {
                GManager.instance.damage = damage;

                //デバッグ用
                GManager.instance.damageDebug = damage;

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + damage + "ダメージ!!");
            }
        }

        //Enemyの場合
        if (other.gameObject.tag == "EnemyTag")
        {
            //衝突位置を取得
            Vector3 hitPosE = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleE = Instantiate(E_G_ParticleSystemPrefab, hitPosE, Quaternion.identity);
            var particleSystemE = particleE.GetComponent<ParticleSystem>();
            particleSystemE.Play();
        }
    }
}

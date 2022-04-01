using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_B_SkillAttackController : MonoBehaviour
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
    public GameObject E_B_ParticleSystemPrefab;

    //P_N_ParticleSystemPrefabを入れる
    public GameObject P_N_ParticleSystemPrefab;
    #endregion


    //B攻撃の移動処理
    void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //B攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //通常攻撃（Enemy）
        if (other.gameObject.tag == "E_NomalAttackTag")
        {
            //衝突位置を取得
            Vector3 hitPos = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleN = Instantiate(P_N_ParticleSystemPrefab, hitPos, Quaternion.identity);
            var particleSystemN = particleN.GetComponent<ParticleSystem>();
            particleSystemN.Play();

            //E_NomalAttackを相殺
            Destroy(other.gameObject);

            //相殺したE_NomalAttackの数を更新
            eNomalAttackNum++;
        }

        //通常攻撃（Enemy_BKとEnemy_MCの場合）
        if (other.gameObject.tag == "E_BK_NomalAttackTag" || other.gameObject.tag == "E_MC_NomalAttackTag")
        {
            Destroy(this.gameObject);
        }

        //BackWall
        if (other.gameObject.tag == "BackWallTag")
        {
            //ダメージ計算
            int damage = power - 50 * eNomalAttackNum;

            //BackWallが青色
            if (other.gameObject.GetComponent<Renderer>().material.color == Color.blue)
            {
                int timesDamage = 2 * damage;

                GManager.instance.damage0 = timesDamage;
                GManager.instance.damage1 = timesDamage;

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + timesDamage + "ダメージ!!");
            }
            else
            {
                GManager.instance.damage0 = damage;
                GManager.instance.damage1 = damage;

                Destroy(this.gameObject);
                Debug.Log("Enemyに" + name + "を攻撃!!" + damage + "ダメージ!!");
            }
        }

        //Enemy
        if (other.gameObject.tag == "EnemyTag")
        {
            //衝突位置を取得
            Vector3 hitPosE = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleE = Instantiate(E_B_ParticleSystemPrefab, hitPosE, Quaternion.identity);
            var particleSystemE = particleE.GetComponent<ParticleSystem>();
            particleSystemE.Play();
        }
    }
}

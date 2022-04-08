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

    #region//インスペクター設定
    //E_R_ParticleSystemPrefabを入れる
    public GameObject E_R_ParticleSystemPrefab;

    //P_N_ParticleSystemPrefabを入れる
    public GameObject P_N_ParticleSystemPrefab;
    #endregion

    
    void FixedUpdate()
    {
        //攻撃を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);
    }


    //R攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //通常攻撃（Enemy）の場合
        if (other.gameObject.tag == "E_NomalAttackTag" || other.gameObject.tag == "E_BK_NomalAttackTag")
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
        }

        //通常攻撃（Enemy_MC）の場合
        if (other.gameObject.tag == "E_MC_NomalAttackTag")
        {
            Destroy(this.gameObject);
        }

        //BackWallの場合
        if (other.gameObject.tag == "BackWallTag")
        {
            //最終ダメージを計算
            int damage = power - 50 * eNomalAttackNum;

            //BackWallが赤色の場合
            if (other.gameObject.GetComponent<Renderer>().material.color == Color.red)
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
            //パーティクルを生成（R攻撃は槍が2つ）
            var particleL = Instantiate(E_R_ParticleSystemPrefab, new Vector3(3.2f, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            var particleR = Instantiate(E_R_ParticleSystemPrefab, new Vector3(-3.2f, this.transform.position.y, this.transform.position.z), Quaternion.identity);

            //ParticleSystemを取得
            var particleSystemL = particleL.GetComponent<ParticleSystem>();
            var particleSystemR = particleR.GetComponent<ParticleSystem>();

            //パーティクルを表示
            particleSystemL.Play();
            particleSystemR.Play();
        }
    }
}

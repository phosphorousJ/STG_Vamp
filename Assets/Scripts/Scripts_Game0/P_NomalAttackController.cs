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

    #region//インスペクター設定
    //E_N_ParticleSystemPrefabを入れる
    public GameObject E_N_ParticleSystemPrefab;
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

            GManager.instance.damage0 = damage;
            GManager.instance.damage1 = damage;

            Destroy(this.gameObject);
            Debug.Log("Enemyに" + name + "を攻撃!!" + damage + "ダメージ!!");
        }

        //Enemyの場合
        if (other.gameObject.tag == "EnemyTag")
        {
            //衝突位置を取得
            Vector3 hitPosN = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleN = Instantiate(E_N_ParticleSystemPrefab, hitPosN, Quaternion.identity);
            var particleSystemN = particleN.GetComponent<ParticleSystem>();
            particleSystemN.Play();
        }
    }
}

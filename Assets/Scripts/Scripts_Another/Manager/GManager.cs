using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    #region//インスペクター設定
    public static GManager instance = null;

    //Enemyの被ダメージ
    public int damage0;

    //Enemyの被ダメージ（総被ダメージ計算用）
    public int damage1;

    //Enemyの総被ダメージ
    public float sumDamage;

    //Enemyの被ダメ軽減割合
    public float decreaseDamageRate0;

    //playerの被弾回数
    public int eAttackCount;

    //Enemyが大技を発動したのか判定
    public bool FLM_Skill0 = false;
    public bool FLM_Skill1 = false;

    public bool TT_Skill0 = false;
    public bool TT_Skill1 = false;

    public bool BK_Skill0 = false;
    public bool BK_Skill1 = false;

    public bool SJ_Skill0 = false;
    public bool SJ_Skill1 = false;
    public bool SJ_Skill2 = false;
    #endregion


    //シングルトンの実装
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    void Update()
    {
        if (damage1 != 0)
        {
            //総被ダメージを計算
            sumDamage += damage1 * decreaseDamageRate0;
            Debug.Log("Enemyの総被ダメージ:" + sumDamage);

            //被ダメージをリセット
            damage1 = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    #region//インスペクター設定
    public static GManager instance = null;

    //Enemyの被ダメージ（EnemyのHPバー反映用）
    public int damage { get; set; }

    //Enemyの被ダメージ（デバッグ用）
    public int damageDebug { get; set; }

    //Enemyの総被ダメージ
    public float sumDamage { get; set; }

    //Enemyの被ダメ軽減割合（デバッグ用）
    public float decreaseDamageRateDebug { get; set; }

    //playerの被弾回数
    public int eAttackCount { get; set; }

    //難易度が選択されたのか判定
    public bool easy = false;
    public bool nomal = false;
    public bool hard = false;
    public bool veryHard = false;

    //Enemyが大技・己心を発動したのか判定
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
        if (damageDebug != 0)
        {
            //総被ダメージを計算（デバッグ用）
            sumDamage += damageDebug * decreaseDamageRateDebug;
            Debug.Log("Enemyの総被ダメージ:" + sumDamage);

            //被ダメージをリセット
            damageDebug = 0;
        }
    }
}

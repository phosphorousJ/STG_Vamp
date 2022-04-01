using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class E_SJHealth4 : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("体力")] protected int enemyHP;
    [SerializeField] [Header("被ダメ軽減割合")] protected float decreaseDamageRate;
    #endregion

    //EnemyHPSlider（HPバー）を入れる
    public Slider EnemyHPSlider;

    //Enemyの現在のHP
    public float currentHP;


    void Start()
    {
        //HPバーを満タンにする
        EnemyHPSlider.value = 1;

        //現在のHPを最大値に設定
        currentHP = enemyHP - GManager.instance.sumDamage;

        InvokeRepeating("DecreaseHealth", 5.0f, 1.0f);

        GManager.instance.decreaseDamageRate0 = decreaseDamageRate;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("TalkScene3_10");
        }
    }


    //Enemyの体力を毎秒減少させる関数
    void DecreaseHealth()
    {
        //現在のHPを更新
        currentHP -= 200;

        Debug.Log("Enemyの体力:" + currentHP);

        //HPバーを更新
        EnemyHPSlider.value = currentHP / enemyHP;

        //被ダメージをリセット
        GManager.instance.damage0 = 0;

        GManager.instance.damage1 = 200;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBase: MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField][Header("体力")] int enemyHP;
    [SerializeField][Header("被ダメ軽減割合")] float decreaseDamageRate;
    #endregion

    //EnemyHPSlider（HPバー）を入れる
    public Slider EnemyHPSlider;

    //Enemyの現在のHP
    protected float currentHP;


    // Start is called before the first frame update
    void Start()
    {
        //HPバーを満タンにする
        EnemyHPSlider.value = 1;

        //現在のHPを最大値に設定
        currentHP = enemyHP;
    }


    //Enemyの被ダメージ値を取得する関数
    public void SetDamage(int enemyDamage)
    {
        //現在のHPを更新
        currentHP -= enemyDamage * decreaseDamageRate;

        //HPバーを更新
        EnemyHPSlider.value = currentHP / enemyHP;
    }
}

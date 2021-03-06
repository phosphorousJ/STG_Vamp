using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBase: MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("体力")] protected int enemyHP;
    [SerializeField] [Header("被ダメ軽減割合")] protected float decreaseDamageRate;
    #endregion

    //EnemyHPSlider（HPバー）を入れる
    public Slider EnemyHPSlider;

    //Enemyの現在のHP
    public float currentHP;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        //HPバーを満タンにする
        EnemyHPSlider.value = 1;

        //デバッグ用
        GManager.instance.decreaseDamageRateDebug = decreaseDamageRate;
    }


    protected virtual void Update()
    {
        if (GManager.instance.damage != 0)
        {
            //現在のHPを更新
            currentHP -= GManager.instance.damage * decreaseDamageRate;

            Debug.Log("Enemyの体力:" + currentHP);

            //HPバーを更新
            EnemyHPSlider.value = currentHP / enemyHP;

            //被ダメージをリセット
            GManager.instance.damage = 0;
        }
    }
}

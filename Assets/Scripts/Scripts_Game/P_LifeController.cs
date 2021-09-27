using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P_LifeController : MonoBehaviour
{
    //P_LifeStockPanel（残機の親オブジェクト）を入れる
    public GameObject P_LifeStockPanel;

    //残機のストック配列
    public GameObject[] lifeImages;

    //Enemyの攻撃に被弾した回数
    private int eAttackCount = 0;

    //現在の残機数
    private int currentLifeNull = 5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Enemyの攻撃の被弾処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "E_NomalAttackTag")
        {
            if (1 <= currentLifeNull && currentLifeNull <= 5)
            {
                //被弾回数を更新
                eAttackCount++;

                decreaseLifeImages();

                //被弾回数をリセット
                eAttackCount = 0;
            }
            else if (currentLifeNull == 0)
            {
                Debug.Log("残機数が0です。");
            }
        }
    }


    //残機のストックを更新（減少）する関数
    void decreaseLifeImages()
    {
        currentLifeNull -= eAttackCount;
        lifeImages[currentLifeNull].SetActive(false);
        Debug.Log("残機数:" + currentLifeNull);
    }
}

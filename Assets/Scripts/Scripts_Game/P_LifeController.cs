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
    public static int eAttackCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        decreaseLifeImages();
    }


    //Enemyの攻撃の被弾処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "E_NomalAttackTag")
        {
            eAttackCount += 1;
            decreaseLifeImages();
        }

        if (eAttackCount == 5)
        {
            Debug.Log("残機が0です。");
        }
    }


    //残機のストックを更新（減少）する関数
    void decreaseLifeImages()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (eAttackCount <= i)
            {
                lifeImages[i].SetActive(true);
            }
            else
            {
                lifeImages[i].SetActive(false);
            }
        }

    }
}

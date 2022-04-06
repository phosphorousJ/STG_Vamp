using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_LifeSubControllerBase : MonoBehaviour
{
    //P_LifeStockPanel（残機の親オブジェクト）を入れる
    public GameObject P_LifeSubStockPanel;

    //残機のストック配列
    public GameObject[] lifeSubImages;

    //Enemyの攻撃無効化を判定
    public bool eAttckInvalid = false;


    // Start is called before the first frame update
    public virtual void Start()
    {
        decreaseLifeSubImages0();

        decreaseLifeSubImages1();
    }


    //GameSub0の残機ストックを更新（減少）する関数
    public virtual void decreaseLifeSubImages0()
    {
        for (int i = 0; i < lifeSubImages.Length; i++)
        {
            if (GSubManager.instance.eAttackSub0Count <= i)
            {
                //残機のストックを表示
                lifeSubImages[i].SetActive(true);
            }
            else
            {
                //残機のストックを非表示にする
                lifeSubImages[i].SetActive(false);
            }
        }


        //被弾したら一定時間Enemyの攻撃を無効化
        eAttckInvalid = true;
        
        Invoke("EnemyAttackInvalidFin", 0.5f);
    }


    //GameSub1の残機ストックを更新（減少）する関数
    public virtual void decreaseLifeSubImages1()
    {
        for (int i = 0; i < lifeSubImages.Length; i++)
        {
            if (GSubManager.instance.eAttackSub1Count <= i)
            {
                //残機のストックを表示
                lifeSubImages[i].SetActive(true);
            }
            else
            {
                //残機のストックを非表示にする
                lifeSubImages[i].SetActive(false);
            }
        }


        //被弾したら一定時間Enemyの攻撃を無効化
        eAttckInvalid = true;

        Invoke("EnemyAttackInvalidFin", 0.5f);
    }


    //リトライする関数
    public virtual void Retry()
    {
        //残機アイコンの表示をリセット
        this.gameObject.SetActive(true);
    }


    //Enemyの攻撃無効化を終了する関数
    void EnemyAttackInvalidFin()
    {
        eAttckInvalid = false;
    }
}

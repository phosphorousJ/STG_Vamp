using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_Life0_2Controller : MonoBehaviour
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
            //リトライ処理
            Invoke("Retry", 0.5f);

            //ゲームオーバ処理
            SceneManager.LoadScene("GameOverScene0_2");

            //被弾回数をリセット
            eAttackCount = 0;
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


    //リトライする関数
    void Retry()
    {
        //残機アイコンの表示をリセット
        this.gameObject.SetActive(true);
    }
}

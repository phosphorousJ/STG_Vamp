using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_Life1_0Controller : MonoBehaviour
{
    //P_LifeStockPanel（残機の親オブジェクト）を入れる
    public GameObject P_LifeStockPanel;

    //残機のストック配列
    public GameObject[] lifeImages;


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
            GManager.instance.eAttackCount += 1;

            decreaseLifeImages();
        }

        if (GManager.instance.eAttackCount == 5)
        {
            //リトライ処理
            Invoke("Retry", 0.5f);

            //ゲームオーバ処理
            SceneManager.LoadScene("GameOverScene1_0");

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
            Debug.Log("残機が0です。");
        }
    }


    //残機のストックを更新（減少）する関数
    void decreaseLifeImages()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (GManager.instance.eAttackCount <= i)
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

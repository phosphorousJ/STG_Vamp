using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_LifeControllerBase : MonoBehaviour
{
    //P_LifeStockPanel（残機の親オブジェクト）を入れる
    public GameObject P_LifeStockPanel;

    //残機のストック配列
    public GameObject[] lifeImages;


    // Start is called before the first frame update
    public virtual void Start()
    {
        decreaseLifeImages();
    }


    //Gameの残機ストックを更新（減少）する関数
    public virtual void decreaseLifeImages()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (GManager.instance.eAttackCount <= i)
            {
                //残機のストックを表示
                lifeImages[i].SetActive(true);
            }
            else
            {
                //残機のストックを非表示にする
                lifeImages[i].SetActive(false);
            }
        }
    }


    //リトライする関数
    public virtual void Retry()
    {
        //残機アイコンの表示をリセット
        this.gameObject.SetActive(true);
    }
}

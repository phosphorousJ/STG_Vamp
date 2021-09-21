using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    [Header("ステージ名")] public int stageNum;
    [Header("現在の残機数")] public int lifeNum;
    [Header("初期の残機数")] public int initialLifeNum;

    //ゲームオーバを判定
    [HideInInspector] public bool isGameOver = false;


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


    //残機を減らす処理
    public void decreaseLifeNum()
    {
        if (lifeNum > 0)
        {
            --lifeNum;
        }
        else if (lifeNum == 0)
        {
            isGameOver = true;
        }
    }
}

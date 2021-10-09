﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    //Enemyの被ダメージ
    public int damage0;

    //Enemyの被ダメージ（総被ダメージ計算用）
    public int damage1;

    //Enemyの総被ダメージ
    public int sumDamage;


    //シングルトンの実装
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


    void Update()
    {
        if (damage1 != 0)
        {
            //総被ダメージを計算
            sumDamage += damage1;
            Debug.Log("FLMの総被ダメージ:" + sumDamage);

            //被ダメージをリセット
            damage1 = 0;
        }
    }
}
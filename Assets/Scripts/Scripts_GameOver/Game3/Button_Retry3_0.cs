﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry3_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            //Enemyの被ダメージ量によって推移するGameSceneを分岐させる
            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 5000)
            {
                SceneManager.LoadScene("GameScene3_0");
            }
            else if (5000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 20000)
            {
                SceneManager.LoadScene("GameScene3_1");
            }
            else if (20000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 35000)
            {
                SceneManager.LoadScene("GameScene3_2");
            }
            else if (35000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 50000)
            {
                SceneManager.LoadScene("GameScene3_3");
            }

            firstPush = true;
        }
    }
}

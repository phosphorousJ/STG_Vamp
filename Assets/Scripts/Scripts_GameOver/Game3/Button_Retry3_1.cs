using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry3_1 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの被ダメージ量によって推移するGameSceneを分岐させる
            if (50000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 55000)
            {
                //Enemyの被ダメージ量を固定
                GManager.instance.sumDamage = 50000;

                SceneManager.LoadScene("GameScene3_4");
            }
        }
    }
}

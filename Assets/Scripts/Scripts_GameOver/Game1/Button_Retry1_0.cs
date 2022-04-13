using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry1_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの被ダメージ量によって推移するGameScene（Enemyの残りHPのみ引き継ぐ）を変える
            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 5000)
            {
                SceneManager.LoadScene("GameScene1_0");
            }
            else if (5000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 13500)
            {
                SceneManager.LoadScene("GameScene1_0");
            }
            else if (13500 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 15000)
            {
                SceneManager.LoadScene("GameScene1_0");
            }
        }
    }
}

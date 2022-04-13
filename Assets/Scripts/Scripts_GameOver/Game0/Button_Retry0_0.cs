using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry0_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの被ダメージ量によって推移するGameScene（Enemyの残りHPのみ引き継ぐ）を変える
            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 20000)
            {
                SceneManager.LoadScene("GameScene0_0");
            }
            else if (20000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 40000)
            {
                SceneManager.LoadScene("GameScene0_0");
            }
            else if (40000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 60000)
            {
                SceneManager.LoadScene("GameScene0_0");
            }
        }
    }
}

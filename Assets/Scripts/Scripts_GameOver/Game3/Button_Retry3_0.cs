using System.Collections;
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
            firstPush = true;

            ////Enemyの被ダメージ量によって推移するGameScene（Enemyの残りHPのみ引き継ぐ）を変える
            //Enemy（SJ）は通常攻撃が変わるため推移するGameSceneを変えている
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
        }
    }
}

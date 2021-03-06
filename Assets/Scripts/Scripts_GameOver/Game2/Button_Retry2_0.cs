using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry2_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの被ダメージ量によって推移するGameScene（Enemyの残りHPのみ引き継ぐ）を変える
            //Enemy（BK）は通常攻撃が変わるため推移するGameSceneを変えている
            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 25000)
            {
                SceneManager.LoadScene("GameScene2_0");
            }
            else if (25000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 50000)
            {
                SceneManager.LoadScene("GameScene2_0");
            }
            else if (50000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 80000)
            {
                SceneManager.LoadScene("GameScene2_1");
            }
        }
    }
}

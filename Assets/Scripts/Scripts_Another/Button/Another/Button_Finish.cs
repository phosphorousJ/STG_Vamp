using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Finish : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            //Enemyの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            firstPush = true;

            FadeManager.Instance.LoadScene("MenuScene", 1.0f);
        }
    }
}

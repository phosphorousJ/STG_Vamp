using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_FinishT : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            //Enemyの総被ダメージをリセット
            GManager.instance.sumDamage = 0;

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;

            FadeManager.Instance.LoadScene("AttackTurnScene", 1.0f);
        }
    }
}

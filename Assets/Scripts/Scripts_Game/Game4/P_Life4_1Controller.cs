using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_Life4_1Controller : P_LifeControllerBase
{
    //Enemyの攻撃の被弾処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "E_MC_NomalAttackTag")
        {
            //Playerの被弾回数をカウント
            GManager.instance.eAttackCount += 1;

            decreaseLifeImages();
        }

        if (GManager.instance.eAttackCount == 5)
        {
            //リトライ処理
            Invoke("Retry", 0.5f);

            //ゲームオーバ処理
            SceneManager.LoadScene("TalkScene4_3");

            //被弾回数をリセット
            GManager.instance.eAttackCount = 0;
        }
    }
}

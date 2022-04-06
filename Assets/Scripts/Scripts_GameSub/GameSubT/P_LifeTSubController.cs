using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_LifeTSubController : P_LifeSubControllerBase
{
    void OnTriggerEnter(Collider other)
    {
        //ANE（己心）の場合
        if (other.gameObject.tag == "E_ANE_SkillAttackTag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub1Count += 1;

            decreaseLifeSubImages1();

            if (GSubManager.instance.eAttackSub1Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubSceneT");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub1Count = 0;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P_Life3SubController : P_LifeSubControllerBase
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        decreaseLifeSubImages2();
    }


    //Enemyの攻撃の被弾処理
    void OnTriggerEnter(Collider other)
    {
        //SJ（己心0）の場合
        if (other.gameObject.tag == "E_SJ_SkillAttack0Tag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub0Count += 1;

            decreaseLifeSubImages0();

            if (GSubManager.instance.eAttackSub0Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubScene3_0");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub0Count = 0;
            }
        }


        //SJ（己心1）の場合
        if (other.gameObject.tag == "E_SJ_SkillAttack1Tag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub1Count += 1;

            decreaseLifeSubImages1();

            if (GSubManager.instance.eAttackSub1Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubScene3_0");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub1Count = 0;
            }
        }


        //SJ（己心2）の場合
        if (other.gameObject.tag == "E_SJ_SkillAttack2Tag" && eAttckInvalid == false)
        {
            //被弾回数をカウント
            GSubManager.instance.eAttackSub2Count += 1;

            decreaseLifeSubImages2();

            if (GSubManager.instance.eAttackSub2Count == 5)
            {
                //リトライ処理
                Invoke("Retry", 0.5f);

                //ゲームオーバ処理
                SceneManager.LoadScene("GameOverSubScene3_0");

                //被弾回数をリセット
                GSubManager.instance.eAttackSub2Count = 0;
            }
        }
    }


    //GameSub2の残機ストックを更新（減少）する関数
    void decreaseLifeSubImages2()
    {
        for (int i = 0; i < lifeSubImages.Length; i++)
        {
            if (GSubManager.instance.eAttackSub2Count <= i)
            {
                //残機のストックを表示
                lifeSubImages[i].SetActive(true);
            }
            else
            {
                //残機のストックを非表示にする
                lifeSubImages[i].SetActive(false);
            }
        }


        //被弾したら一定時間Enemyの攻撃を無効化
        eAttckInvalid = true;

        Invoke("EnemyAttackInvalidFin", 0.5f);
    }
}

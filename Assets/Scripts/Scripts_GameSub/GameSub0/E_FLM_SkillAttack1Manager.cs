using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1Manager : MonoBehaviour
{
    #region//インスペクター設定
    //E_FLM_SkillAttack1_1Prefabを入れる（翔羽）
    public GameObject E_FLM_SkillAttack1_1Prefab;

    //E_FLM_SkillAttack1_2Prefabを入れる（積羽）
    public GameObject E_FLM_SkillAttack1_2Prefab;
    #endregion


    #region//プライベート設定
    //攻撃位置の配列
    private float[] attackPos = { 1.32f, 0.66f, 0.0f, -0.66f, -1.32f };

    //攻撃位置（x座標）
    private float posX;

    //攻撃位置（y座標）
    private float posY;

    //同時攻撃の共通座標
    private float pos;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //FLMの大技1発動を判定
        GManager.instance.FLM_Skill1 = true;

        //難易度によって開始するコルーチンを変更
        if (GManager.instance.easy == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack1_3());
        }
        else if (GManager.instance.nomal == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack1_2());
        }
        else if (GManager.instance.hard == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack1_1());
        }
        else if (GManager.instance.veryHard == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack1_0());
        }
    }


    #region//0:単発移動攻撃（E&W）
    IEnumerator SkillAttack1_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return new WaitForSeconds(2.0f);


        ////単発移動（E&W）
        for (int i = 0; i < 20; i++)
        {
            //E
            posY = attackPos[Random.Range(0, attackPos.Length)];
            E_FLM_SkillAttack1_1_X(4.5f, posY, 90);

            yield return waitHalfS;

            //W
            posY = attackPos[Random.Range(0, attackPos.Length)];
            E_FLM_SkillAttack1_1_X(-4.5f, posY, -90);

            yield return waitHalfS;
        }


        yield return waitOneS;


        StartCoroutine(SkillAttack1_1());
    }
    #endregion

    #region//1:回転攻撃（N）
    IEnumerator SkillAttack1_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////回転
        for (int i = 0; i < 20; i++)
        {
            posX = attackPos[Random.Range(0, attackPos.Length)];
            E_FLM_SkillAttack1_2(posX, 4.5f, 180);

            yield return waitHalfS;
        }


        yield return waitOneHalfS;


        StartCoroutine(SkillAttack1_2());
    }
    #endregion

    #region//2:同時移動攻撃（N&W,S&W,E&S,W&N）
    IEnumerator SkillAttack1_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneHalfS;


        ////同時移動（N&W）
        for (int i = 0; i < 5; i++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            //N
            E_FLM_SkillAttack1_1_Y(pos, 4.5f, 180);
            yield return waitHalfS;

            //W
            E_FLM_SkillAttack1_1_X(4.5f, pos, 90);
            yield return waitHalfS;
        }


        yield return waitHalfS;


        ////同時移動（S&W）
        for (int i = 0; i < 5; i++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            //S
            E_FLM_SkillAttack1_1_Y(pos, -4.5f, 0);
            yield return waitHalfS;

            //W
            E_FLM_SkillAttack1_1_X(-4.5f, pos, -90);
            yield return waitHalfS;
        }


        yield return waitHalfS;


        ////同時移動（E&S）
        for (int i = 0; i < 5; i++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            //E
            E_FLM_SkillAttack1_1_X(4.5f, pos, 90);
            yield return waitHalfS;

            //S
            E_FLM_SkillAttack1_1_Y(pos, -4.5f, 0);
            yield return waitHalfS;
        }


        yield return waitHalfS;


        ////同時移動（W&N）
        for (int i = 0; i < 5; i++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            //W
            E_FLM_SkillAttack1_1_X(-4.5f, pos, -90);
            yield return waitHalfS;

            //N
            E_FLM_SkillAttack1_1_Y(pos, 4.5f, 180);
            yield return waitHalfS;
        }


        yield return waitOneHalfS;


        StartCoroutine(SkillAttack1_3());
    }
    #endregion

    #region//3:回転攻撃（N）
    IEnumerator SkillAttack1_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitHalfS;


        ////回転
        for (int i = 0; i < 20; i++)
        {
            posX = attackPos[Random.Range(0, attackPos.Length)];
            E_FLM_SkillAttack1_2(posX, 4.5f, 180);

            yield return waitHalfS;
        }


        yield return waitOneHalfS;


        StartCoroutine(SkillAttack1_4());
    }
    #endregion

    #region//4:単発移動攻撃（時計回り）
    IEnumerator SkillAttack1_4()
    {
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneHalfS;


        ////単発移動（時計回り・大）
        //E
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(4.5f, attackPos[i], 90);
            yield return new WaitForSeconds(0.3f);
        }

        //S
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(attackPos[i], -4.5f, 0);
            yield return new WaitForSeconds(0.3f);
        }

        //W
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(-4.5f, -attackPos[i], -90);
            yield return new WaitForSeconds(0.3f);
        }

        //N
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(-attackPos[i], 4.5f, 180);
            yield return new WaitForSeconds(0.3f);
        }


        ////単発移動（時計回り・中）
        //E
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(3.3f, attackPos[i], 90);
            yield return new WaitForSeconds(0.3f);
        }

        //S
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(attackPos[i], -3.3f, 0);
            yield return new WaitForSeconds(0.3f);
        }

        //W
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(-3.3f, -attackPos[i], -90);
            yield return new WaitForSeconds(0.3f);
        }

        //N
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(-attackPos[i], 3.3f, 180);
            yield return new WaitForSeconds(0.3f);
        }


        ////単発移動（時計回り・小）
        //E
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(2.1f, attackPos[i], 90);
            yield return new WaitForSeconds(0.3f);
        }

        //S
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(attackPos[i], -2.1f, 0);
            yield return new WaitForSeconds(0.3f);
        }

        //W
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_X(-2.1f, -attackPos[i], -90);
            yield return new WaitForSeconds(0.3f);
        }

        //N
        for (int i = 0; i < attackPos.Length; i++)
        {
            E_FLM_SkillAttack1_1_Y(-attackPos[i], 2.1f, 180);
            yield return new WaitForSeconds(0.3f);
        }


        yield return waitOneHalfS;


        FadeManager.Instance.LoadScene("TalkScene0_4", 0.5f);
    }
    #endregion


    #region//攻撃の処理関数
    //移動羽（N&S）の処理関数
    void E_FLM_SkillAttack1_1_Y(float positionX, float positionY, float angle)
    {
        //移動羽（E_FLM_SkillAttack1_1Prefab）を生成
        Instantiate(E_FLM_SkillAttack1_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack1_1PosY = positionY;
    }

    //移動羽（W&E）の処理関数
    void E_FLM_SkillAttack1_1_X(float positionX, float positionY, float angle)
    {
        //移動羽（E_FLM_SkillAttack1_1Prefab）を生成
        Instantiate(E_FLM_SkillAttack1_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack1_1PosX = positionX;
    }


    //回転羽の処理関数
    void E_FLM_SkillAttack1_2(float positionX, float positionY, float angle)
    {
        //回転大鎌（E_FLM_SkillAttack1_2Prefab）を生成
        Instantiate(E_FLM_SkillAttack1_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }
    #endregion
}

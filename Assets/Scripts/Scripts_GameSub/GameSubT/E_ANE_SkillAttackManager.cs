using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_ANE_SkillAttackManager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_ANE_SkillAttackPrefabを入れる（槍）
    public GameObject E_ANE_SkillAttackPrefab;
    #endregion

    #region//プライベート設定
    //Playerの座標
    private Vector3 player;

    //攻撃位置の配列
    private float[] attackPos0 = { -1.32f, -0.66f, 0.0f, 0.66f, 1.32f };
    private float[] attackPos1 = { -0.66f, 0.0f, 0.66f };

    //攻撃位置（x座標）
    private float posX;

    //攻撃位置（y座標）
    private float posY;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(SkillAttack0());
    }


    #region//0:壱槍（N、S）
    IEnumerator SkillAttack0()
    {
        var waitTwo = new WaitForSeconds(2.0f);


        yield return waitTwo;


        //単槍N
        for (int i = 0; i < 4; i++)
        {
            //攻撃
            posX = attackPos0[Random.Range(0, attackPos0.Length)];
            E_ANE_SkillAttackY(posX, 6.5f, 180);

            yield return waitTwo;
        }


        //単槍S
        for (int i = 0; i < 4; i++)
        {
            //攻撃
            posX = attackPos0[Random.Range(0, attackPos0.Length)];
            E_ANE_SkillAttackY(posX, -6.5f, 0);

            yield return waitTwo;
        }


        yield return waitTwo;


        StartCoroutine(SkillAttack1());
    }
    #endregion

    #region//1:弐槍（W&E）
    IEnumerator SkillAttack1()
    {
        var waitOneS = new WaitForSeconds(1.0f);
        var waitTwo = new WaitForSeconds(2.0f);


        yield return waitOneS;


        //弐槍W&E
        for (int i = 0; i < 4; i++)
        {
            //攻撃W
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_ANE_SkillAttackX(-6.5f, posY, -90, 0.5f, -0.5f);

            yield return waitTwo;

            //攻撃E
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_ANE_SkillAttackX(6.5f, posY, 90, -0.5f, 0.5f);

            yield return waitTwo;
        }


        yield return waitTwo;


        //被弾回数をリセット
        GSubManager.instance.eAttackSub1Count = 0;

        FadeManager.Instance.LoadScene("AvoidanceTurnScene", 0.5f);
    }
    #endregion


    #region//攻撃の処理関数
    //槍（N&S）の処理関数
    void E_ANE_SkillAttackY(float positionX, float positionY, float angle)
    {
        //槍（E_ANE_SkillAttackPrefab）を生成
        Instantiate(E_ANE_SkillAttackPrefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.ANE_SkillAttackPosY = positionY;
    }

    //槍（W&E）の処理関数
    void E_ANE_SkillAttackX(float positionX, float positionY, float angle, float scale0 ,float scale1)
    {
        //槍（E_ANE_SkillAttackPrefab）を生成
        GameObject spear0 = Instantiate(E_ANE_SkillAttackPrefab, new Vector3(positionX, positionY + 0.66f, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成した槍のscaleを変更
        spear0.transform.localScale = new Vector3(scale0, 3.5f, 0.005f);

        //槍（E_ANE_SkillAttackPrefab）を生成
        GameObject spear1 = Instantiate(E_ANE_SkillAttackPrefab, new Vector3(positionX, positionY - 0.66f, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成した槍のscaleを変更
        spear1.transform.localScale = new Vector3(scale1, 3.5f, 0.005f);

        //生成位置を保存
        GSubManager.instance.ANE_SkillAttackPosX = positionX;
    }
    #endregion
}

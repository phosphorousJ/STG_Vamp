using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TT_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_TT_SkillAttack0_1Prefabを入れる（横一文字）
    public GameObject E_TT_SkillAttack0_1Prefab;

    //E_TT_SkillAttack0_2Prefabを入れる（刺突）
    public GameObject E_TT_SkillAttack0_2Prefab;

    //E_TT_SkillAttack0_3Prefabを入れる（刺突斬り）
    public GameObject E_TT_SkillAttack0_3Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //TTの大技0発動を判定
        GManager.instance.TT_Skill0 = true;

        //難易度によって開始するコルーチンを変更
        if (GManager.instance.easy == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack0_3());
        }
        else if (GManager.instance.nomal == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack0_2());
        }
        else if (GManager.instance.hard == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack0_1());
        }
        else if (GManager.instance.veryHard == true)
        {
            //コルーチン開始
            StartCoroutine(SkillAttack0_0());
        }
    }


    #region//0:横一文字N、刺突N、刺突斬りW、刺突斬りE
    IEnumerator SkillAttack0_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return new WaitForSeconds(2.0f);


        //横一文字N
        for (int i = 0; i < 5; i++)
        {
            E_TT_SkillAttack0_1_Y(-0.66f, 4.3f, 180);
            yield return waitHalfS;

            E_TT_SkillAttack0_1_Y(0.66f, 4.3f, 180);
            yield return waitHalfS;
        }


        yield return waitOneS;


        //刺突N
        player = Player.transform.position;
        E_TT_SkillAttack0_2_Y(player.x, 4.3f, 180);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突斬りW
        player = Player.transform.position;
        E_TT_SkillAttack0_3_X(-3.5f, player.y, -90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突斬りE
        player = Player.transform.position;
        E_TT_SkillAttack0_3_X(3.5f, player.y, 90);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();

        StartCoroutine(SkillAttack0_1());
    }
    #endregion

    #region//1:横一文字E、刺突E、横一文字W、刺突W
    IEnumerator SkillAttack0_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;
        

        //横一文字E
        for (int i = 0; i < 5; i++)
        {
            E_TT_SkillAttack0_1_X(4.3f, -0.66f, 90);
            yield return waitHalfS;

            E_TT_SkillAttack0_1_X(4.3f, 0.66f, 90);
            yield return waitHalfS;
        }


        yield return waitOneS;


        //刺突E
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(4.3f, player.y, 90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //横一文字W
        for (int i = 0; i < 5; i++)
        {
            E_TT_SkillAttack0_1_X(-4.3f, -0.66f, -90);
            yield return waitHalfS;

            E_TT_SkillAttack0_1_X(-4.3f, 0.66f, -90);
            yield return waitHalfS;
        }


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突W
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(-4.3f, player.y, -90);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();

        StartCoroutine(SkillAttack0_2());
    }
    #endregion

    #region//2:刺突W、刺突斬りS、刺突斬りN、刺突E
    IEnumerator SkillAttack0_2()
    {
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        //刺突W
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(-4.3f, player.y, -90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突斬りS
        player = Player.transform.position;
        E_TT_SkillAttack0_3_Y(player.x, -3.5f, 0);


        yield return waitOneHalfS;
        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突斬りN
        player = Player.transform.position;
        E_TT_SkillAttack0_3_Y(player.x, 3.5f, 180);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //刺突E
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(4.3f, player.y, 90);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();

        StartCoroutine(SkillAttack0_3());
    }
    #endregion

    #region//3:横一文字E、刺突E、横一文字S、参命剣S、参命剣W、参命剣N
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        //横一文字E
        for (int i = 0; i < 5; i++)
        {
            E_TT_SkillAttack0_1_X(4.3f, -0.66f, 90);
            yield return waitHalfS;

            E_TT_SkillAttack0_1_X(4.3f, 0.66f, 90);
            yield return waitHalfS;
        }


        yield return waitOneS;


        //刺突E
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(4.3f, player.y, 90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //横一文字S
        for (int i = 0; i < 5; i++)
        {
            E_TT_SkillAttack0_1_Y(-0.66f, -4.3f, 0);
            yield return waitHalfS;

            E_TT_SkillAttack0_1_Y(0.66f, -4.3f, 0);
            yield return waitHalfS;
        }


        yield return waitOneS;


        //参命剣S
        player = Player.transform.position;
        E_TT_SkillAttack0_2_Y(player.x - 0.66f, -4.3f, 0);
        E_TT_SkillAttack0_2_Y(player.x, -4.3f, 0);
        E_TT_SkillAttack0_2_Y(player.x + 0.66f, -4.3f, 0);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //参命剣W
        player = Player.transform.position;
        E_TT_SkillAttack0_2_X(-4.3f, player.y - 0.66f, -90);
        E_TT_SkillAttack0_2_X(-4.3f, player.y, -90);
        E_TT_SkillAttack0_2_X(-4.3f, player.y + 0.66f, -90);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();


        //参命剣N
        player = Player.transform.position;
        E_TT_SkillAttack0_2_Y(player.x - 0.66f, 4.3f, 180);
        E_TT_SkillAttack0_2_Y(player.x, 4.3f, 180);
        E_TT_SkillAttack0_2_Y(player.x + 0.66f, 4.3f, 180);


        yield return waitOneS;

        //生成位置をリセット
        E_TT_SkillAttack0Reset();

        FadeManager.Instance.LoadScene("GameScene1_0", 0.5f);
    }
    #endregion


    #region//攻撃の処理関数
    //横一文字（N&S）の処理関数
    void E_TT_SkillAttack0_1_Y(float positionX, float positionY, float angle)
    {
        //横一文字（E_TT_SkillAttack0_1Prefab）を生成
        Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_1PosY = positionY;
    }

    //横一文字（W&E）の処理関数
    void E_TT_SkillAttack0_1_X(float positionX, float positionY, float angle)
    {
        //横一文字（E_TT_SkillAttack0_1Prefab）を生成
        Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_1PosX = positionX;
    }


    //刺突（N&S）の処理関数
    void E_TT_SkillAttack0_2_Y(float positionX,float positionY,float angle)
    {
        //刺突（E_TT_SkillAttack0_2Prefab）を生成
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_2PosY = positionY;
    }

    //刺突（W&E）の処理関数
    void E_TT_SkillAttack0_2_X(float positionX, float positionY, float angle)
    {
        //刺突（E_TT_SkillAttack0_2Prefab）を生成
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_2PosX = positionX;
    }


    //刺突斬り（N&S）の処理関数
    void E_TT_SkillAttack0_3_Y(float positionX, float positionY, float angle)
    {
        //刺突斬り（E_TT_SkillAttack0_3Prefab）を生成
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_3PosY = positionY;
    }

    //刺突斬り（W&E）の処理関数
    void E_TT_SkillAttack0_3_X(float positionX, float positionY, float angle)
    {
        //刺突斬り（E_TT_SkillAttack0_3Prefab）を生成
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.TT_SkillAttack0_3PosX = positionX;
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_TT_SkillAttack0Reset()
    {
        //刺突、刺突斬りが途中で破棄されるのを防止
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;
    }
    #endregion
}
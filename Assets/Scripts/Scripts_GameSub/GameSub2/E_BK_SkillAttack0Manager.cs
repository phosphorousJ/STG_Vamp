using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_BK_SkillAttack0_0Prefabを入れる（スタンプ予告）
    public GameObject E_BK_SkillAttack0_0Prefab;

    //E_BK_SkillAttack0_1Prefabを入れる（パンチ）
    public GameObject E_BK_SkillAttack0_1Prefab;

    //E_BK_SkillAttack0_2Prefabを入れる（スタンプ本体）
    public GameObject E_BK_SkillAttack0_2Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //BKの大技0発動を判定
        GManager.instance.BK_Skill0 = true;

        //難易度によって開始するコルーチンを変更
        if (GManager.instance.easy == true)
        {
            StartCoroutine(SkillAttack0_3());
        }
        else if (GManager.instance.nomal == true)
        {
            StartCoroutine(SkillAttack0_2());
        }
        else if (GManager.instance.hard == true)
        {
            StartCoroutine(SkillAttack0_1());
        }
        else if (GManager.instance.veryHard == true)
        {
            StartCoroutine(SkillAttack0_0());
        }
    }


    #region//0:パンチS、パンチN、パンチW、パンチW、パンチE、パンチN、パンチN
    IEnumerator SkillAttack0_0()
    {
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return new WaitForSeconds(2.0f);


        ////パンチS
        player = Player.transform.position;
        E_BK_SkillAttack0_1_Y(player.x, -3.55f, 0);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();
        

        ////パンチN
        player = Player.transform.position;
        E_BK_SkillAttack0_1_Y(player.x, 3.55f, 180);
        

        yield return waitOneHalfS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();
        

        for (int i = 0; i < 2; i++)
        {
            ////パンチW
            player = Player.transform.position;
            E_BK_SkillAttack0_1_X(-3.55f, player.y, -90);


            yield return waitOneHalfS;

            //生成位置をリセット
            E_BK_SkillAttack0Reset();
        }


        ////パンチE
        player = Player.transform.position;
        E_BK_SkillAttack0_1_X(3.55f, player.y, 90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();
        

        for (int i = 0; i < 2; i++)
        {
            ////パンチN
            player = Player.transform.position;
            E_BK_SkillAttack0_1_Y(player.x, 3.55f, 180);


            yield return waitOneHalfS;

            //生成位置をリセット
            E_BK_SkillAttack0Reset();
        }


        StartCoroutine(SkillAttack0_1());
    }
    #endregion

    #region//1:パンチNN、パンチEE、パンチWW、パンチSE、パンチNW、パンチNE、パンチSW
    IEnumerator SkillAttack0_1()
    {
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////パンチNN
        E_BK_SkillAttack0_1_Y(-1.0f, 3.55f, 180);
        E_BK_SkillAttack0_1_Y(1.0f, 3.55f, 180);


        yield return waitOneHalfS;


        ////パンチEE
        E_BK_SkillAttack0_1_X(3.55f, 1.0f, 90);
        E_BK_SkillAttack0_1_X(3.55f, -0.35f, 90);


        yield return waitOneHalfS;

        
        ////パンチWW
        E_BK_SkillAttack0_1_X(-3.55f, 1.0f, -90);
        E_BK_SkillAttack0_1_X(-3.55f, -1.0f, -90);

        
        yield return waitOneHalfS;


        ////パンチSE
        E_BK_SkillAttack0_1_Y(0.0f, -3.55f, 0);
        E_BK_SkillAttack0_1_X(3.55f, 0.0f, 90);


        yield return waitOneHalfS;


        ////パンチNW
        E_BK_SkillAttack0_1_Y(1.0f, 3.55f, 180);
        E_BK_SkillAttack0_1_X(-3.55f, -0.35f, -90);

        
        yield return waitOneHalfS;


        ////パンチNE
        E_BK_SkillAttack0_1_Y(-1.0f, 3.55f, 180);
        E_BK_SkillAttack0_1_X(3.55f, 1.0f, 90);


        yield return waitOneHalfS;


        ////パンチSW
        E_BK_SkillAttack0_1_Y(0.35f, -3.55f, 0);
        E_BK_SkillAttack0_1_X(-3.55f, -1.0f, -90);


        yield return waitOneS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_2());
    }
    #endregion

    #region//2:スタンプS、スタンプN、スタンプEW、スタンプSS、スタンプNN、スタンプEEE
    IEnumerator SkillAttack0_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////スタンプS
        //予告
        player = Player.transform.position;
        E_BK_SkillAttack0_0(player.x, player.y, 0);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, 0);


        yield return waitOneS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();
        

        ////スタンプN
        //予告
        player = Player.transform.position;
        E_BK_SkillAttack0_0(player.x, player.y, 180);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, 180);


        yield return waitOneS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();


        ////スタンプEW
        //予告
        E_BK_SkillAttack0_0(0.9f, 0.0f, 90);
        E_BK_SkillAttack0_0(-0.9f, 0.0f, -90);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(0.9f, 0.0f, 90);
        E_BK_SkillAttack0_2(-0.9f, 0.0f, -90);


        yield return waitOneS;


        ////スタンプSS
        //予告
        E_BK_SkillAttack0_0(-0.35f, 0.65f, 0);
        E_BK_SkillAttack0_0(0.35f, -0.65f, 0);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(-0.35f, 0.65f, 0);
        E_BK_SkillAttack0_2(0.35f, -0.65f, 0);

        
        yield return waitOneS;


        ////スタンプNN
        //予告
        E_BK_SkillAttack0_0(0.65f, 0.65f, 180);
        E_BK_SkillAttack0_0(-0.65f, -0.65f, 180);
        
        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(0.65f, 0.65f, 180);
        E_BK_SkillAttack0_2(-0.65f, -0.65f, 180);

        
        yield return waitOneS;


        ////スタンプEEE
        //予告
        E_BK_SkillAttack0_0(-0.65f, 0.85f, 90);
        E_BK_SkillAttack0_0(-0.65f, -0.85f, 90);
        E_BK_SkillAttack0_0(0.65f, 0.0f, 90);
        
        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack0_2(-0.65f, 0.85f, 90);
        E_BK_SkillAttack0_2(-0.65f, -0.85f, 90);
        E_BK_SkillAttack0_2(0.65f, 0.0f, 90);


        yield return waitOneS;


        StartCoroutine(SkillAttack0_3());
    }
    #endregion

    #region//3:パンチS、スタンプ連打S、パンチW、スタンプ連打W、パンチSE、スタンプ連打N、パンチNW
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////パンチS
        player = Player.transform.position;
        E_BK_SkillAttack0_1_Y(player.x, -3.55f, 0);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();


        ////スタンプ連打S
        for (int i = 0;i < 10; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack0_0(player.x, player.y, 0);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack0_2(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, 0);


            yield return waitHalfS;
        }


        ////パンチW
        player = Player.transform.position;
        E_BK_SkillAttack0_1_X(-3.55f, player.y, -90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();


        ////スタンプ連打W
        for (int i = 0; i < 10; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack0_0(player.x, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack0_2(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -90);

            
            yield return waitHalfS;
        }


        ////パンチSE
        E_BK_SkillAttack0_1_Y(0.0f, -3.55f, 0);
        E_BK_SkillAttack0_1_X(3.55f, 0.0f, 90);

        
        yield return waitOneHalfS;


        ////スタンプ連打N
        for (int i = 0; i < 10; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack0_0(player.x, player.y, 180);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack0_2(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, 180);


            yield return waitHalfS;
        }


        ////パンチNE
        E_BK_SkillAttack0_1_Y(-1.0f, 3.55f, 180);
        E_BK_SkillAttack0_1_X(3.55f, 1.0f, 90);

        
        yield return waitOneS;

        //生成位置をリセット
        E_BK_SkillAttack0Reset();


        FadeManager.Instance.LoadScene("GameScene2_0", 0.5f);
    }
    #endregion


    #region//攻撃の処理関数
    //パンチ（N&S）の処理関数
    void E_BK_SkillAttack0_1_Y(float positionX, float positionY, float angle)
    {
        //パンチ（E_BK_SkillAttack0_1Prefab）を生成
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack0_1PosY = positionY;
    }

    //パンチ（W&E）の処理関数
    void E_BK_SkillAttack0_1_X(float positionX, float positionY, float angle)
    {
        //パンチ（E_BK_SkillAttack0_1Prefab）を生成
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack0_1PosX = positionX;
    }


    //スタンプ（予告）の処理関数
    void E_BK_SkillAttack0_0(float positionX, float positionY, float angle)
    {
        //スタンプ予告（E_BK_SkillAttack0_0Prefab）を生成
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack0_2PosX = positionX;
        GSubManager.instance.BK_SkillAttack0_2PosY = positionY;
    }


    //スタンプ（本体）の処理関数
    void E_BK_SkillAttack0_2(float positionX, float positionY, float angle)
    {
        //スタンプ本体（E_BK_SkillAttack0_2Prefab）を生成
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_BK_SkillAttack0Reset()
    {
        //パンチが途中で破棄されるのを防止
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
    }
    #endregion
}

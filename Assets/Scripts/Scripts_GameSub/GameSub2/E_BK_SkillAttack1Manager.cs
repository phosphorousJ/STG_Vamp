using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack1Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_BK_SkillAttack1_0_2Prefabを入れる（パンチ予告）
    public GameObject E_BK_SkillAttack1_0_2Prefab;

    //E_BK_SkillAttack1_0_3Prefabを入れる（キック予告）
    public GameObject E_BK_SkillAttack1_0_3Prefab;

    //E_BK_SkillAttack1_1Prefabを配列に入れる（水晶5色）
    public GameObject[] E_BK_SkillAttacks1 = new GameObject[4];

    //E_BK_SkillAttack1_2Prefabを入れる（パンチ本体）
    public GameObject E_BK_SkillAttack1_2Prefab;

    //E_BK_SkillAttack1_3Prefabを入れる（キック本体）
    public GameObject E_BK_SkillAttack1_3Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;

    //攻撃位置の配列
    private float[] attackPos = { 1.32f, 0.66f, 0.0f, -0.66f, -1.32f };
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //BKの大技1発動を判定
        GManager.instance.BK_Skill1 = true;

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


    # region//0:スタンプ連打S、水晶S×4、水晶E×4、スタンプ連打W、水晶W×4、水晶N×4
    IEnumerator SkillAttack1_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return new WaitForSeconds(2.0f);


        ////スタンプ連打S
        for (int i = 0; i < 10; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack1_0_2(player.x, player.y, 0);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack1_2(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, 0);

            
            yield return waitHalfS;
        }


        ////水晶S×4
        E_BK_SkillAttacks1_1_Y(-1.32f, -0.66f, 0.0f, 0.66f, -4.2f, 0);


        yield return waitOneS;


        ////水晶E×4
        E_BK_SkillAttacks1_1_X(4.2f, -1.32f, -0.66f, 0.0f, 0.66f, 90);


        yield return waitOneS;


        ////スタンプ連打W
        for (int i = 0; i < 10; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack1_0_2(player.x, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack1_2(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -90);

            
            yield return waitHalfS;
        }


        ////水晶W×4
        E_BK_SkillAttacks1_1_X(-4.2f, -1.32f, -0.66f, 0.66f, 1.32f, -90);


        yield return waitOneS;


        ////水晶N×4
        E_BK_SkillAttacks1_1_Y(-1.32f, 0.0f, 0.66f, 1.32f, 4.2f, 180);

        
        yield return waitOneS;


        StartCoroutine(SkillAttack1_1());
    }
    #endregion

    #region//1:水晶（時計回り）
    IEnumerator SkillAttack1_1()
    {
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////水晶(時計回り・大)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(4.2f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -4.2f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-4.2f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 4.2f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        ////水晶(時計回り・中)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(2.8f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -2.8f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-2.8f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 2.8f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        ////水晶(時計回り・小)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(1.4f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -1.4f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-1.4f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 1.4f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        yield return waitOneS;


        StartCoroutine(SkillAttack1_2());
    }
    #endregion

    #region//2:キックN、水晶N,キックE、スタンプE、キックW、水晶W、キックS、水晶S
    IEnumerator SkillAttack1_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneHalfS;


        ////キックN
        //予告
        E_BK_SkillAttack1_0_3(-0.66f, 0.0f, 180);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack1_3(-0.66f, 0.0f, 180);


        yield return waitOneS;


        ////水晶N
        for (int i = 0; i < 26; i++)
        {
            E_BK_SkillAttack1_1_Y(0.66f, 4.2f, 180);

            yield return new WaitForSeconds(0.25f);

            E_BK_SkillAttack1_1_Y(1.32f, 4.2f, 180);

            yield return new WaitForSeconds(0.25f);            
        }


        yield return waitOneS;


        ////キックE
        //予告
        E_BK_SkillAttack1_0_3(0.0f, -0.66f, 90);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack1_3(0.0f, -0.66f, 90);

        
        yield return waitOneS;
        

        ////スタンプ連打E
        for (int i = 0; i < 13; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack1_0_2(player.x, player.y, 90);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack1_2(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, 90);

            
            yield return waitHalfS;
        }


        yield return waitOneHalfS;


        ////キックW
        //予告
        E_BK_SkillAttack1_0_3(0.0f, 0.66f, -90);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack1_3(0.0f, 0.66f, -90);

        
        yield return waitOneS;
        

        ////スタンプ連打W
        for (int i = 0; i < 13; i++)
        {
            //予告
            player = Player.transform.position;
            E_BK_SkillAttack1_0_2(player.x, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_BK_SkillAttack1_2(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -90);


            yield return waitHalfS;
        }


        yield return waitOneHalfS;


        ////キックS
        //予告
        E_BK_SkillAttack1_0_3(0.66f, 0.0f, 0);

        //攻撃
        yield return waitHalfS;
        E_BK_SkillAttack1_3(0.66f, 0.0f, 0);

       
        yield return waitOneS;
       

        ////水晶N
        for (int i = 0; i < 26; i++)
        {
            E_BK_SkillAttack1_1_Y(-0.66f, -4.2f, 0);

            yield return new WaitForSeconds(0.25f);

            E_BK_SkillAttack1_1_Y(-1.32f, -4.2f, 0);

            yield return new WaitForSeconds(0.25f);
        }


        yield return waitOneS;

        
        StartCoroutine(SkillAttack1_3());
    }
    #endregion

    #region//3:水晶（反時計回り）
    IEnumerator SkillAttack1_3()
    {
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////水晶(反時計回り・大)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-4.2f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -4.2f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(4.2f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 4.2f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        ////水晶(反時計回り・中)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-2.8f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -2.8f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(2.8f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 2.8f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        ////水晶(反時計回り・小)
        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶W
            E_BK_SkillAttack1_1_X(-1.4f, -attackPos[i], -90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶S
            E_BK_SkillAttack1_1_Y(attackPos[i], -1.4f, 0);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶E
            E_BK_SkillAttack1_1_X(1.4f, attackPos[i], 90);

            yield return new WaitForSeconds(0.3f);
        }

        for (int i = 0; i < attackPos.Length; i++)
        {
            //水晶N
            E_BK_SkillAttack1_1_Y(-attackPos[i], 1.4f, 180);

            yield return new WaitForSeconds(0.3f);
        }


        yield return waitOneS;


        FadeManager.Instance.LoadScene("TalkScene2_4", 0.5f);
    }
    #endregion


    #region//攻撃の処理関数
    //水晶（N&S）の処理関数
    void E_BK_SkillAttack1_1_Y(float positionX, float positionY, float angle)
    {
        //水晶（E_BK_SkillAttack1_1Prefab）を生成
        GameObject E_BK_SkillAttack1_1_YPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
        Instantiate(E_BK_SkillAttack1_1_YPrefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack1_1PosY = positionY;
    }

    //水晶（W&E）の処理関数
    void E_BK_SkillAttack1_1_X(float positionX, float positionY, float angle)
    {
        //水晶（E_BK_SkillAttack1_1Prefab）を生成
        GameObject E_BK_SkillAttack1_1_XPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
        Instantiate(E_BK_SkillAttack1_1_XPrefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack1_1PosX = positionX;
    }

    //水晶×4（N&S）の処理関数
    void E_BK_SkillAttacks1_1_Y(float positionX_0, float positionX_1, float positionX_2, float positionX_3, float positionY,float angle)
    {
        //水晶（E_BK_SkillAttack1_1Prefab）を生成
        GameObject E_BK_SkillAttacks1_1_YPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
        Instantiate(E_BK_SkillAttacks1_1_YPrefab, new Vector3(positionX_0, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_YPrefab, new Vector3(positionX_1, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_YPrefab, new Vector3(positionX_2, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_YPrefab, new Vector3(positionX_3, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack1_1PosY = positionY;
    }

    //水晶×4（W&E）の処理関数
    void E_BK_SkillAttacks1_1_X(float positionX, float positionY_0, float positionY_1, float positionY_2, float positionY_3, float angle)
    {
        //水晶（E_BK_SkillAttack1_1Prefab）を生成
        GameObject E_BK_SkillAttacks1_1_XPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
        Instantiate(E_BK_SkillAttacks1_1_XPrefab, new Vector3(positionX, positionY_0, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_XPrefab, new Vector3(positionX, positionY_1, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_XPrefab, new Vector3(positionX, positionY_2, -0.05f), Quaternion.Euler(0, 0, angle));
        Instantiate(E_BK_SkillAttacks1_1_XPrefab, new Vector3(positionX, positionY_3, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack1_1PosX = positionX;
    }


    //スタンプ（予告）の処理関数
    void E_BK_SkillAttack1_0_2(float positionX, float positionY, float angle)
    {
        //スタンプ予告（E_BK_SkillAttack1_0_2Prefab）を生成
        Instantiate(E_BK_SkillAttack1_0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.BK_SkillAttack1_2PosX = positionX;
        GSubManager.instance.BK_SkillAttack1_2PosY = positionY;
    }


    //スタンプ（本体）の処理関数
    void E_BK_SkillAttack1_2(float positionX, float positionY, float angle)
    {
        //スタンプ本体（E_BK_SkillAttack1_2Prefab）を生成
        Instantiate(E_BK_SkillAttack1_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //キック（予告）の処理関数
    void E_BK_SkillAttack1_0_3(float positionX, float positionY, float angle)
    {
        //キック予告（E_BK_SkillAttack1_0_3Prefab）を生成
        Instantiate(E_BK_SkillAttack1_0_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //キック（本体）の処理関数
    void E_BK_SkillAttack1_3(float positionX, float positionY, float angle)
    {
        //キック本体（E_BK_SkillAttack1_3Prefab）を生成
        Instantiate(E_BK_SkillAttack1_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }
    #endregion
}

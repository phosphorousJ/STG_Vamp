using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJ_SkillAttack2Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_SJ_SkillAttack2_0_0Prefabを入れる（力チャージ小）
    public GameObject E_SJ_SkillAttack2_0_0Prefab;

    //E_SJ_SkillAttack2_0_1Prefabを入れる（力チャージ大）
    public GameObject E_SJ_SkillAttack2_0_1Prefab;

    //E_SJ_SkillAttack2_0Prefabを入れる（流チャージ）
    public GameObject E_SJ_SkillAttack2_0Prefab;

    //E_SJ_SkillAttack2_1Prefabを入れる（四貫）
    public GameObject E_SJ_SkillAttack2_1Prefab;

    //E_SJ_SkillAttack2_2Prefabを入れる（回撃）
    public GameObject E_SJ_SkillAttack2_2Prefab;

    //E_SJ_SkillAttack2_3Prefabを入れる（光線）
    public GameObject E_SJ_SkillAttack2_3Prefab;

    //E_SJ_SkillAttack2_4Prefabを入れる（光滞）
    public GameObject E_SJ_SkillAttack2_4Prefab;

    //E_SJ_SkillAttack2_5Prefabを入れる（直流）
    public GameObject E_SJ_SkillAttack2_5Prefab;

    //E_SJ_SkillAttack2_6Prefabを入れる（鉛直万鈞）
    public GameObject E_SJ_SkillAttack2_6Prefab;

    //E_SJ_SkillAttack2_7Prefabを入れる（回転万鈞）
    public GameObject E_SJ_SkillAttack2_7Prefab;

    //E_SJ_SkillAttack2_8Prefabを入れる（四方万鈞）
    public GameObject E_SJ_SkillAttack2_8Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;

    //攻撃位置の配列
    private float[] attackPos0 = { -1.32f, -0.66f, 0.0f, 0.66f, 1.32f };
    private float[] attackPos1 = { 0.0f, 0.66f, 1.32f };
    private float[] attackPos2 = { 0.66f, 1.32f };

    //攻撃位置（x座標）
    private float posX;

    //攻撃位置（y座標）
    private float posY;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //SJの大技2発動を判定
        GManager.instance.SJ_Skill2 = true;

        //コルーチン開始
        StartCoroutine(SkillAttack2_0());
    }


    #region//0:四貫
    IEnumerator SkillAttack2_0()
    {
        var waitOneS = new WaitForSeconds(1.0f);


        yield return new WaitForSeconds(2.0f);


        ////四貫
        for (int i = 0; i < 10; i++)
        {
            player = Player.transform.position;
            //力チャージ小S&N
            E_SJ_SkillAttack2_0_0_Y(player.x, -4.7f, 0, player.x, 4.7f, 180);
            //力チャージ小W&E
            E_SJ_SkillAttack2_0_0_X(-4.7f, player.y, -90, 4.7f, player.y, 90);

            yield return new WaitForSeconds(0.3f);
            //攻撃S&N
            E_SJ_SkillAttack2_1_Y(GSubManager.instance.SJ_SkillAttack2_1_SPosX, -5.5f, 0, GSubManager.instance.SJ_SkillAttack2_1_NPosX, 5.5f, 180);
            //攻撃W&E
            E_SJ_SkillAttack2_1_X(-5.5f, GSubManager.instance.SJ_SkillAttack2_1_WPosY, -90, 5.5f, GSubManager.instance.SJ_SkillAttack2_1_EPosY, 90);
            
            
            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }


        yield return waitOneS;


        StartCoroutine(SkillAttack2_1());
    }
    #endregion

    #region//1:回撃S&N(追尾)、回撃S&N(追尾)＋光線S&N、光線W(追尾)、光線W×2
    IEnumerator SkillAttack2_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////回撃S&N(追尾)
        for (int i = 0; i < 3; i++)
        {
            //力チャージ小S
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, -4.7f, 0);

            //攻撃S
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_2(GSubManager.instance.SJ_SkillAttack2_2PosX, -7.0f, 0);

            yield return new WaitForSeconds(4.5f);
            
            //力チャージ小N
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, 4.7f, 180);

            //攻撃N
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_2(GSubManager.instance.SJ_SkillAttack2_2PosX, 7.0f, 180);

            yield return new WaitForSeconds(4.5f);
        }


        ////回撃S&N(追尾)＋光線S&N
        for (int i = 0; i < 2; i++)
        {
            //力チャージ小S
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, -4.7f, 0);

            //回撃S
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_2(GSubManager.instance.SJ_SkillAttack2_2PosX, -7.0f, 0);

            yield return new WaitForSeconds(4.5f);

            //力チャージ大
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_1(player.x, -4.7f, 0);

            //光線S
            yield return new WaitForSeconds(0.4f);
            E_SJ_SkillAttack2_3(GSubManager.instance.SJ_SkillAttack2_3PosX, 0.0f, 0);

            yield return waitHalfS;

            //力チャージ小N
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, 4.7f, 180);

            //回撃N
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_2(GSubManager.instance.SJ_SkillAttack2_2PosX, 7.0f, 180);

            yield return new WaitForSeconds(4.5f);

            //力チャージ
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_1(player.x, 4.7f, 180);

            //光線N
            yield return new WaitForSeconds(0.4f);
            E_SJ_SkillAttack2_3(GSubManager.instance.SJ_SkillAttack2_3PosX, 0.0f, 180);

            yield return waitHalfS;
        }


        yield return waitHalfS;


        ////光線W(追尾)
        //力チャージ大
        player = Player.transform.position;
        E_SJ_SkillAttack2_0_1(-4.7f, player.y, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack2_3(0.0f, GSubManager.instance.SJ_SkillAttack2_3PosY, -90);


        yield return waitOneS;


        ////光線W×2
        //力チャージ大
        E_SJ_SkillAttack2_0_1(-4.7f, -0.33f, -90);
        E_SJ_SkillAttack2_0_1(-4.7f, 0.99f, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack2_3(0.0f, -0.33f, -90);
        E_SJ_SkillAttack2_3(0.0f, 0.99f, -90);


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack2Reset();


        StartCoroutine(SkillAttack2_2());
    }
    #endregion

    #region//2:境撃E(光滞E＋直流N&EW)、境撃E(光滞E＋直流S&S×2&S×3&E&W×2)、光線S×2、境撃N(光滞N＋直流N&光線N)
    IEnumerator SkillAttack2_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
      

        yield return waitOneS;


        ////境撃E(光滞E＋直流N&EW)
        //力チャージ大E
        E_SJ_SkillAttack2_0_1(4.7f, -0.99f, 90);

        //光滞E
        yield return waitHalfS;
        E_SJ_SkillAttack2_4(0.0f, -0.99f, 90);

        yield return waitOneS;

        for (int i = 0; i < 6; i++)
        {
            //流チャージ
            posX = attackPos0[Random.Range(0, attackPos0.Length)];
            E_SJ_SkillAttack2_0(posX, 4.7f, 180);

            //直流N
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_5_Y(GSubManager.instance.SJ_SkillAttack2_5PosX, 5.5f, 180);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }

        yield return new WaitForSeconds(0.3f);

        for (int i = 0; i < 4; i++)
        {
            //流チャージ
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack2_0(4.7f, posY, 90);

            //直流E
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_5_X(5.5f, GSubManager.instance.SJ_SkillAttack2_5PosY, 90);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
            

            //流チャージ
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack2_0(-4.7f, posY, -90);

            //直流W
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_5_X(-5.5f, GSubManager.instance.SJ_SkillAttack2_5PosY, -90);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }


        yield return waitHalfS;


        ////境撃E(光滞E＋直流S&S×2&S×3&E&W×2)
        //力チャージ大E
        E_SJ_SkillAttack2_0_1(4.7f, 0.99f, 90);

        //光滞E
        yield return waitHalfS;
        E_SJ_SkillAttack2_4(0.0f, 0.99f, 90);

        yield return waitOneS;

        for (int i = 0; i < 10; i++)
        {
            //流チャージS
            posX = attackPos0[Random.Range(0, attackPos0.Length)];
            E_SJ_SkillAttack2_0(posX, -4.7f, 0);

            //直流S
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_5_Y(GSubManager.instance.SJ_SkillAttack2_5PosX, -5.5f, 0);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }

        //流チャージS×2
        E_SJ_SkillAttack2_0(-0.66f, -4.7f, 0);
        E_SJ_SkillAttack2_0(0.66f, -4.7f, 0);

        //直流S
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack2_5_Y(-0.66f, -5.5f, 0);
        E_SJ_SkillAttack2_5_Y(0.66f, -5.5f, 0);

        yield return new WaitForSeconds(0.3f);

        //流チャージS×3
        E_SJ_SkillAttack2_0(-1.32f, -4.7f, 0);
        E_SJ_SkillAttack2_0(0.0f, -4.7f, 0);
        E_SJ_SkillAttack2_0(1.32f, -4.7f, 0);

        //直流S
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack2_5_Y(-1.32f, -5.5f, 0);
        E_SJ_SkillAttack2_5_Y(0.0f, -5.5f, 0);
        E_SJ_SkillAttack2_5_Y(1.32f, -5.5f, 0);

        yield return new WaitForSeconds(0.3f);

        //流チャージE
        E_SJ_SkillAttack2_0(4.7f, -0.66f, 90);
        
        //直流E
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack2_5_X(5.5f, -0.66f, 90);

        yield return new WaitForSeconds(0.3f);

        //流チャージW×2
        E_SJ_SkillAttack2_0(-4.7f, -1.32f, -90);
        E_SJ_SkillAttack2_0(-4.7f, 0.0f, -90);

        //直流W
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack2_5_X(-5.5f, -1.32f, -90);
        E_SJ_SkillAttack2_5_X(-5.5f, 0.0f, -90);


        yield return waitHalfS;


        ////光線S×2
        //力チャージ大
        E_SJ_SkillAttack2_0_1(-0.99f, -4.7f, 0);
        E_SJ_SkillAttack2_0_1(0.33f, -4.7f, 0);

        //光線S
        yield return new WaitForSeconds(0.4f);
        E_SJ_SkillAttack2_3(-0.99f, 0.0f, 0);
        E_SJ_SkillAttack2_3(0.33f, 0.0f, 0);


        yield return waitOneS;


        ////境撃N(光滞N＋直流N&光線N)
        //力チャージ大N
        E_SJ_SkillAttack2_0_1(-0.33f, 4.7f, 180);

        //光滞N
        yield return new WaitForSeconds(0.8f);
        E_SJ_SkillAttack2_4(-0.33f, 0.0f, 180);

        yield return waitOneS;

        for (int i = 0; i < 12; i++)
        {
            //流チャージN
            posX = attackPos2[Random.Range(0, attackPos2.Length)];
            Instantiate(E_SJ_SkillAttack2_0Prefab, new Vector3(posX, 4.7f, -0.05f), Quaternion.Euler(0, 0, 180));//直流N
            GSubManager.instance.SJ_SkillAttack2_5PosX = posX;

            //直流N
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack2_5_Y(GSubManager.instance.SJ_SkillAttack2_5PosX, 5.5f, 180);


            yield return new WaitForSeconds(0.3f);
            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }

        yield return new WaitForSeconds(0.3f);

        //力チャージ大N
        E_SJ_SkillAttack2_0_1(0.99f, 4.7f, 180);

        //光線N
        yield return new WaitForSeconds(0.8f);
        E_SJ_SkillAttack2_3(0.99f, 0.0f, 180);


        yield return waitOneS;


        StartCoroutine(SkillAttack2_3());
    }
    #endregion

    #region//3:鉛直万鈞N&S(追尾)、回転万鈞E&W(追尾)、四方万鈞(NE&SW＋反時計回り)
    IEnumerator SkillAttack2_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
       

        yield return waitOneS;


        ////鉛直万鈞N&S(追尾)
        for (int i = 0; i < 5; i++)
        {
            //力チャージ小
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, 4.7f, 180);

            //鉛直万鈞N
            yield return new WaitForSeconds(0.25f);
            E_SJ_SkillAttack2_6(GSubManager.instance.SJ_SkillAttack2_6PosX, 7.0f, 180);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
            

            //力チャージ小
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, -4.7f, 0);

            //鉛直万鈞S
            yield return new WaitForSeconds(0.25f);
            E_SJ_SkillAttack2_6(GSubManager.instance.SJ_SkillAttack2_6PosX, -7.0f, 0);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }


        yield return waitHalfS;


        ////回転万鈞E&W(追尾)
        for (int i = 0; i < 5; i++)
        {
            //力チャージ小E
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(4.7f, player.y, 90);

            //回転万鈞E
            yield return waitHalfS;
            E_SJ_SkillAttack2_7(7.0f, GSubManager.instance.SJ_SkillAttack2_7PosY, 90);
            

            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
            

            //力チャージ小W
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(-4.7f, player.y, -90);

            //回転万鈞W
            yield return waitHalfS;
            E_SJ_SkillAttack2_7(-7.0f, GSubManager.instance.SJ_SkillAttack2_7PosY, -90);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }


        yield return waitOneS;


        ////四方万鈞(NE&SW＋反時計回り)
        for (int i = 0; i < 4; i++)
        {
            //力チャージ小NE
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, 4.7f, 180);
            E_SJ_SkillAttack2_0_0(4.7f, player.y, 90);

            //鉛直万鈞N、回転万鈞E
            yield return new WaitForSeconds(0.25f);
            E_SJ_SkillAttack2_6(player.x, 7.0f, 180);
            E_SJ_SkillAttack2_7(7.0f, player.y, 90);


            yield return waitHalfS;

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();


            //力チャージ小SW
            player = Player.transform.position;
            E_SJ_SkillAttack2_0_0(player.x, -4.7f, 0);
            E_SJ_SkillAttack2_0_0(-4.7f, player.y, -90);

            //鉛直万鈞S、回転万鈞W
            yield return new WaitForSeconds(0.25f);
            E_SJ_SkillAttack2_6(player.x, -7.0f, 0);
            E_SJ_SkillAttack2_7(-7.0f, player.y, -90);


            yield return waitHalfS;

            //生成位置をリセット
            E_SJ_SkillAttack2Reset();
        }

        yield return waitOneS;

        //万鈞(反時計回り)
        for (int i = 0; i < attackPos0.Length; i++)
        {
            //万鈞N
            E_SJ_SkillAttack2_8_Y(-attackPos0[i], 6.0f, 180);
            yield return waitHalfS;
        }

        for (int i = 0; i < attackPos0.Length; i++)
        {
            //万鈞W
            E_SJ_SkillAttack2_8_X(-6.0f, -attackPos0[i], -90);
            yield return waitHalfS;
        }

        for (int i = 0; i < attackPos0.Length; i++)
        {
            //万鈞S
            E_SJ_SkillAttack2_8_Y(attackPos0[i], -6.0f, 0);
            yield return waitHalfS;
        }

        for (int i = 0; i < attackPos0.Length; i++)
        {
            //万鈞E
            E_SJ_SkillAttack2_8_X(6.0f, attackPos0[i], 90);
            yield return waitHalfS;
        }


        yield return waitHalfS;

        //生成位置をリセット
        E_SJ_SkillAttack2Reset();


        SceneManager.LoadScene("TalkScene3_7");
    }
    #endregion


    #region//攻撃の処理関数
    //力チャージ小（四貫S&N）の処理関数
    void E_SJ_SkillAttack2_0_0_Y(float positionX_S, float positionY_S, float angle_S, float positionX_N, float positionY_N, float angle_N)
    {
        //力チャージ小S（E_SJ_SkillAttack2_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_0Prefab, new Vector3(positionX_S, positionY_S, -0.05f), Quaternion.Euler(0, 0, angle_S));

        //力チャージ小N（E_SJ_SkillAttack2_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_0Prefab, new Vector3(positionX_N, positionY_N, -0.05f), Quaternion.Euler(0, 0, angle_N));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_1_SPosX = positionX_S;
        GSubManager.instance.SJ_SkillAttack2_1_NPosX = positionX_N;
    }

    //力チャージ小（四貫W&E）の処理関数
    void E_SJ_SkillAttack2_0_0_X(float positionX_W, float positionY_W, float angle_W, float positionX_E, float positionY_E, float angle_E)
    {
        //力チャージ小W（E_SJ_SkillAttack2_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_0Prefab, new Vector3(positionX_W, positionY_W, -0.05f), Quaternion.Euler(0, 0, angle_W));

        //力チャージ小E（E_SJ_SkillAttack2_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_0Prefab, new Vector3(positionX_E, positionY_E, -0.05f), Quaternion.Euler(0, 0, angle_E));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_1_WPosY = positionY_W;
        GSubManager.instance.SJ_SkillAttack2_1_EPosY = positionY_E;
    }

    //力チャージ小の処理関数
    void E_SJ_SkillAttack2_0_0(float positionX, float positionY, float angle)
    {
        //力チャージ小（E_SJ_SkillAttack2_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_2PosX = positionX;
        GSubManager.instance.SJ_SkillAttack2_2PosY = positionY;
        GSubManager.instance.SJ_SkillAttack2_6PosX = positionX;
        GSubManager.instance.SJ_SkillAttack2_7PosY = positionY;
    }

    //力チャージ大の処理関数
    void E_SJ_SkillAttack2_0_1(float positionX, float positionY, float angle)
    {
        //力チャージ大（E_SJ_SkillAttack2_0_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_3PosX = positionX;
        GSubManager.instance.SJ_SkillAttack2_3PosY = positionY;
    }

    //流チャージの処理関数
    void E_SJ_SkillAttack2_0(float positionX, float positionY, float angle)
    {
        //流チャージ（E_SJ_SkillAttack2_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_5PosX = positionX;
        GSubManager.instance.SJ_SkillAttack2_5PosY = positionY;
    }


    //四貫(S&N）の処理関数
    void E_SJ_SkillAttack2_1_Y(float positionX_S, float positionY_S, float angle_S, float positionX_N, float positionY_N, float angle_N)
    {
        //四貫S（E_SJ_SkillAttack2_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_1Prefab, new Vector3(positionX_S, positionY_S, -0.05f), Quaternion.Euler(0, 0, angle_S));

        //四貫N（E_SJ_SkillAttack2_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_1Prefab, new Vector3(positionX_N, positionY_N, -0.05f), Quaternion.Euler(0, 0, angle_N));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_1_SPosY = positionY_S;
        GSubManager.instance.SJ_SkillAttack2_1_NPosY = positionY_N;
    }

    //四貫（四貫W&E）の処理関数
    void E_SJ_SkillAttack2_1_X(float positionX_W, float positionY_W, float angle_W, float positionX_E, float positionY_E, float angle_E)
    {
        //四貫W（E_SJ_SkillAttack2_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_1Prefab, new Vector3(positionX_W, positionY_W, -0.05f), Quaternion.Euler(0, 0, angle_W));

        //四貫E（E_SJ_SkillAttack2_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_1Prefab, new Vector3(positionX_E, positionY_E, -0.05f), Quaternion.Euler(0, 0, angle_E));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_1_WPosY = positionX_W;
        GSubManager.instance.SJ_SkillAttack2_1_EPosY = positionX_E;
    }


    //回撃の処理関数
    void E_SJ_SkillAttack2_2(float positionX, float positionY, float angle)
    {
        //回撃（E_SJ_SkillAttack2_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_2PosY = positionY;
    }


    //光線の処理関数
    void E_SJ_SkillAttack2_3(float positionX, float positionY, float angle)
    {
        //光線（E_SJ_SkillAttack2_3Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //光滞の処理関数
    void E_SJ_SkillAttack2_4(float positionX, float positionY, float angle)
    {
        //光滞（E_SJ_SkillAttack2_4Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_4Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //直流（N&S）の処理関数
    void E_SJ_SkillAttack2_5_Y(float positionX, float positionY, float angle)
    {
        //直流（E_SJ_SkillAttack2_5Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_5Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_5PosY = positionY;
    }

    //直流（W&E）の処理関数
    void E_SJ_SkillAttack2_5_X(float positionX, float positionY, float angle)
    {
        //直流（E_SJ_SkillAttack2_5Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_5Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_5PosX = positionX;
    }


    //鉛直万鈞（S&N）の処理関数
    void E_SJ_SkillAttack2_6(float positionX, float positionY, float angle)
    {
        //鉛直万鈞（E_SJ_SkillAttack2_6Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_6Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_6PosY = positionY;
    }

    //回転万鈞（W&E）の処理関数
    void E_SJ_SkillAttack2_7(float positionX, float positionY, float angle)
    {
        //回転万鈞（E_SJ_SkillAttack2_7Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_7Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_7PosX = positionX;
    }

    //四方万鈞（S&N）の処理関数
    void E_SJ_SkillAttack2_8_Y(float positionX, float positionY, float angle)
    {
        //四方万鈞（E_SJ_SkillAttack2_8Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_8Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_8PosY = positionY;
    }

    //四方万鈞（W&E）の処理関数
    void E_SJ_SkillAttack2_8_X(float positionX, float positionY, float angle)
    {
        //四方万鈞（E_SJ_SkillAttack2_8Prefab）を生成
        Instantiate(E_SJ_SkillAttack2_8Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack2_8PosX = positionX;
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_SJ_SkillAttack2Reset()
    {
        GSubManager.instance.SJ_SkillAttack2_1_SPosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_1_NPosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_1_WPosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_1_EPosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_2PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_2PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_3PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_3PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_5PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_5PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_6PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_7PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_8PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack2_8PosY = 0.0f;
    }
    #endregion
}

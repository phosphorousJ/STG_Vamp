using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJ_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_SJ_SkillAttack0_0Prefabを入れる（流チャージ）
    public GameObject E_SJ_SkillAttack0_0Prefab;

    //E_SJ_SkillAttack0_1Prefabを入れる（直流）
    public GameObject E_SJ_SkillAttack0_1Prefab;

    //E_SJ_SkillAttack0_2Prefabを入れる（網流）
    public GameObject E_SJ_SkillAttack0_2Prefab;

    //E_SJ_SkillAttack0_3Prefabを入れる（分流）
    public GameObject E_SJ_SkillAttack0_3Prefab;

    //E_SJ_SkillAttack0_4Prefabを入れる（回流）
    public GameObject E_SJ_SkillAttack0_4Prefab;
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
        //SJの大技0発動を判定
        GManager.instance.SJ_Skill0 = true;

        //コルーチン開始
        StartCoroutine(SkillAttack0_0());
    }


    #region//0:直流N、直流E&W、直流S×3、直流N×2
    IEnumerator SkillAttack0_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        

        yield return new WaitForSeconds(2.0f);


        ////直流N
        for (int i = 0; i < 10; i++)
        {
            //流チャージ
            posX = attackPos0[Random.Range(0, attackPos0.Length)];
            E_SJ_SkillAttack0_0(posX, 4.7f, 180);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_1_Y(GSubManager.instance.SJ_SkillAttack0_1PosX, 5.5f, 180);

            
            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack0Reset();
        }


        ////直流E&W
        for (int i = 0; i < 5; i++)
        {
            //流チャージE
            posY = attackPos0[Random.Range(0, attackPos0.Length)];
            E_SJ_SkillAttack0_0(4.7f, posY, 90);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_1_X(5.5f, GSubManager.instance.SJ_SkillAttack0_1PosY, 90);


            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack0Reset();


            //流チャージW
            posY = attackPos0[Random.Range(0, attackPos0.Length)];
            E_SJ_SkillAttack0_0(-4.7f, posY, -90);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_1_X(-5.5f, GSubManager.instance.SJ_SkillAttack0_1PosY, -90);

            
            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack0Reset();
        }


        ////直流S×3
        //流チャージ
        E_SJ_SkillAttack0_0(-1.32f, -4.7f, 0);
        E_SJ_SkillAttack0_0(0.0f, -4.7f, 0);
        E_SJ_SkillAttack0_0(1.32f, -4.7f, 0);

        //攻撃
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack0_1_Y(1.32f, -5.5f, 0);
        E_SJ_SkillAttack0_1_Y(0.0f, -5.5f, 0);
        E_SJ_SkillAttack0_1_Y(-1.32f, -5.5f, 0);


        yield return waitHalfS;


        ////直流N×2
        //流チャージ
        E_SJ_SkillAttack0_0(-0.66f, -4.7f, 180);
        E_SJ_SkillAttack0_0(0.66f, -4.7f, 180);

        //攻撃
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack0_1_Y(-0.66f, 5.5f, 180);
        E_SJ_SkillAttack0_1_Y(0.66f, 5.5f, 180);


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_1());
    }
    #endregion

    # region//1:網流(N&W)×3、網流(S&E)×2
    IEnumerator SkillAttack0_1()
    {
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////網流(N&W)×3
        //流チャージN
        E_SJ_SkillAttack0_0(-1.32f, 4.7f, 180);
        E_SJ_SkillAttack0_0(0.0f, 4.7f, 180);
        E_SJ_SkillAttack0_0(1.32f, 4.7f, 180);

        //流チャージW
        E_SJ_SkillAttack0_0(-4.7f, -1.32f, -90);
        E_SJ_SkillAttack0_0(-4.7f, 0.0f, -90);
        E_SJ_SkillAttack0_0(-4.7f, 1.32f, -90);

        //攻撃
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack0_2_NW();


        yield return waitOneS;


        ////網流(S&E)×2
        //流チャージS
        E_SJ_SkillAttack0_0(-0.66f, -4.7f, 0);
        E_SJ_SkillAttack0_0(0.66f, -4.7f, 0);

        //流チャージE
        E_SJ_SkillAttack0_0(4.7f, -0.66f, 90);
        E_SJ_SkillAttack0_0(4.7f, 0.66f, 90);

        //攻撃
        yield return new WaitForSeconds(0.3f);
        E_SJ_SkillAttack0_2_SE();


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_2());
    }
    #endregion

    #region//2:分流(反時計回り)
    IEnumerator SkillAttack0_2()
    {
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////分流(反時計回り)
        for (int i = 0; i < 2; i++)
        {
            //流チャージS
            posX = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack0_0(posX, -4.7f, 0);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_3_Y(GSubManager.instance.SJ_SkillAttack0_3PosX, -8.5f, 0);

            //分流
            yield return waitOneS;
            BranchX();
            

            yield return waitOneS;


            //流チャージE
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack0_0(4.7f, posY, 90);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_3_X(8.5f, GSubManager.instance.SJ_SkillAttack0_3PosY, 90);

            //分流
            yield return waitOneS;
            BranchY();


            yield return waitOneS;


            //流チャージN
            posX = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack0_0(posX, 4.7f, 180);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_3_Y(GSubManager.instance.SJ_SkillAttack0_3PosX, 8.5f, 180);

            //分流
            yield return waitOneS;
            BranchX();


            yield return waitOneS;


            //流チャージW
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack0_0(-4.7f, posY, -90);

            //攻撃
            yield return new WaitForSeconds(0.3f);
            E_SJ_SkillAttack0_3_X(-8.5f, GSubManager.instance.SJ_SkillAttack0_3PosY, -90);

            //分流
            yield return waitOneS;
            BranchY();


            yield return waitOneS;
        }


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_3());
    }
    #endregion

    #region//3:回流(固定)、回流(追尾)、回流(固定)
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////回流(固定)
        //流チャージ
        E_SJ_SkillAttack0_0(0.0f, 0.0f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack0_4(GSubManager.instance.SJ_SkillAttack0_4PosX, GSubManager.instance.SJ_SkillAttack0_4PosY);


        yield return new WaitForSeconds(0.3f);

        //生成位置をリセット
        E_SJ_SkillAttack0Reset();


        yield return new WaitForSeconds(10.0f);


        ////回流(追尾)
        for (int i = 0; i < 6; i++)
        {
            //流チャージ
            player = Player.transform.position;
            E_SJ_SkillAttack0_0(player.x, player.y, 0);

            yield return waitHalfS;

            //攻撃
            E_SJ_SkillAttack0_4(GSubManager.instance.SJ_SkillAttack0_4PosX, GSubManager.instance.SJ_SkillAttack0_4PosY);

            
            yield return new WaitForSeconds(0.3f);

            //生成位置をリセット
            E_SJ_SkillAttack0Reset();


            yield return new WaitForSeconds(9.0f);
        }


        yield return waitOneS;


        ////回流(固定)
        //流チャージ
        E_SJ_SkillAttack0_0(0.0f, 0.0f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack0_4(GSubManager.instance.SJ_SkillAttack0_4PosX, GSubManager.instance.SJ_SkillAttack0_4PosY);


        yield return new WaitForSeconds(0.3f);

        //生成位置をリセット
        E_SJ_SkillAttack0Reset();


        yield return new WaitForSeconds(10.0f);


        SceneManager.LoadScene("TalkScene3_3");
    }
    #endregion


    #region//攻撃の処理関数
    //流チャージの処理関数
    void E_SJ_SkillAttack0_0(float positionX, float positionY, float angle)
    {
        //流チャージ（E_SJ_SkillAttack0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_1PosX = positionX;
        GSubManager.instance.SJ_SkillAttack0_1PosY = positionY;
        GSubManager.instance.SJ_SkillAttack0_3PosX = positionX;
        GSubManager.instance.SJ_SkillAttack0_3PosY = positionY;
        GSubManager.instance.SJ_SkillAttack0_4PosX = positionX;
        GSubManager.instance.SJ_SkillAttack0_4PosY = positionY;
    }


    //直流（N&S）の処理関数
    void E_SJ_SkillAttack0_1_Y(float positionX, float positionY, float angle)
    {
        //直流（E_SJ_SkillAttack0_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_1PosY = positionY;
    }

    //直流（W&E）の処理関数
    void E_SJ_SkillAttack0_1_X(float positionX, float positionY, float angle)
    {
        //直流（E_SJ_SkillAttack0_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_1PosX = positionX;
    }


    //網流(N&W)×3の処理関数
    void E_SJ_SkillAttack0_2_NW()
    {
        //網流N×3（E_SJ_SkillAttack0_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-1.32f, 7.0f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(0.0f, 7.0f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(1.32f, 7.0f, -0.05f), Quaternion.Euler(0, 0, 180));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_2PosY = 7.0f;


        //網流W×3（E_SJ_SkillAttack0_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-7.0f, -1.32f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-7.0f, 0.0f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-7.0f, 1.32f, -0.05f), Quaternion.Euler(0, 0, -90));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_2PosX = -7.0f;
    }

    //網流(S&E)×2の処理関数
    void E_SJ_SkillAttack0_2_SE()
    {
        //網流S×2（E_SJ_SkillAttack0_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-0.66f, -7.0f, -0.05f), Quaternion.identity);
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(0.66f, -7.0f, -0.05f), Quaternion.identity);

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_2PosY = -7.0f;


        //網流E×2（E_SJ_SkillAttack0_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(7.0f, -0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(7.0f, 0.66f, -0.05f), Quaternion.Euler(0, 0, 90));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_2PosX = 7.0f;
    }


    //分流（N&S）の処理関数
    void E_SJ_SkillAttack0_3_Y(float positionX, float positionY, float angle)
    {
        //分流（E_SJ_SkillAttack0_3Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_3PosY = positionY;
    }

    //分流（W&E）の処理関数
    void E_SJ_SkillAttack0_3_X(float positionX, float positionY, float angle)
    {
        //分流（E_SJ_SkillAttack0_3Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack0_3PosX = positionX;
    }


    //回流（S&E）の処理関数
    void E_SJ_SkillAttack0_4(float positionX, float positionY)
    {
        //回流S（E_SJ_SkillAttack0_4Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_4Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.identity);

        //回流E（E_SJ_SkillAttack0_4Prefab）を生成
        Instantiate(E_SJ_SkillAttack0_4Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, 90));
    }
    #endregion


    #region//分流攻撃する関数
    void BranchX()
    {
        player = Player.transform.position;

        if (player.x < GSubManager.instance.SJ_SkillAttack0_3PosX)//E
        {
            //分流（E_SJ_SkillAttack0_2Prefab）を生成
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, -1.32f, -0.05f), Quaternion.Euler(0, 0, 90));
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, 1.32f, -0.05f), Quaternion.Euler(0, 0, 90));

            //生成位置を保存
            GSubManager.instance.SJ_SkillAttack0_2PosX = GSubManager.instance.SJ_SkillAttack0_3PosX;
        }
        else//W
        {
            //分流（E_SJ_SkillAttack0_2Prefab）を生成
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, -1.32f, -0.05f), Quaternion.Euler(0, 0, -90));
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, 0.0f, -0.05f), Quaternion.Euler(0, 0, -90));
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.SJ_SkillAttack0_3PosX, 1.32f, -0.05f), Quaternion.Euler(0, 0, -90));

            //生成位置を保存
            GSubManager.instance.SJ_SkillAttack0_2PosX = GSubManager.instance.SJ_SkillAttack0_3PosX;
        }
    }


    void BranchY()
    {
        player = Player.transform.position;

        if (player.y < GSubManager.instance.SJ_SkillAttack0_3PosY)//N
        {
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-0.66f, GSubManager.instance.SJ_SkillAttack0_3PosY, -0.05f), Quaternion.Euler(0, 0, 180));
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(0.66f, GSubManager.instance.SJ_SkillAttack0_3PosY, -0.05f), Quaternion.Euler(0, 0, 180));
            GSubManager.instance.SJ_SkillAttack0_2PosY = GSubManager.instance.SJ_SkillAttack0_3PosY;
        }
        else//S
        {
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(-0.66f, GSubManager.instance.SJ_SkillAttack0_3PosY, -0.05f), Quaternion.identity);
            Instantiate(E_SJ_SkillAttack0_2Prefab, new Vector3(0.66f, GSubManager.instance.SJ_SkillAttack0_3PosY, -0.05f), Quaternion.identity);
            GSubManager.instance.SJ_SkillAttack0_2PosY = GSubManager.instance.SJ_SkillAttack0_3PosY;
        }
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_SJ_SkillAttack0Reset()
    {
        GSubManager.instance.SJ_SkillAttack0_1PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_2PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_2PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_3PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_3PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_4PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack0_4PosY = 0.0f;
    }
    #endregion
}

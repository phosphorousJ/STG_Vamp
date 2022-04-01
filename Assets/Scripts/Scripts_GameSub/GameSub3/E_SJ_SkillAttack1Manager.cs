using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_SJ_SkillAttack1Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_SJ_SkillAttack1_0_0Prefabを入れる（圧チャージ小）
    public GameObject E_SJ_SkillAttack1_0_0Prefab;

    //E_SJ_SkillAttack1_0_1Prefabを入れる（圧チャージ大）
    public GameObject E_SJ_SkillAttack1_0_1Prefab;

    //E_SJ_SkillAttack1_1Prefabを入れる（光線）
    public GameObject E_SJ_SkillAttack1_1Prefab;

    //E_SJ_SkillAttack1_2Prefabを入れる（雷壁）
    public GameObject E_SJ_SkillAttack1_2Prefab;

    //E_SJ_SkillAttack1_3Prefabを入れる（迫雷）
    public GameObject E_SJ_SkillAttack1_3Prefab;

    //E_SJ_SkillAttack1_4Prefabを入れる（挟雷）
    public GameObject E_SJ_SkillAttack1_4Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;

    //攻撃位置の配列
    private float[] attackPos1 = { -0.99f, 0.0f, 0.99f };

    //攻撃位置（x座標）
    private float posX;

    //攻撃位置（y座標）
    private float posY;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //SJの大技1発動を判定
        GManager.instance.SJ_Skill1 = true;

        //コルーチン開始
        StartCoroutine(SkillAttack1_0());
    }


    #region//0:光線(N&W)×1、光線(N&W)×2、光線E&W、光線(N&W)×1
    IEnumerator SkillAttack1_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return new WaitForSeconds(2.0f);


        ////光線(N&W)×1
        //圧チャージ小
        E_SJ_SkillAttack1_0_0(0.0f, 4.7f, 180);
        E_SJ_SkillAttack1_0_0(-4.7f, 0.0f, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_1_Y(0.0f, 0.0f, 180);
        E_SJ_SkillAttack1_1_X(0.0f, 0.0f, -90);


        yield return waitHalfS;


        ////光線(N&W)×2
        //圧チャージ小
        E_SJ_SkillAttack1_0_0(-0.99f, 4.7f, 180);
        E_SJ_SkillAttack1_0_0(0.99f, 4.7f, 180);
        E_SJ_SkillAttack1_0_0(-4.7f, -0.99f, -90);
        E_SJ_SkillAttack1_0_0(-4.7f, 0.99f, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_1_Y(-0.99f, 0.0f, 180);
        E_SJ_SkillAttack1_1_Y(0.99f, 0.0f, 180);
        E_SJ_SkillAttack1_1_X(0.0f, -0.99f, -90);
        E_SJ_SkillAttack1_1_X(0.0f, 0.99f, -90);


        yield return waitOneS;


        ////光線E&W
        for (int i = 0; i < 6; i++)
        {
            //圧チャージ小E
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack1_0_0(4.7f, posY, 90);

            //攻撃
            yield return new WaitForSeconds(0.7f);
            E_SJ_SkillAttack1_1_X(0.0f, GSubManager.instance.SJ_SkillAttack1_1PosY, 90);


            yield return waitHalfS;
            

            //圧チャージ小W
            posY = attackPos1[Random.Range(0, attackPos1.Length)];
            E_SJ_SkillAttack1_0_0(-4.7f, posY, -90);

            //攻撃
            yield return new WaitForSeconds(0.7f);
            E_SJ_SkillAttack1_1_X(0.0f, GSubManager.instance.SJ_SkillAttack1_1PosY, -90);


            yield return waitHalfS;
        }


        yield return waitOneS;


        ////光線(N&W)×1
        //圧チャージ小
        E_SJ_SkillAttack1_0_0(0.0f, 4.7f, 180);
        E_SJ_SkillAttack1_0_0(-4.7f, 0.0f, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_1_Y(0.0f, 0.0f, 180);
        E_SJ_SkillAttack1_1_X(0.0f, 0.0f, -90);


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack1Reset();


        StartCoroutine(SkillAttack1_1());
    }
    #endregion

    #region//1:雷壁S、雷壁N、雷壁S、雷壁W、雷壁W、雷壁E
    IEnumerator SkillAttack1_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////雷壁S
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(0.0f, -4.7f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_Y(0.0f, -7.4f, 0);


        yield return waitOneS;


        ////雷壁N
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(0.0f, 4.7f, 180);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_Y(0.0f, 7.4f, 180);


        yield return waitOneS;


        ////雷壁S
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(0.0f, -4.7f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_Y(0.0f, -7.4f, 0);


        yield return waitOneS;


        ////雷壁W
        for (int i = 0; i < 2; i++)
        {
            //圧チャージ大
            E_SJ_SkillAttack1_0_1(-4.7f, 0.0f, -90);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_2_X(-7.4f, 0.0f, -90);


            yield return waitOneS;
        }


        ////雷壁E
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(4.7f, 0.0f, 90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_X(7.4f, 0.0f, 90);


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack1Reset();
        

        StartCoroutine(SkillAttack1_2());
    }
    #endregion

    #region//2:迫雷S、迫雷W、雷壁N、雷壁S、迫雷W&S
    IEnumerator SkillAttack1_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////迫雷S
        for (int i = 0; i < 3; i++)
        {
            //圧チャージ小
            player = Player.transform.position;
            GSubManager.instance.Player_PosX = player.x;
            E_SJ_SkillAttack1_0_0(player.x, -4.7f, 0);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_3_Y(player.x, 0.0f, 0);

            //保存したPlayerの座標をリセット
            yield return new WaitForSeconds(1.2f);
            GSubManager.instance.Player_PosX = 0.0f;
        }


        ////迫雷W
        for (int i = 0; i < 3; i++)
        {
            //圧チャージ小
            player = Player.transform.position;
            GSubManager.instance.Player_PosY = player.y;
            E_SJ_SkillAttack1_0_0(-4.7f, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_3_X(0.0f, player.y, -90);

            //保存したPlayerの座標をリセット
            yield return new WaitForSeconds(1.2f);
            GSubManager.instance.Player_PosY = 0.0f;
        }


        ////雷壁N
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(0.0f, 4.7f, 180);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_Y(0.0f, 7.4f, 180);


        yield return new WaitForSeconds(1.2f);


        ////雷壁S
        //圧チャージ大
        E_SJ_SkillAttack1_0_1(0.0f, -4.7f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_2_Y(0.0f, -7.4f, 0);


        yield return new WaitForSeconds(1.2f);


        ////迫雷W&S
        for (int i = 0; i < 5; i++)
        {
            //圧チャージ小W
            player = Player.transform.position;
            GSubManager.instance.Player_PosY = player.y;
            E_SJ_SkillAttack1_0_0(-4.7f, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_3_X(0.0f, player.y, -90);

            //保存したPlayerの座標をリセット
            yield return new WaitForSeconds(1.2f);
            GSubManager.instance.Player_PosY = 0.0f;


            //圧チャージ小S
            player = Player.transform.position;
            GSubManager.instance.Player_PosX = player.x;
            E_SJ_SkillAttack1_0_0(player.x, -4.7f, 0);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_3_Y(player.x, 0.0f, 0);

            //保存したPlayerの座標をリセット
            yield return new WaitForSeconds(1.2f);
            GSubManager.instance.Player_PosX = 0.0f;
        }


        yield return waitOneS;

        //生成位置をリセット
        E_SJ_SkillAttack1Reset();


        StartCoroutine(SkillAttack1_3());
    }
    #endregion

    #region//3:狭雷N&S、挟雷E&W、挟雷N&S&E、挟雷(時計回り)
    IEnumerator SkillAttack1_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);


        yield return waitOneS;


        ////挟雷N&S
        //圧チャージ小N
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(player.x, 4.7f, 180);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(player.x, 0.0f, 180);

        yield return waitOneS;

        //圧チャージ小S
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(player.x, -4.7f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(player.x, 0.0f, 0);

        yield return new WaitForSeconds(5.0f);


        ////挟雷E&W
        //圧チャージ小E
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(4.7f, player.y, 90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(0.0f, player.y, 90);

        yield return waitOneS;

        //圧チャージ小W
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(-4.7f, player.y, -90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(0.0f, player.y, -90);

        yield return new WaitForSeconds(5.0f);


        ////挟雷N&S&E
        //圧チャージ小N
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(player.x, 4.7f, 180);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(player.x, 0.0f, 180);

        yield return waitOneS;

        //圧チャージ小S
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(player.x, -4.7f, 0);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(player.x, 0.0f, 0);

        yield return waitOneS;

        //圧チャージ小E
        player = Player.transform.position;
        E_SJ_SkillAttack1_0_0(4.7f, player.y, 90);

        //攻撃
        yield return waitHalfS;
        E_SJ_SkillAttack1_4(0.0f, player.y, 90);

        yield return new WaitForSeconds(5.0f);


        ////挟雷(時計回り)
        for (int i = 0; i < 6; i++)
        {
            //圧チャージ小S
            player = Player.transform.position;
            E_SJ_SkillAttack1_0_0(player.x, -4.7f, 0);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_4(player.x, 0.0f, 0);
            
            yield return waitHalfS;

            //圧チャージ小W
            player = Player.transform.position;
            E_SJ_SkillAttack1_0_0(-4.7f, player.y, -90);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_4(0.0f, player.y, -90);

            yield return waitHalfS;

            //圧チャージ小N
            player = Player.transform.position;
            E_SJ_SkillAttack1_0_0(player.x, 4.7f, 180);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_4(player.x, 0.0f, 180);

            yield return waitHalfS;

            //圧チャージ小E
            player = Player.transform.position;
            E_SJ_SkillAttack1_0_0(4.7f, player.y, 90);

            //攻撃
            yield return waitHalfS;
            E_SJ_SkillAttack1_4(0.0f, player.y, 90);

            yield return new WaitForSeconds(4.0f);
        }


        yield return waitHalfS;


        SceneManager.LoadScene("TalkScene3_5");
    }
    #endregion


    #region//攻撃の処理関数
    //圧チャージ小の処理関数
    void E_SJ_SkillAttack1_0_0(float positionX, float positionY, float angle)
    {
        //圧チャージ小（E_SJ_SkillAttack1_0_0Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_0_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_1PosX = positionX;
        GSubManager.instance.SJ_SkillAttack1_1PosY = positionY;
    }

    //圧チャージ大の処理関数
    void E_SJ_SkillAttack1_0_1(float positionX, float positionY, float angle)
    {
        //圧チャージ大（E_SJ_SkillAttack1_0_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //光線（N&S）の処理関数
    void E_SJ_SkillAttack1_1_Y(float positionX, float positionY, float angle)
    {
        //光線（E_SJ_SkillAttack1_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_1PosY = positionY;
    }

    //光線（W&E）の処理関数
    void E_SJ_SkillAttack1_1_X(float positionX, float positionY, float angle)
    {
        //光線（E_SJ_SkillAttack1_1Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_1PosX = positionX;
    }


    //雷壁（N&S）の処理関数
    void E_SJ_SkillAttack1_2_Y(float positionX, float positionY, float angle)
    {
        //雷壁（E_SJ_SkillAttack1_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_2PosY = positionY;
    }

    //雷壁（W&E）の処理関数
    void E_SJ_SkillAttack1_2_X(float positionX, float positionY, float angle)
    {
        //雷壁（E_SJ_SkillAttack1_2Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_2PosX = positionX;
    }


    //迫雷（N&S）の処理関数
    void E_SJ_SkillAttack1_3_Y(float positionX, float positionY, float angle)
    {
        //迫雷（E_SJ_SkillAttack1_3Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_3PosY = positionY;
    }

    //迫雷（W&E）の処理関数
    void E_SJ_SkillAttack1_3_X(float positionX, float positionY, float angle)
    {
        //迫雷（E_SJ_SkillAttack1_3Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_3Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.SJ_SkillAttack1_3PosX = positionX;
    }


    //挟雷の処理関数
    void E_SJ_SkillAttack1_4(float positionX, float positionY, float angle)
    {
        //挟雷（E_SJ_SkillAttack1_4Prefab）を生成
        Instantiate(E_SJ_SkillAttack1_4Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_SJ_SkillAttack1Reset()
    {
        GSubManager.instance.SJ_SkillAttack1_1PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack1_1PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack1_2PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack1_2PosY = 0.0f;
        GSubManager.instance.SJ_SkillAttack1_3PosX = 0.0f;
        GSubManager.instance.SJ_SkillAttack1_3PosY = 0.0f;
    }
    #endregion
}

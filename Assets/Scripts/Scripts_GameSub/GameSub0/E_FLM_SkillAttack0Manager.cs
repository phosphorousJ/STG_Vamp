using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_FLM_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //E_FLM_SkillAttack0_0Prefabを入れる（予告大鎌）
    public GameObject E_FLM_SkillAttack0_0Prefab;

    //E_FLM_SkillAttack0_1Prefabを入れる（移動大鎌）
    public GameObject E_FLM_SkillAttack0_1Prefab;

    //E_FLM_SkillAttack0_2Prefabを入れる（回転大鎌）
    public GameObject E_FLM_SkillAttack0_2Prefab;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //FLMの大技0発動を判定
        GManager.instance.FLM_Skill0 = true;

        //コルーチン開始
        StartCoroutine(SkillAttack0_0());
    }


    #region//0:単発移動攻撃（N,E,S,E）
    IEnumerator SkillAttack0_0()
    {
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return new WaitForSeconds(2.0f);


        ////単発移動N
        //予告
        E_FLM_SkillAttack0_0(0.0f, 3.5f, 180);

        //攻撃
        yield return waitOneS;
        E_FLM_SkillAttack0_1_Y(0.0f, 3.5f, 180);


        yield return waitOneHalfS;


        ////単発移動E
        //予告
        E_FLM_SkillAttack0_0(3.5f, 0.0f, 90);

        //攻撃
        yield return waitOneS;
        E_FLM_SkillAttack0_1_X(3.5f, 0.0f, 90);


        yield return waitOneHalfS;


        ////単発移動S
        //予告
        E_FLM_SkillAttack0_0(0.0f, -3.5f, 0);

        //攻撃
        yield return waitOneS;
        E_FLM_SkillAttack0_1_Y(0.0f, -3.5f, 0);


        yield return waitOneHalfS;


        ////単発移動E
        //予告
        E_FLM_SkillAttack0_0(3.5f, 0.0f, 90);

        //攻撃
        yield return waitOneS;
        E_FLM_SkillAttack0_1_X(3.5f, 0.0f, 90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();
        

        StartCoroutine(SkillAttack0_1());
    }
    #endregion

    #region//1:連続移動攻撃（S,W,N,E/N,S,E,W）
    IEnumerator SkillAttack0_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////連続移動S,W,N,E
        //予告
        E_FLM_SkillAttack0_0(0.0f, -3.5f, 0);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(-3.5f, 0.0f, -90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, 3.5f, 180);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(3.5f, 0.0f, 90);
        yield return waitOneS;

        //攻撃
        E_FLM_SkillAttack0_1_Y(0.0f, -3.5f, 0);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_X(-3.5f, 0.0f, -90);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_Y(0.0f, 3.5f, 180);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_X(3.5f, 0.0f, 90);


        yield return waitOneHalfS;


        ////連続移動N,S,E,W
        //予告
        E_FLM_SkillAttack0_0(0.0f, 3.5f, 180);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, -3.5f, 0);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(3.5f, 0.0f, 90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(-3.5f, 0.0f, -90);
        yield return waitOneS;

        //攻撃
        E_FLM_SkillAttack0_1_Y(0.0f, 3.5f, 180);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_Y(0.0f, -3.5f, 0);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_X(3.5f, 0.0f, 90);
        yield return waitOneHalfS;

        E_FLM_SkillAttack0_1_X(-3.5f, 0.0f, -90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_2());
    }
    #endregion

    #region//2:単発回転攻撃（N,W）
    IEnumerator SkillAttack0_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////単発回転N
        //予告
        E_FLM_SkillAttack0_0(0.0f, 3.5f, -90);

        //攻撃
        yield return waitHalfS;
        E_FLM_SkillAttack0_2_Y(0.0f, 3.5f, -90);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        ////単発回転W
        //予告
        E_FLM_SkillAttack0_0(-3.5f, 0.0f, 0);

        //攻撃
        yield return waitHalfS;
        E_FLM_SkillAttack0_2_X(-3.5f, 0.0f, 0);


        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        StartCoroutine(SkillAttack0_3());
    }
    #endregion

    #region//3:連続回転攻撃（W,S,N/N,E,N/S,W,N,E）
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);


        yield return waitOneS;


        ////連続移動W,S,N
        //予告
        E_FLM_SkillAttack0_0(-3.5f, 0.0f, 0);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, -3.5f, 90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, 3.5f, -90);
        yield return waitOneS;

        //攻撃W
        E_FLM_SkillAttack0_2_X(-3.5f, 0.0f, 0);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃S
        E_FLM_SkillAttack0_2_Y(0.0f, -3.5f, 90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃N
        E_FLM_SkillAttack0_2_Y(0.0f, 3.5f, -90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        ////連続移動N,E,N
        //予告
        E_FLM_SkillAttack0_0(0.0f, 3.5f, -90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(3.5f, 0.0f, 180);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, 3.5f, -90);
        yield return waitOneS;

        //攻撃N
        E_FLM_SkillAttack0_2_Y(0.0f, 3.5f, -90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃E
        E_FLM_SkillAttack0_2_X(3.5f, 0.0f, 180);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃N
        E_FLM_SkillAttack0_2_Y(0.0f, 3.5f, -90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        ////連続移動S,W,N,E
        //予告
        E_FLM_SkillAttack0_0(0.0f, -3.5f, 90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(-3.5f, 0.0f, 0);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(0.0f, 3.5f, -90);
        yield return waitHalfS;

        E_FLM_SkillAttack0_0(3.5f, 0.0f, 180);
        yield return waitOneS;

        //攻撃S
        E_FLM_SkillAttack0_2_Y(0.0f, -3.5f, 90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃W
        E_FLM_SkillAttack0_2_X(-3.5f, 0.0f, 0);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃N
        E_FLM_SkillAttack0_2_Y(0.0f, 3.5f, -90);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();

        //攻撃E
        E_FLM_SkillAttack0_2_X(3.5f, 0.0f, 180);
        yield return waitOneHalfS;

        //生成位置をリセット
        E_FLM_SkillAttack0Reset();


        SceneManager.LoadScene("GameScene0_0");
    }
    #endregion


    #region//攻撃の処理関数
    //予告大鎌の処理関数
    void E_FLM_SkillAttack0_0(float positionX, float positionY, float angle)
    {
        //予告大鎌（E_FLM_SkillAttack0_0Prefab）を生成
        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));
    }


    //移動大鎌（N&S）の処理関数
    void E_FLM_SkillAttack0_1_Y(float positionX, float positionY, float angle)
    {
        //移動大鎌（E_FLM_SkillAttack0_1Prefab）を生成
        Instantiate(E_FLM_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack0_1PosY = positionY;
    }

    //移動大鎌（W&E）の処理関数
    void E_FLM_SkillAttack0_1_X(float positionX, float positionY, float angle)
    {
        //移動大鎌（E_FLM_SkillAttack0_1Prefab）を生成
        Instantiate(E_FLM_SkillAttack0_1Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack0_1PosX = positionX;
    }


    //回転大鎌（N&S）の処理関数
    void E_FLM_SkillAttack0_2_Y(float positionX, float positionY, float angle)
    {
        //回転大鎌（E_FLM_SkillAttack0_2Prefab）を生成
        Instantiate(E_FLM_SkillAttack0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack0_2PosY = positionY;
    }

    //回転大鎌（W&E）の処理関数
    void E_FLM_SkillAttack0_2_X(float positionX, float positionY, float angle)
    {
        //回転大鎌（E_FLM_SkillAttack0_2Prefab）を生成
        Instantiate(E_FLM_SkillAttack0_2Prefab, new Vector3(positionX, positionY, -0.05f), Quaternion.Euler(0, 0, angle));

        //生成位置を保存
        GSubManager.instance.FLM_SkillAttack0_2PosX = positionX;
    }
    #endregion


    #region//生成位置のリセット関数
    //攻撃の生成位置をリセットする関数
    void E_FLM_SkillAttack0Reset()
    {
        GSubManager.instance.FLM_SkillAttack0_1PosX = 0.0f;
        GSubManager.instance.FLM_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.FLM_SkillAttack0_2PosX = 0.0f;
        GSubManager.instance.FLM_SkillAttack0_2PosY = 0.0f;
    }
    #endregion
}

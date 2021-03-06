using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJController2 : MonoBehaviour
{
    #region//インスペクター設定
    //E_NomalAttack1Prefab（通常攻撃）を入れる
    public GameObject E_NomalAttack2Prefab;

    //E_B_MPBulletPrefab（青弾）を入れる
    public GameObject E_B_MPBulletPrefab;

    //E_G_MPBulletPrefab（緑弾）を入れる
    public GameObject E_G_MPBulletPrefab;

    //E_R_MPBulletPrefab（赤弾）を入れる
    public GameObject E_R_MPBulletPrefab;
    #endregion


    #region//プライベート変数
    //通常攻撃の生成位置
    private float nStart0PosY = 1.6f;
    private float nStart0PosZ = 9.0f;

    //MP弾の生成位置
    private float mpStartPosY = 1.6f;
    private float mpStartPosZ = 10.5f;

    //生成するx方向の範囲
    private float rangePosX = 3.2f;

    //生成時間間隔
    public float intervalTime;

    //経過時間
    private float time = 0.0f;

    //攻撃開始時間
    private float attackTime;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //生成時間間隔を決定
        intervalTime = GetRandomTime();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //時間計測
        time += Time.deltaTime;
        attackTime += Time.deltaTime;

        //5秒後に攻撃開始
        if (5.0 <= attackTime)
        {
            GenAttack();
        }
    }


    //攻撃する関数
    void GenAttack()
    {
        //経過時間が生成時間間隔より大きいとき、攻撃
        if (intervalTime < time)
        {
            GenAttackKind();

            //経過時間リセット
            time = 0.0f;
        }

        //次の生成時間間隔を決定
        intervalTime = GetRandomTime();
    }


    //ランダムに時間を決定する関数
    private float GetRandomTime()
    {
        return Random.Range(0.2f, 0.4f);
    }


    //攻撃の種類を決定する関数
    void GenAttackKind()
    {
        //生成位置のx座標をランダムに決定
        float laneX = rangePosX * Random.Range(-2, 3);

        //攻撃の全体割合
        int attack = Random.Range(1, 11);

        //攻撃の部分割合（60%:通常2,20%:青,15%:緑,5%:赤）
        if (1 <= attack && attack <= 6)
        {
            GameObject nomal = Instantiate(E_NomalAttack2Prefab);
            nomal.transform.position = new Vector3(laneX, nStart0PosY, nStart0PosZ);
        }
        else if (6 <= attack && attack <= 8)
        {
            GameObject bBullet = Instantiate(E_B_MPBulletPrefab);
            bBullet.transform.position = new Vector3(laneX, mpStartPosY, mpStartPosZ);
        }
        else if (8 <= attack && attack <= 9.5)
        {
            GameObject gBullet = Instantiate(E_G_MPBulletPrefab);
            gBullet.transform.position = new Vector3(laneX, mpStartPosY, mpStartPosZ);
        }
        else
        {
            GameObject rBullet = Instantiate(E_R_MPBulletPrefab);
            rBullet.transform.position = new Vector3(laneX, mpStartPosY, mpStartPosZ);
        }
    }
}

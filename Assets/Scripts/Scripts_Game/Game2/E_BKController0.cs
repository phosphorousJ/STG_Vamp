using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BKController0 : MonoBehaviour
{
    #region//インスペクター設定
    //E_NomalAttackPrefab（通常攻撃）を入れる
    public GameObject E_NomalAttackPrefab;

    //E_B_MPBulletPrefab（青弾）を入れる
    public GameObject E_B_MPBulletPrefab;

    //E_G_MPBulletPrefab（緑弾）を入れる
    public GameObject E_G_MPBulletPrefab;

    //E_R_MPBulletPrefab（赤弾）を入れる
    public GameObject E_R_MPBulletPrefab;
    #endregion


    #region//プライベート変数
    //通常攻撃の生成位置
    private float nStartPosY = 3.9f;
    private float nStartPosZ = 13.0f;

    //MP弾の生成位置
    private float mpStartPosY = 1.6f;
    private float mpStartPosZ = 10.5f;

    //生成するx方向の範囲
    private float rangePosX = 3.2f;
    private float nRangePosX = 1.6f;

    //生成時間間隔
    public float intervalTime;

    //経過時間
    private float time = 0.0f;

    //攻撃開始時間
    private float attackTime;
    #endregion


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


    //攻撃の種類を決定する関数
    void GenAttackKind()
    {
        //生成位置のx座標をランダムに決定
        float laneX = rangePosX * Random.Range(-2, 3);

        //通常攻撃のx座標をランダムに決定
        float nLaneX = nRangePosX * Random.Range(-2, 3);

        //攻撃の全体割合
        int attack = Random.Range(1, 11);

        //攻撃の部分割合（20%:通常,55%:青,20%:緑,5%:赤）
        if (1 <= attack && attack <= 2)
        {
            GameObject nomal = Instantiate(E_NomalAttackPrefab);
            nomal.transform.position = new Vector3(nLaneX, nStartPosY, nStartPosZ);
        }
        else if (2 <= attack && attack <= 7.5)
        {
            GameObject bBullet = Instantiate(E_B_MPBulletPrefab);
            bBullet.transform.position = new Vector3(laneX, mpStartPosY, mpStartPosZ);
        }
        else if (7.5 <= attack && attack <= 9.5)
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


    //ランダムに時間決定する関数
    private float GetRandomTime()
    {
        return Random.Range(0.2f, 0.5f);
    }
}

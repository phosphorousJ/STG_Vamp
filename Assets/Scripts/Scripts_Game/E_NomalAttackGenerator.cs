using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_NomalAttackGenerator : MonoBehaviour
{
    //E_NomalAttackPrefab（通常攻撃）を入れる
    public GameObject E_NomalAttackPrefab;

    //生成位置
    private float nStartPosY = 1.6f;
    private float nStartPosZ = 9.0f;

    //生成するx方向の範囲
    private float rangePosX = 3.2f;

    //生成時間間隔
    private float intervalTime;

    //経過時間
    private float time = 0.0f;


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
    }


    //ランダムに時間を決定する関数
    private float GetRandomTime()
    {
        return Random.Range(0.8f, 1.0f);
    }


    //通常攻撃を生成する関数
    void GenAttack()
    {
        //生成位置のx座標をランダムに決定
        float laneX = rangePosX * Random.Range(-2.0f, 2.0f);
    }
}

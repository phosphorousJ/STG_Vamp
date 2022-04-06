using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_ANEController : EnemyBaseController
{
    void Start()
    {
        //生成時間間隔を決定
        intervalTime = GetRandomTime();
    }


    protected override void GenAttack()
    {
        base.GenAttack();

        //次の生成時間間隔を決定
        intervalTime = GetRandomTime();
    }


    //ランダムに時間を決定する関数
    private float GetRandomTime()
    {
        return Random.Range(0.2f, 0.5f);
    }
}

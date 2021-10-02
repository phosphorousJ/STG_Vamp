using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_2Base : MonoBehaviour
{
    #region//プライベート設定
    //移動速度
    protected float moveSpeed;

    //回転速度
    protected float rotSpeed;
    #endregion


    protected virtual void Start()
    {
        this.rotSpeed = 5.0f + Random.Range(0, 4);
    }


    protected virtual void FixedUpdate()
    {
        //羽を回転させる
        transform.Rotate(0, 0, rotSpeed);
    }
}

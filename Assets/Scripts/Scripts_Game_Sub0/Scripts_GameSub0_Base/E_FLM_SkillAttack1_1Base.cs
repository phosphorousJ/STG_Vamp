using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_1Base : MonoBehaviour
{
    #region//プライベート設定
    //移動速度
    private float moveSpeed;
    #endregion


    protected virtual void Start()
    {
        this.moveSpeed = 5.0f + Random.Range(1, 4);
    }


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //羽を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}

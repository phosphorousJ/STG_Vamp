using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_2Base : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] protected float moveSpeed;
    [SerializeField] [Header("回転速度")] float rotSpeed;
    #endregion


    protected virtual void FixedUpdate()
    {
        //大鎌を回転させる
        transform.Rotate(0, 0, rotSpeed);
    }
}

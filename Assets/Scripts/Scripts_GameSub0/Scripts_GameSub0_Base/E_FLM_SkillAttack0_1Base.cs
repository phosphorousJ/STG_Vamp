using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_1Base : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //大鎌を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}

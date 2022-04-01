using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack0_1Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //電流を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //電流の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack0_1PosY < 0)//S
        {
            Invoke("ObjectDestroy", 1.0f);
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_1PosY)//N
        {
            Invoke("ObjectDestroy", 1.0f);
        }

        if (GSubManager.instance.SJ_SkillAttack0_1PosX < 0)//W
        {
            Invoke("ObjectDestroy", 1.0f);
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_1PosX)//E
        {
            Invoke("ObjectDestroy", 1.0f);
        }
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

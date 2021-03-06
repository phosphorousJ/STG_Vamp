using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack0_2Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //電流を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //交流の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack0_2PosY < 0)//S
        {
            Invoke("ObjectDestroy", 0.5f);
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_2PosY)//N
        {
            Invoke("ObjectDestroy", 0.5f);
        }

        if (GSubManager.instance.SJ_SkillAttack0_2PosX < 0)//W
        {
            Invoke("ObjectDestroy", 0.5f);
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_2PosX)//E
        {
            Invoke("ObjectDestroy", 0.5f);
        }
    }


    void ObjectDestroy()
    {
        //電流が特定の座標まで移動しても破棄されないエラーを防止
        Destroy(this.gameObject);
    }
}

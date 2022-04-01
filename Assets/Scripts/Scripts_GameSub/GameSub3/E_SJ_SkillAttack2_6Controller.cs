using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_6Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //電力を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //電力の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack2_6PosY < 0)//S
        {
            Invoke("ObjectDestroy", 0.25f);
        }

        if (0 < GSubManager.instance.SJ_SkillAttack2_6PosY)//N
        {
            Invoke("ObjectDestroy", 0.25f);
        }
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

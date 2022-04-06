using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_5Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //電力を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //直流の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack2_5PosY < 0)//S
        {
            if (5.5f < transform.position.y)
            {
                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack2_5PosY)//N
        {
            if (transform.position.y < -5.5f)
            {
                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.SJ_SkillAttack2_5PosX < 0)//W
        {
            if (5.5f < transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack2_5PosX)//E
        {
            if (transform.position.x < -5.5f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

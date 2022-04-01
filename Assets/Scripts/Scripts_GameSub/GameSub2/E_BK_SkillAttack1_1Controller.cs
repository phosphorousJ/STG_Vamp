using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack1_1Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //腕を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //腕の生成位置によって破棄する位置を変える
        if (GSubManager.instance.BK_SkillAttack1_1PosY < 0)//S
        {
            if (4.2f < transform.position.y)
            {
                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.BK_SkillAttack1_1PosY)//N
        {
            if (transform.position.y < -4.2f)
            {
                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.BK_SkillAttack1_1PosX < 0)//W
        {
            if (4.2f < transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.BK_SkillAttack1_1PosX)//E
        {
            if (transform.position.x < -4.2f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

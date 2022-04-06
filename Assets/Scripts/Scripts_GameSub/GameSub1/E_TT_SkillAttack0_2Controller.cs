using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TT_SkillAttack0_2Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //刀を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //刀の生成位置によって破棄する位置を変える
        if (GSubManager.instance.TT_SkillAttack0_2PosY < 0)//S
        {
            if (0 < transform.position.y)
            {
                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.TT_SkillAttack0_2PosX < 0)//W
        {
            if (0 < transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }
        
        if (0 < GSubManager.instance.TT_SkillAttack0_2PosY)//N
        {
            if (transform.position.y < 0)
            {
                Destroy(this.gameObject);
            }
        }
        
        if (0 < GSubManager.instance.TT_SkillAttack0_2PosX)//E
        {
            if (transform.position.x < 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

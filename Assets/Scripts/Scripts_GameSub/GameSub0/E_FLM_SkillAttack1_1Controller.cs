using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_1Controller : MonoBehaviour
{
    #region//プライベート設定
    //移動速度
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //羽を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //羽の生成位置によって破棄する位置を変える
        if (GSubManager.instance.FLM_SkillAttack1_1PosY < 0)//S
        {
            if (4.0f <= transform.position.y)
            {

                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.FLM_SkillAttack1_1PosX < 0)//W
        {
            if (4.0f <= transform.position.x)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.FLM_SkillAttack1_1PosY)//N
        {
            if (transform.position.y <= -4.0f)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.FLM_SkillAttack1_1PosX)//E
        {
            if (transform.position.x <= -4.0f)
            {

                Destroy(this.gameObject);
            }
        }
    }
}

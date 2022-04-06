using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_ANE_SkillAttackController : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //槍を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        //槍の生成位置によって破棄する位置を変える
        if (GSubManager.instance.ANE_SkillAttackPosY < 0)//S
        {
            if (6.5f <= transform.position.y)
            {

                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.ANE_SkillAttackPosX < 0)//W
        {
            if (6.5f <= transform.position.x)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.ANE_SkillAttackPosY)//N
        {
            if (transform.position.y <= -6.5f)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.ANE_SkillAttackPosX)//E
        {
            if (transform.position.x <= -6.5f)
            {

                Destroy(this.gameObject);
            }
        }
    }
}

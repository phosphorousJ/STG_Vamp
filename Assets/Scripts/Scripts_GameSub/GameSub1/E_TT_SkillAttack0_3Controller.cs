using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TT_SkillAttack0_3Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion


    //y軸方向へ移動しているか判定
    private bool moveY;


    void Start()
    {
        moveY = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //刀の生成位置によって破棄する位置を変える
        if (GSubManager.instance.TT_SkillAttack0_3PosY < 0)//S
        {
            if (transform.position.y <= -0.66f)
            {
                moveY = true;
                MoveY();
            }
            else
            {
                moveY = false;
                MoveX();

                if (2.0f < transform.position.x)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        
        if (0 < GSubManager.instance.TT_SkillAttack0_3PosY)//N
        {
            if (0.66f <= transform.position.y)
            {
                moveY = true;
                MoveY();
            }
            else
            {
                moveY = false;
                MoveX();

                if (transform.position.x < -2.0f)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        
        if (GSubManager.instance.TT_SkillAttack0_3PosX < 0)//W
        {
            if (transform.position.x <= -0.66f)
            {
                moveY = true;
                MoveY();
            }
            else
            {
                moveY = false;
                MoveX();

                if (transform.position.y < -2.0f)
                {
                    Destroy(this.gameObject);
                }
            }
        }

        if (0 < GSubManager.instance.TT_SkillAttack0_3PosX)//E
        {
            if (0.66f <= transform.position.x)
            {
                moveY = true;
                MoveY();
            }
            else
            {
                moveY = false;
                MoveX();

                if (2.0f < transform.position.y)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }


    //刀をx軸方向へ移動させる関数
    void MoveX()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }


    //刀をy軸方向へ移動させる関数
    void MoveY()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }
}

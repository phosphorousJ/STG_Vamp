using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack0_3Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    #endregion

    private bool move;


    void Start()
    {
        move = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //分流の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack0_3PosY < 0)//S
        {
            if (transform.position.y < -1.0f)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                
                Invoke("ObjectDestroy", 1.5f);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_3PosY)//N
        {
            if (1.0f < transform.position.y)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Invoke("ObjectDestroy", 1.5f);
            }
        }

        if (GSubManager.instance.SJ_SkillAttack0_3PosX < 0)//W
        {
            if (transform.position.x < -1.0f)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Invoke("ObjectDestroy", 1.5f);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack0_3PosX)//E
        {
            if (1.0f < transform.position.x)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Invoke("ObjectDestroy", 1.5f);
            }
        }
    }


    void ObjectMove()
    {
        //電流を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

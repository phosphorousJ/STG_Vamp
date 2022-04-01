using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack1_2Controller : MonoBehaviour
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
        //電圧の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack1_2PosY < 0)//S
        {
            if (transform.position.y < -1.9f)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Debug.Log("停止");

                Invoke("ObjectDestroy", 0.7f);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack1_2PosY)//N
        {
            if (1.9f < transform.position.y)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Debug.Log("停止");

                Invoke("ObjectDestroy", 0.7f);
            }
        }

        if (GSubManager.instance.SJ_SkillAttack1_2PosX < 0)//W
        {
            if (transform.position.x < -1.9f)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Debug.Log("停止");

                Invoke("ObjectDestroy", 0.7f);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack1_2PosX)//E
        {
            if (1.9f < transform.position.x)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Debug.Log("停止");

                Invoke("ObjectDestroy", 0.7f);
            }
        }
    }


    void ObjectMove()
    {
        //電圧を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        Debug.Log("移動");
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

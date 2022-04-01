using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack1_3Controller : MonoBehaviour
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
        //x軸移動
        if (GSubManager.instance.SJ_SkillAttack1_3PosY == 0)
        {
            if (GSubManager.instance.Player_PosX < 0.0f)
            {
                if (transform.position.x < 0.33f)
                {
                    move = true;
                    ObjectMove_R();
                }
                else
                {
                    move = false;
                    Debug.Log("停止");

                    Invoke("ObjectDestroy", 1.0f);
                }
            }
            else if (0.0f < GSubManager.instance.Player_PosX)
            {
                if (-0.33f < transform.position.x)
                {
                    move = true;
                    ObjectMove_L();
                }
                else
                {
                    move = false;

                    Invoke("ObjectDestroy", 1.0f);
                }
            }
            else
            {
                Invoke("ObjectDestroy", 1.0f);
            }
            
        }

        //y軸移動
        if (GSubManager.instance.SJ_SkillAttack1_3PosX == 0)
        {
            if (GSubManager.instance.Player_PosY < 0.0f)
            {
                if (transform.position.y < 0.33f)
                {
                    move = true;
                    ObjectMove_L();
                }
                else
                {
                    move = false;
                    Debug.Log("停止");

                    Invoke("ObjectDestroy", 1.0f);
                }
            }
            else if (0.0f < GSubManager.instance.Player_PosY)
            {
                if (-0.33f < transform.position.y)
                {
                    move = true;
                    ObjectMove_R();
                }
                else
                {
                    move = false;

                    Invoke("ObjectDestroy", 1.0f);
                }
            }
            else
            {
                Invoke("ObjectDestroy", 1.0f);
            }
        }
    }


    //電圧を右移動させる関数
    void ObjectMove_R()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);

        Debug.Log("移動");
    }


    //電圧を左移動させる関数
    void ObjectMove_L()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        Debug.Log("移動");
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

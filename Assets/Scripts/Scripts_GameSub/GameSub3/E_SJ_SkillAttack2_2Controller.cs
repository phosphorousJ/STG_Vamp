using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_2Controller : MonoBehaviour
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
        //電力の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack2_2PosY < 0)//S
        {
            if (transform.position.y < 0)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;
                Debug.Log("停止");

                Invoke("ObjectRotate", 1.0f);

                Invoke("ObjectDestroy", 4.0f);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack2_2PosY)//N
        {
            if (0 < transform.position.y)
            {
                move = true;
                ObjectMove();
            }
            else
            {
                move = false;

                Invoke("ObjectRotate", 1.0f);

                Invoke("ObjectDestroy", 4.0f);
            }
        }
    }


    void ObjectMove()
    {
        //電力を移動させる
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        Debug.Log("移動");
    }

    void ObjectRotate()
    {
        //電力を回転させる
        transform.Rotate(new Vector3(0, 0, 30));
    }

    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

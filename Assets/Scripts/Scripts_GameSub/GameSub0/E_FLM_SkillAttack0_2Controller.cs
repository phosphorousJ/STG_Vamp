using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_2Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    [SerializeField] [Header("回転速度")] float rotSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //大鎌を回転させる
        transform.Rotate(0, 0, rotSpeed);


        //大鎌の生成位置によって破棄する位置を変える
        if (GSubManager.instance.FLM_SkillAttack0_2PosY < 0)//S
        {
            //大鎌を回転移動させる
            transform.Translate(0, moveSpeed * Time.deltaTime, 0, Space.World);

            if (3.5f <= transform.position.y)
            {
                Destroy(this.gameObject);
            }
        }

        if (GSubManager.instance.FLM_SkillAttack0_2PosX < 0)//W
        {
            //大鎌を回転移動させる
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);

            if (3.5f <= transform.position.x)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.FLM_SkillAttack0_2PosY)//N
        {
            //大鎌を回転移動させる
            transform.Translate(0, -moveSpeed * Time.deltaTime, 0, Space.World);

            if (transform.position.y <= -3.5f)
            {

                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.FLM_SkillAttack0_2PosX)//E
        {
            //大鎌を回転移動させる
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);

            if (transform.position.x <= -3.5f)
            {

                Destroy(this.gameObject);
            }
        }
    }
}

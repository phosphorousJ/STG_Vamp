using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_7Controller : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("移動速度")] float moveSpeed;
    [SerializeField] [Header("回転速度")] float rotSpeed;
    #endregion


    // Update is called once per frame
    void FixedUpdate()
    {
        //電力を回転させる
        transform.Rotate(0, 0, rotSpeed);

        //回転万鈞の生成位置によって破棄する位置を変える
        if (GSubManager.instance.SJ_SkillAttack2_7PosX < 0)//W
        {
            //電力を回転移動させる
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);

            if (7.5f < transform.position.x)
            {
                Destroy(this.gameObject);
            }
        }

        if (0 < GSubManager.instance.SJ_SkillAttack2_7PosX)//E
        {
            //電力を回転移動させる
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);

            if (transform.position.x < -7.5f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

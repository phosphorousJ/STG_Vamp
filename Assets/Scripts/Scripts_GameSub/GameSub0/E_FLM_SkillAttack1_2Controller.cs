using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_2Controller : MonoBehaviour
{
    #region//プライベート設定
    //移動速度
    protected float moveSpeed;

    //回転速度
    protected float rotSpeed;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //移動速度をランダムに変化
        this.moveSpeed = 2.0f + Random.Range(0, 4);

        //回転速度をランダムに変化
        this.rotSpeed = 5.0f + Random.Range(0, 4);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //羽を回転させる
        transform.Rotate(0, 0, rotSpeed);

        //羽を移動させる
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0, Space.World);

        if (transform.position.y <= -4.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

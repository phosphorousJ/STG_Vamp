using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBulletBaseController : MonoBehaviour
{
    #region//インスペクター設定
    [Header("MP弾名称")] public new string name;
    [Header("移動速度")] public float speed;
    #endregion

    #region//プライベート変数
    //オブジェクトの消滅位置
    private float deadLine = -9.0f;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        //MP弾を移動させる
        transform.Translate(0, 0, speed * Time.deltaTime);

        //消滅位置まで移動したら破棄する
        if (transform.position.z < deadLine)
        {
            Destroy(this.gameObject);
            Debug.Log(name + "を破棄");
        }
    }


    //MP弾の衝突処理
    protected virtual void OnTriggerEnter(Collider other)
    {
        //Playerの場合
        if (other.gameObject.tag == "PlayerTag")
        {
            Destroy(this.gameObject);
            Debug.Log(name + "を入手");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_R_SkillAttackController : MonoBehaviour
{
    //R攻撃の移動する速度
    private float upSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //R攻撃を移動させる
        transform.Translate(0, 0, upSpeed * Time.deltaTime);
    }


    //R攻撃の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //Enemyの場合
        if (other.gameObject.tag == "Enemy_FLMTag")
        {
            Destroy(this.gameObject);
            Debug.Log("R攻撃破棄");
        }
    }
}

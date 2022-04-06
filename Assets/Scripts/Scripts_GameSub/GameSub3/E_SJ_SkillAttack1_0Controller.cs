using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack1_0Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //電圧のチャージ処理
        Invoke("ObjectDestroy", 0.5f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

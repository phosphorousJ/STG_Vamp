using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack1_4Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //挟雷の処理
        Invoke("ObjectDestroy", 4.0f);
    }

    
    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

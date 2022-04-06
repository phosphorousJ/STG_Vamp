using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //光線の処理
        Invoke("ObjectDestroy", 0.5f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

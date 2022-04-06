using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack2_4Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //光滞の処理
        Invoke("ObjectDestroy", 10.0f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

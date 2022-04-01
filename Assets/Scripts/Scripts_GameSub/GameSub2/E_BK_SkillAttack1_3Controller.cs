using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack1_3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ObjectDestroy", 15.0f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}

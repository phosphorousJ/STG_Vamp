using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack1_2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ObjectDestroy", 0.5f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}
